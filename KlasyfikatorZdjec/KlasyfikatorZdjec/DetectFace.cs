using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;

namespace KlasyfikatorZdjec
{
    class DetectFace
    {

        public static int Run(string path)
        {

            Image<Bgr, Byte> image = new Image<Bgr, byte>(path); //Read the files as an 8-bit Bgr image  
            Image<Gray, Byte> gray = image.Convert<Gray, Byte>(); //Convert it to Grayscale

            Stopwatch watch = Stopwatch.StartNew();
            //normalizes brightness and increases contrast of the image
            gray._EqualizeHist();

            //Read the HaarCascade objects
            HaarCascade face = new HaarCascade("haarcascade_frontalface_alt_tree.xml");

            //Detect the faces  from the gray scale image and store the locations as rectangle
            //The first dimensional is the channel
            //The second dimension is the index of the rectangle in the specific channel
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
               face,
               1.1,
               10,
               Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
               new Size(20, 20));

            //zmienne pomocnicze do zliczania twarzy
            int liczbaTwarzy = 0;
            string message = "";

            foreach (MCvAvgComp f in facesDetected[0])
            {
                //draw the face detected in the 0th (gray) channel with red color
                image.Draw(f.rect, new Bgr(Color.Red), 2);

                //Set the region of interest on the faces
                gray.ROI = f.rect;

                //dla kazdej znalezionej twarzy zmienna zwieksza sie
                liczbaTwarzy = liczbaTwarzy+1;
            }

            ////messagebox z iloscia twarzy, pomocniczy do testow
            //message = liczbaTwarzy.ToString();
            //MessageBox.Show(message);

            //watch.Stop();
            ////display the image 
            //ImageViewer.Show(image, String.Format("Perform face and eye detection in {0} milliseconds", watch.ElapsedMilliseconds));
            return liczbaTwarzy;
        }
    }
}