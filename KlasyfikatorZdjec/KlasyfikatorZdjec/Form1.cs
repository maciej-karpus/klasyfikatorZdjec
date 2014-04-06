using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlasyfikatorZdjec
{
    public partial class Form1 : Form
    {
        private string directoryOfOperations;

        public Form1()
        {
            InitializeComponent();
        }

        private string[] getAllImagesFromDirectory(string directory)
        {
            string[] extensions = { "jpg", "jpeg", "png", "bmp" };
            string[] files = Directory.GetFiles(directory, "*.*")
                .Where(f => extensions.Contains(f.Split('.').Last().ToLower())).ToArray();

            return files;
        }

        private void loadImages(string[] files)
        {
            imageList.ImageSize = new Size(100, 100);
            imageList.ColorDepth = ColorDepth.Depth32Bit;

            int i = 0;
            foreach (string file in files)
            {
                Image img = Image.FromFile(file);
                imageList.Images.Add(getThumbnailImage(imageList.ImageSize.Width, img));
                img.Dispose();
                listView.Items.Add(file);
                listView.Items[i].ImageIndex = i;
                i++;
            }

            listView.View = View.LargeIcon;
            listView.LargeImageList = imageList;
        }

        private Image getThumbnailImage(int width, Image img)
        {
            Image thumb = new Bitmap(width, width);
            Image tmp = null;

            if (img.Width < width && img.Height < width)
            {
                using (Graphics g = Graphics.FromImage(thumb))
                {
                    int xoffset = (int)((width - img.Width) / 2);
                    int yoffset = (int)((width - img.Height) / 2);
                    g.DrawImage(img, xoffset, yoffset, img.Width, img.Height);
                }
            }
            else
            {
                Image.GetThumbnailImageAbort myCallback = new Image.GetThumbnailImageAbort(ThumbnailCallback);

                if (img.Width == img.Height)
                {
                    thumb = img.GetThumbnailImage(width, width, myCallback, IntPtr.Zero);
                }
                else
                {
                    int k = 0;
                    int xoffset = 0;
                    int yoffset = 0;

                    if (img.Width < img.Height)
                    {
                        k = (int)(width * img.Width / img.Height);
                        tmp = img.GetThumbnailImage(k, width, myCallback, IntPtr.Zero);
                        xoffset = (int)((width - k) / 2);
                    }

                    if (img.Width > img.Height)
                    {
                        k = (int)(width * img.Height / img.Width);
                        tmp = img.GetThumbnailImage(width, k, myCallback, IntPtr.Zero);
                        yoffset = (int)((width - k) / 2);
                    }

                    using (Graphics g = Graphics.FromImage(thumb))
                    {
                        g.DrawImage(tmp, xoffset, yoffset, tmp.Width, tmp.Height);
                    }
                }
            }

            using (Graphics g = Graphics.FromImage(thumb))
            {
                g.DrawRectangle(Pens.Green, 0, 0, thumb.Width - 1, thumb.Height - 1);
            }

            return thumb;
        }

        public bool ThumbnailCallback()
        {
            return true;
        }

        private void directoryPicker_Click(object sender, EventArgs e)
        {
            var dialog = new System.Windows.Forms.FolderBrowserDialog();
            if (!string.IsNullOrEmpty(directoryOfOperations))
                dialog.SelectedPath = directoryOfOperations;

            System.Windows.Forms.DialogResult result = dialog.ShowDialog();
            if (!string.IsNullOrEmpty(dialog.SelectedPath))
            {
                directoryOfOperations = dialog.SelectedPath;

                imageList.Images.Clear();
                listView.Items.Clear();
                loadImages(getAllImagesFromDirectory(directoryOfOperations));

                chosenDirectoryBox.Text = directoryOfOperations;
            }
        }

        private void refreshImagesButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(directoryOfOperations))
            {
                imageList.Images.Clear();
                listView.Items.Clear();
                loadImages(getAllImagesFromDirectory(directoryOfOperations));
            }
        }
    }
}
