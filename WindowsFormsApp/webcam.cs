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
        private void btnScreen_Click(object sender, EventArgs e)
        {
            cam = new VideoCaptureDevice(FInfoC[cboCamera.SelectedIndex].MonikerString);
            cam.NewFrame += cam_NewFrame;
            cam.Start();
        }

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
            cam = new VideoCaptureDevice();
        }

        private void frmWebcam_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cam.IsRunning) { 
                cam.Stop();
            }
        }
    }
}
