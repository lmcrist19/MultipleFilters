using Emgu.CV;
using Emgu.CV.Structure;
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

namespace MultipleFilters
{
    public partial class Form1 : Form
    {
        private VideoCapture _capture;
        private Thread _captureThread;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _capture = new VideoCapture(0);
            _captureThread = new Thread(DisplayWebcam);
            _captureThread.Start();
        }
        private void DisplayWebcam()
        {
            while (_capture.IsOpened)
            {
                Mat frame = _capture.QueryFrame();
                int newHeight = (frame.Size.Height * rawImageBox.Size.Width) / frame.Size.Width;
                Size newSize = new Size(rawImageBox.Size.Width, newHeight);
                CvInvoke.Resize(frame, frame, newSize);
                Invoke(new Action(() => { rawImageBox.Image = frame.Bitmap; }));
                //red isolation
                Mat hsvFrame = new Mat();
                CvInvoke.CvtColor(frame, hsvFrame, Emgu.CV.CvEnum.ColorConversion.Bgr2Hsv);

                Mat[] hsvChannels = hsvFrame.Split();

                Mat hueFilter = new Mat();
                CvInvoke.InRange(hsvChannels[0], new ScalarArray(0), new ScalarArray(255), hueFilter);

                Mat saturationFilter = new Mat();
                CvInvoke.InRange(hsvChannels[1], new ScalarArray(84), new ScalarArray(255), saturationFilter);

                Mat valueFilter = new Mat();
                CvInvoke.InRange(hsvChannels[2], new ScalarArray(80), new ScalarArray(255), valueFilter);

                Mat hsvFilter = new Mat();
                CvInvoke.BitwiseAnd(hueFilter, saturationFilter, hsvFilter);
                CvInvoke.BitwiseAnd(hsvFilter, valueFilter, hsvFilter);

                Invoke(new Action(() => { redIsolationBox.Image = hsvFilter.Bitmap; }));
                //white isolation
                Mat grayFrame = new Mat();
                Mat binaryFrame = new Mat();
                CvInvoke.CvtColor(frame, grayFrame, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
                CvInvoke.Threshold(grayFrame, binaryFrame, 150, 255, Emgu.CV.CvEnum.ThresholdType.Binary);

                Invoke(new Action(() => { whiteIsolationBox.Image = binaryFrame.Bitmap; }));
            }
        }
        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            _captureThread.Abort();
        }
    }
}
