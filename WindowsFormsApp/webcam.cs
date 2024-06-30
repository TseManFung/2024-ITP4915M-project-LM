using WindowsFormsApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace WindowsFormsApp
{
    public partial class frmWebcam : Form
    {
        public frmWebcam()
        {
            InitializeComponent();
            
        }
        FilterInfoCollection FInfoC;
        VideoCaptureDevice cam;

        public string scanCode { get; set; }


        private void cam_NewFrame(object sender, NewFrameEventArgs e)
        {
            int H=picCamera.Height;
            Bitmap Frame = (Bitmap)e.Frame.Clone();
            int W=H*Frame.Width/Frame.Height;
            picCamera.Image= new Bitmap(Frame, new Size(W, H));
        }

        private void frmWebcam_Load(object sender, EventArgs e)
        {
            FInfoC = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo FInfo in FInfoC)
            {
                cboCamera.Items.Add(FInfo.Name);
            }
            cboCamera.SelectedIndex = 0;
            timer.Start();
            
        }

        private void frmWebcam_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(timer.Enabled)
            {
                timer.Stop();
            }
            if (cam.IsRunning) { 
                cam.Stop();
            }
        }

        private void cboCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
            cam = new VideoCaptureDevice(FInfoC[cboCamera.SelectedIndex].MonikerString);
            cam.NewFrame += cam_NewFrame;
            cam.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (picCamera.Image != null) { 
                BarcodeReader Reader = new BarcodeReader();
                Result result = Reader.Decode((Bitmap)picCamera.Image);
                try
                {
                    if (result != null)
                    {
                        string decoded = result.ToString().Trim();
                         this.scanCode = decoded;
                        lblCode.Text = decoded + " | " + Resources.Scanning;
                    }
                    else {
                        if (scanCode != null)
                        {
                            lblCode.Text = this.scanCode + " | " + Resources.Scanning;
                        }
                        else {
                            lblCode.Text = Resources.Scanning;
                        }
                        
                    }
                }
                catch (Exception ex)
                {
                    
                    Console.WriteLine(ex.Message);
                }
            }
        }


    }
}
