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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Google_map));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.lbllocation = new System.Windows.Forms.Label();
            this.lbllatitude = new System.Windows.Forms.Label();
            this.txtlocation = new System.Windows.Forms.TextBox();
            this.txtlatitude = new System.Windows.Forms.TextBox();
            this.txtlongitude = new System.Windows.Forms.TextBox();
            this.lbllongitude = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnlocate = new System.Windows.Forms.Button();
            this.btncomplete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            resources.ApplyResources(this.splitter1, "splitter1");
            this.splitter1.Name = "splitter1";
            this.splitter1.TabStop = false;
            // 
            // map
            // 
            resources.ApplyResources(this.map, "map");
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
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
            this.map.Zoom = 0D;
            this.map.OnMapClick += new GMap.NET.WindowsForms.MapClick(this.map_OnMapClick);
            this.map.Load += new System.EventHandler(this.map_Load);
            this.map.Click += new System.EventHandler(this.map_Click);
            // 
            // lbllocation
            // 
            resources.ApplyResources(this.lbllocation, "lbllocation");
            this.lbllocation.Name = "lbllocation";
            // 
            // lbllatitude
            // 
            resources.ApplyResources(this.lbllatitude, "lbllatitude");
            this.lbllatitude.Name = "lbllatitude";
            // 
            // txtlocation
            // 
            resources.ApplyResources(this.txtlocation, "txtlocation");
            this.txtlocation.Name = "txtlocation";
            // 
            // txtlatitude
            // 
            resources.ApplyResources(this.txtlatitude, "txtlatitude");
            this.txtlatitude.Name = "txtlatitude";
            this.txtlatitude.TextChanged += new System.EventHandler(this.txtlatitude_TextChanged);
            // 
            // txtlongitude
            // 
            resources.ApplyResources(this.txtlongitude, "txtlongitude");
            this.txtlongitude.Name = "txtlongitude";
            this.txtlongitude.TextChanged += new System.EventHandler(this.txtlongitude_TextChanged);
            // 
            // lbllongitude
            // 
            resources.ApplyResources(this.lbllongitude, "lbllongitude");
            this.lbllongitude.Name = "lbllongitude";
            // 
            // lbltitle
            // 
            resources.ApplyResources(this.lbltitle, "lbltitle");
            this.lbltitle.Name = "lbltitle";
            // 
            // btnlocate
            // 
            resources.ApplyResources(this.btnlocate, "btnlocate");
            this.btnlocate.Name = "btnlocate";
            this.btnlocate.UseVisualStyleBackColor = true;
            this.btnlocate.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btncomplete
            // 
            resources.ApplyResources(this.btncomplete, "btncomplete");
            this.btncomplete.Name = "btncomplete";
            this.btncomplete.UseVisualStyleBackColor = true;
            this.btncomplete.Click += new System.EventHandler(this.btncomplete_Click);
            // 
            // Google_map
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btncomplete);
            this.Controls.Add(this.btnlocate);
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
        private System.Windows.Forms.Button btnlocate;
        private System.Windows.Forms.Button btncomplete;
    }
}