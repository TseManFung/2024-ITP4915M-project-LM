namespace WindowsFormsApp
{
    partial class frmStatusDetail
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
            this.dataGridViewStatusDetail = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatusDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStatusDetail
            // 
            this.dataGridViewStatusDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatusDetail.Location = new System.Drawing.Point(389, 169);
            this.dataGridViewStatusDetail.Name = "dataGridViewStatusDetail";
            this.dataGridViewStatusDetail.RowTemplate.Height = 24;
            this.dataGridViewStatusDetail.Size = new System.Drawing.Size(1105, 413);
            this.dataGridViewStatusDetail.TabIndex = 0;
            // 
            // frmStatusDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.dataGridViewStatusDetail);
            this.Name = "frmStatusDetail";
            this.Text = "Status Detail";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatusDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStatusDetail;
    }
}