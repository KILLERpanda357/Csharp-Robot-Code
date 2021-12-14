using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7
{
    public partial class Form1 : Form
    {
        VideoCapture _capture;
        Thread _captureThread;
        Image<Bgr, byte> imgInput;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // create the capture object and processing thread
            _capture = new VideoCapture(1);
            _captureThread = new Thread(ProcessImage);
            _captureThread.Start();
        }
        private void ProcessImage()
        {
            while (_capture.IsOpened)
            {
                var workingImage = _capture.QueryFrame();

                // resize to PictureBox aspect ratio
                int newHeight = (workingImage.Size.Height * sourcePictureBox.Size.Width) / workingImage.Size.Width;
                Size newSize = new Size(sourcePictureBox.Size.Width, newHeight);
                CvInvoke.Resize(workingImage, workingImage, newSize);
                // as a test for comparison, create a copy of the image with a binary filter:
                var binaryImage = workingImage.ToImage<Gray, byte>().ThresholdBinary(new Gray(125), new
                Gray(255)).Mat;
                // Sample for gaussian blur:
                var blurredImage = new Mat();
                var cannyImage = new Mat();
                var decoratedImage = new Mat();
                CvInvoke.GaussianBlur(workingImage, blurredImage, new Size(3, 3), 0);
                // convert to B/W
                CvInvoke.CvtColor(blurredImage, blurredImage, typeof(Bgr), typeof(Gray));
                // apply canny:
                // NOTE: Canny function can frequently create duplicate lines on the same shape
                //       depending on blur amount and threshold values, some tweaking might be needed.
                //       You might also find that not using Canny and instead using FindContours on
                //       a binary-threshold image is more accurate.
                CvInvoke.Canny(blurredImage, cannyImage, 200, 255);
                // make a copy of the canny image, convert it to color for decorating:
                CvInvoke.CvtColor(cannyImage, decoratedImage, typeof(Gray), typeof(Bgr));
                // find contours:
                using (VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint())
                using (VectorOfPoint approxContour = new VectorOfPoint())
                {
                    // Build list of contours
                    CvInvoke.FindContours(cannyImage, contours, null, RetrType.List,
                    ChainApproxMethod.ChainApproxSimple);
                    int shapeCount = 0;




                    for (int i = 0; i < contours.Size; i++)
                    {
                        var moments = CvInvoke.Moments(contours[i]);
                        int x = (int)(moments.M10 / moments.M00);
                        int y = (int)(moments.M01 / moments.M00);

                        VectorOfPoint contour = contours[i];
                        CvInvoke.ApproxPolyDP(contour, approxContour, CvInvoke.ArcLength(contour, true) * 0.05, true);
                        if (CvInvoke.ContourArea(contour, false) > 250 && CvInvoke.ContourArea(contour, false) < 2000)
                        {
                            Point[] points = approxContour.ToArray();
                            if (approxContour.Size == 3)
                            {
                                CvInvoke.Polylines(decoratedImage, approxContour, true, new Bgr(Color.Green).MCvScalar);
                                CvInvoke.Circle(decoratedImage, new Point(x, y), 1, new Bgr(Color.Green).MCvScalar, 1);
                                Invoke(new Action(() =>
                                {
                                    label1.Text = $"X coord: {x}  & Y coord: {y} Triangle";
                                }));

                                shapeCount++;
                            }
                            else if (approxContour.Size == 4)
                            {
                                CvInvoke.Polylines(decoratedImage, approxContour, true, new Bgr(Color.Red).MCvScalar);
                                CvInvoke.Circle(decoratedImage, new Point(x, y), 1, new Bgr(Color.Red).MCvScalar, 1);
                                Invoke(new Action(() =>
                                {
                                    label1.Text = $"X coord: {x}  & Y coord: {y}  Square";
                                }));
                                shapeCount++;
                            }
                            else
                            {
                                CvInvoke.Polylines(decoratedImage, approxContour, true, new Bgr(Color.Yellow).MCvScalar);
                            }
                            
                        }
                        
                    }
                    Invoke(new Action(() =>
                    {
                        shapeCountLbl.Text = $"There are {shapeCount} shapes detected";
                    }));

                    Invoke(new Action(() =>
                    {
                        contourLbl.Text = $"There are {contours.Size} contours detected";
                    }));
                    
                }

                // output images:
                sourcePictureBox.Image = workingImage.Bitmap;
                contourPictureBox.Image = decoratedImage.Bitmap;



            }




        }
    }
}
