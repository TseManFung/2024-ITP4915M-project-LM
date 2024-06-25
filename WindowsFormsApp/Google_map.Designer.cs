namespace WindowsFormsApp
{
    partial class Google_map
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.lbllocation = new System.Windows.Forms.Label();
            this.lbllatitude = new System.Windows.Forms.Label();
            this.txtlocation = new System.Windows.Forms.TextBox();
            this.txtlatitude = new System.Windows.Forms.TextBox();
            this.txtlongitude = new System.Windows.Forms.TextBox();
            this.lbllongitude = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btncomplete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(414, 450);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // map
            // 
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(0, 0);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(414, 450);
            this.map.TabIndex = 1;
            this.map.Zoom = 0D;
            this.map.OnMapClick += new GMap.NET.WindowsForms.MapClick(this.map_OnMapClick);
            this.map.Load += new System.EventHandler(this.map_Load);
            this.map.Click += new System.EventHandler(this.map_Click);
            // 
            // lbllocation
            // 
            this.lbllocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbllocation.AutoSize = true;
            this.lbllocation.Location = new System.Drawing.Point(454, 138);
            this.lbllocation.Name = "lbllocation";
            this.lbllocation.Size = new System.Drawing.Size(46, 12);
            this.lbllocation.TabIndex = 2;
            this.lbllocation.Text = "Location";
            // 
            // lbllatitude
            // 
            this.lbllatitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbllatitude.AutoSize = true;
            this.lbllatitude.Location = new System.Drawing.Point(453, 205);
            this.lbllatitude.Name = "lbllatitude";
            this.lbllatitude.Size = new System.Drawing.Size(43, 12);
            this.lbllatitude.TabIndex = 3;
            this.lbllatitude.Text = "Latitude";
            // 
            // txtlocation
            // 
            this.txtlocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlocation.Location = new System.Drawing.Point(529, 128);
            this.txtlocation.Name = "txtlocation";
            this.txtlocation.Size = new System.Drawing.Size(113, 22);
            this.txtlocation.TabIndex = 4;
            // 
            // txtlatitude
            // 
            this.txtlatitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlatitude.Location = new System.Drawing.Point(529, 197);
            this.txtlatitude.Name = "txtlatitude";
            this.txtlatitude.Size = new System.Drawing.Size(113, 22);
            this.txtlatitude.TabIndex = 5;
            // 
            // txtlongitude
            // 
            this.txtlongitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlongitude.Location = new System.Drawing.Point(529, 234);
            this.txtlongitude.Name = "txtlongitude";
            this.txtlongitude.Size = new System.Drawing.Size(113, 22);
            this.txtlongitude.TabIndex = 7;
            // 
            // lbllongitude
            // 
            this.lbllongitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbllongitude.AutoSize = true;
            this.lbllongitude.Location = new System.Drawing.Point(454, 242);
            this.lbllongitude.Name = "lbllongitude";
            this.lbllongitude.Size = new System.Drawing.Size(53, 12);
            this.lbllongitude.TabIndex = 6;
            this.lbllongitude.Text = "Longitude";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Location = new System.Drawing.Point(527, 75);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(109, 12);
            this.lbltitle.TabIndex = 8;
            this.lbltitle.Text = "Please select a location";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Location = new System.Drawing.Point(529, 307);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(113, 24);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btncomplete
            // 
            this.btncomplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncomplete.Location = new System.Drawing.Point(529, 355);
            this.btncomplete.Name = "btncomplete";
            this.btncomplete.Size = new System.Drawing.Size(113, 24);
            this.btncomplete.TabIndex = 10;
            this.btncomplete.Text = "Complete";
            this.btncomplete.UseVisualStyleBackColor = true;
            this.btncomplete.Click += new System.EventHandler(this.btncomplete_Click);
            // 
            // Google_map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncomplete);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.txtlongitude);
            this.Controls.Add(this.lbllongitude);
            this.Controls.Add(this.txtlatitude);
            this.Controls.Add(this.txtlocation);
            this.Controls.Add(this.lbllatitude);
            this.Controls.Add(this.lbllocation);
            this.Controls.Add(this.map);
            this.Controls.Add(this.splitter1);
            this.Name = "Google_map";
            this.Text = "Google_map";
            this.Load += new System.EventHandler(this.Google_map_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Label lbllocation;
        private System.Windows.Forms.Label lbllatitude;
        private System.Windows.Forms.TextBox txtlocation;
        private System.Windows.Forms.TextBox txtlatitude;
        private System.Windows.Forms.TextBox txtlongitude;
        private System.Windows.Forms.Label lbllongitude;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btncomplete;
    }
}