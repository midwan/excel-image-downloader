using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;

namespace Image_Downloader
{
    public partial class ImageDownloaderRibbon
    {
        private void ImageDownloaderRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void ButtonGetImages_Click(object sender, RibbonControlEventArgs e)
        {
            var form = new InProgress();
            form.Show();
        }
    }
}
