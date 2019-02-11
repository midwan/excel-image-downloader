using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Image_Downloader.Properties;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Excel;

namespace Image_Downloader
{
    public partial class ThisAddIn
    {
        // Create a New HttpClient object.
        private HttpClient _client;
        private int _columnWidth;

        private void ThisAddIn_Startup(object sender, EventArgs e)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            _columnWidth = 0;

            var httpClientHandler = new HttpClientHandler
            {
                UseDefaultCredentials = true
            };

            if (Settings.Default.AuthRequired)
            {
                httpClientHandler.PreAuthenticate = true;
                httpClientHandler.UseDefaultCredentials = false;
                httpClientHandler.Credentials = new NetworkCredential
                {
                    UserName = Settings.Default.AuthUsername,
                    Password = Settings.Default.AuthPassword
                };
            }

            _client = new HttpClient(httpClientHandler, true);
        }

        private void ThisAddIn_Shutdown(object sender, EventArgs e)
        {
        }

        public int FindUrlColumn()
        {
            return Settings.Default.ColumnDetectionManual
                ? GetSelectedColumn()
                : FindUrlColumnAutomatic();
        }

        private int FindUrlColumnAutomatic()
        {
            const int row = 2;
            var column = 1;

            Range cell = Application.Cells[row, column];
            if (cell.Value == null)
                return 0;
            while (!string.IsNullOrEmpty(cell.Value?.ToString()))
            {
                if (IsValidUrl(cell.Value?.ToString()))
                    return column;

                column++;
                cell = Application.Cells[row, column];
            }

            return 0;
        }

        private int GetSelectedColumn()
        {
            var cell = Application.ActiveCell;
            return cell.Column;
        }

        private int GetSelectedRow()
        {
            var cell = Application.ActiveCell;
            return cell.Row;
        }

        public void InsertImagesColumn(int column)
        {
            Application.Cells[1, column].EntireColumn.Insert();
            Range cell = Application.Cells[1, column];
            cell.Value = "Images";
        }

        public string GetCellValue(int row, int column)
        {
            var cell = Application.Cells[row, column];
            var value = cell.Value;
            return value != null ? (string) value.ToString() : null;
        }

        public void Cleanup()
        {
            try
            {
                File.Delete("image.png");
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
        }

        public async Task DownloadImage(string url)
        {
            try
            {
                var stream = await _client.GetStreamAsync(url);
                var bitmap = new Bitmap(stream);
                bitmap.Save("image.png", ImageFormat.Png);
            }
            catch (Exception e)
            {
                Debug.WriteLine($"{e}, {e.Message}, {e.InnerException}");
            }
        }

        public void InsertImage(string url, int row, int column)
        {
            Range imageCell = Application.Cells[row, column];

            var image = Application.ActiveSheet.Shapes.AddPicture(
                url, MsoTriState.msoFalse, MsoTriState.msoCTrue,
                Application.Columns[imageCell.Column].Left,
                Application.Rows[imageCell.Row].Top,
                -1, -1);

            if (image.Height > 100)
                image.Height = 100;
            if (image.Width > 100)
                image.Width = 100;

            imageCell.EntireRow.RowHeight = image.Height;
            CalculateLargestColumnWidth((int) image.Width);
            image.Placement = XlPlacement.xlMove;
        }

        private void CalculateLargestColumnWidth(int imageWidth)
        {
            if (imageWidth > _columnWidth)
                _columnWidth = imageWidth <= 100 ? imageWidth : 100;
        }

        public void AddCellComment(int row, int column, string comment)
        {
            var cell = Application.Cells[row, column];
            cell.AddComment(comment);
        }

        public bool IsValidUrl(string value)
        {
            return value.StartsWith("http://") ||
                   value.StartsWith("https://");
        }

        public int GetStartingRow()
        {
            return Settings.Default.RowDetectionManual
                ? GetSelectedRow()
                : 2; // we assume row 1 is Titles only
        }

        public int CountRowsWithUrls(int column)
        {
            var result = 1;
            var row = GetStartingRow();

            var value = GetCellValue(row, column);
            while (!string.IsNullOrEmpty(value))
            {
                if (IsValidUrl(value))
                    result++;
                row++;
                value = GetCellValue(row, column);
            }

            return result;
        }

        public void UpdateColumnWidth(int column)
        {
            Range cell = Application.Cells[1, column];
            cell.EntireColumn.ColumnWidth = _columnWidth;
        }

        #region VSTO generated code

        /// <summary>
        ///     Required method for Designer support - do not modify
        ///     the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            Startup += ThisAddIn_Startup;
            Shutdown += ThisAddIn_Shutdown;
        }

        #endregion
    }
}