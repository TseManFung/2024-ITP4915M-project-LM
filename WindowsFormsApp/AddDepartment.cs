﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class frmAddDepartment : Form
    {
        public frmAddDepartment()
        {
            InitializeComponent();
        }

        private void radYes_CheckedChanged(object sender, EventArgs e)
        {
            tableLayoutPanel5.Visible = radYes.Checked;
        }

        private void frmAddDepartment_Resize(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.ResizeControlsFont(this);
        }

        private void frmAddDepartment_Load(object sender, EventArgs e)
        {

        }
    }
}
