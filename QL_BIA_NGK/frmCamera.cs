using AForge.Video.DirectShow;
using DevExpress.Data.Async;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace QL_BIA_NGK
{
    public partial class frmCamera : DevExpress.XtraEditors.XtraForm
    {
        private FilterInfoCollection devices;
        private VideoCaptureDevice finalFrame;

        // thêm 1 timer để delay khoảng thời gian giữa 2 lần quét
        private Timer timerDelay;
        private int delayTime;

        // delegate truyền dữ liệu quét được về form camera
        public delegate void CaptureDelegate(string result);
        public event CaptureDelegate captureEvent;

        public frmCamera()
        {
            InitializeComponent();
        }

        private void frmCamera_Load(object sender, EventArgs e)
        {
            devices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            finalFrame = new VideoCaptureDevice(devices[0].MonikerString);
            finalFrame.NewFrame += FinalFrame_NewFrame;
            finalFrame.Start();

            timer1.Interval = 100;
            timer1.Start();

            timerDelay = new Timer();
            // set thời gian delay giữa 2 lần quét là 1s
            timerDelay.Interval = 1000;
            timerDelay.Tick += (sender2, e2) => { delayTime++; };
            delayTime = 1;
        }

        private void FinalFrame_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            picCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (delayTime == 0) return;
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)picCamera.Image);
                if (result == null) return;
                string decode = result.ToString().Trim();
                if (decode != "")
                {
                    timer1.Stop();
                    // tìm thấy qr code
                    if (captureEvent != null)
                    {
                        timerDelay.Stop();
                        captureEvent(decode);
                        delayTime = 0;
                        timerDelay.Start();
                    }
                    
                    timer1.Start();
                }
            }
            catch (Exception)
            {

            }
        }
        // tắt webcam khi đóng form
        private void frmCamera_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (finalFrame.IsRunning == true)
            {
                finalFrame.Stop();
            }
        }
    }
}