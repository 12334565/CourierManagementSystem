using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CourierManagementSystem
{
    public partial class Dashboard : Form

    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            movingpanel.Left = btnAdd.Left + 18;

        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            movingpanel.Left = btnBooking.Left+18;
        }

        private void btnTracking_Click(object sender, EventArgs e)
        {
            movingpanel.Left = btnTracking.Left+18;
        }

        private void btnContactus_Click(object sender, EventArgs e)
        {
            movingpanel.Left=btnContactus.Left+18;
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            movingpanel.Left = btnFeedback.Left+18;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
