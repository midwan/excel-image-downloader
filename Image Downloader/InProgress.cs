using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Downloader
{
    public partial class InProgress : Form
    {
        private bool _cancellationPending;

        public InProgress()
        {
            Application.EnableVisualStyles();
            InitializeComponent();
            _cancellationPending = false;
        }

        private void ButtonAbort_Click(object sender, EventArgs e)
        {
            _cancellationPending = true;
            Globals.ThisAddIn.Cleanup();
            Close();
        }

        private async void ButtonStart_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            LabelStatus.Text = @"Please wait, this can take a long time depending on the number of URLs...";
            
            await DoWork();

            if (InvokeRequired)
                Invoke(new Action(Close));
            else
                Close();
        }

        private async Task DoWork()
        {
            var column = Globals.ThisAddIn.FindUrlColumn();
            if (column == 0)
            {
                _cancellationPending = true;
                if (LabelStatus.InvokeRequired)
                    Invoke(new Action(() =>
                        LabelStatus.Text = @"No column containing URLs was found! Cannot proceed..."));
                else
                    LabelStatus.Text = @"No column containing URLs was found! Cannot proceed...";
                return;
            }

            var totalRows = Globals.ThisAddIn.CountRowsWithUrls(column);
            Globals.ThisAddIn.InsertImagesColumn(column);

            var row = Globals.ThisAddIn.GetStartingRow();
            var url = Globals.ThisAddIn.GetCellValue(row, column + 1);

            while (!string.IsNullOrEmpty(url))
            {
                if (_cancellationPending) break;

                // Perform a time consuming operation and report progress.
                if (Globals.ThisAddIn.IsValidUrl(url))
                    try
                    {
                        await Globals.ThisAddIn.DownloadImage(url);
                        Globals.ThisAddIn.InsertImage("image.png", row, column);
                    }
                    catch (Exception exception)
                    {
                        Globals.ThisAddIn.AddCellComment(row, column + 1, exception.Message);
                    }

                ProgressChanged(row * 100 / totalRows);

                row++;
                url = Globals.ThisAddIn.GetCellValue(row, column + 1);
            }

            Globals.ThisAddIn.UpdateColumnWidth(column);
            WorkCompleted();
        }

        // This event handler updates the progress.
        private void ProgressChanged(int percentage)
        {
            if (percentage > 100)
                percentage = 100;
            if (progressBar1.InvokeRequired)
                Invoke(new Action(() => progressBar1.Value = percentage));
            else
                progressBar1.Value = percentage;
        }

        private void WorkCompleted()
        {
            Globals.ThisAddIn.Cleanup();
            if (LabelStatus.InvokeRequired)
                Invoke(new Action(() => LabelStatus.Text = @"Done!"));
            else
                LabelStatus.Text = @"Done!";
        }
    }
}