using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method
{
    public partial class Workers : Form
    {
        public Workers()
        {
            InitializeComponent();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Workers_Load(object sender, EventArgs e)
        {
            cbPCK2.Visible = false;
            cbPrepod2.Visible = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cbPCK2.Visible = false;
            cbPrepod2.Visible = true;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cbPCK2.Visible = true;
            cbPrepod2.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cbPCK2.Visible = false;
            cbPrepod2.Visible = false;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cbPCK2.Visible = false;
            cbPrepod2.Visible = false;
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cbPCK2.Visible = false;
            cbPrepod2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsWorkers frm = new InsWorkers();
            frm.ShowDialog();
        }
    }
}
