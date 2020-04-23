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
    public partial class MethodWork : Form
    {
        public MethodWork()
        {
            InitializeComponent();
        }

        private void MethodWork_Load(object sender, EventArgs e)
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
    }
}
