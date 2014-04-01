using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyfikatorZdjec
{
    class Histograms
    {
        long[] histogramRed { get; set; }
        long[] histogramBlue { get; set; }
        long[] histogramGreen { get; set; }
        long[] histogram { get; set; }
        long[] cumulativeHistogram { get; set; }
        string path { get; set; }

        public Histograms(string path)
        {
            this.path = path;
            this.cumulativeHistogram = new long[256];
        }

        public void setHistograms()
        {
            Bitmap picture = new Bitmap(Image.FromFile(path));

            this.histogramRed = new long[256];
            this.histogram = new long[256];
            this.histogramBlue = new long[256];
            this.histogramGreen = new long[256];

            for (int i = 0; i < picture.Size.Width; i++)
            {
                for (int j = 0; j < picture.Size.Height; j++)
                {
                    System.Drawing.Color c = picture.GetPixel(i, j);

                    long Temp = 0;
                    Temp += c.R;
                    Temp += c.G;
                    Temp += c.B;

                    Temp = (int)Temp / 3;
                    this.histogram[Temp]++;

                    this.histogramBlue[c.B]++;
                    this.histogramGreen[c.G]++;
                    this.histogramRed[c.R]++;
                }
            }
        }

        public void setCumulativeHistogram()
        {
            if (this.histogram == null)
            {
                return;
            }
            else
            {
                this.cumulativeHistogram[0] = this.histogram[0];
                for (int i = 1; i < this.histogram.Length; i++)
                {
                    this.cumulativeHistogram[i] = this.cumulativeHistogram[i - 1] + this.histogram[i];
                }
            }
        }
    }
}
