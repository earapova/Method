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
    public partial class Training : Form
    {
        public Training()
        {
            InitializeComponent();
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

        private void Training_Load(object sender, EventArgs e)
        {
            cbPCK2.Visible = false;
            cbPrepod2.Visible = false;
            txtYear.Text = Convert.ToString(DateTime.Now.Year);
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

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cbPCK2.Visible = false;
            cbPrepod2.Visible = false;
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

   
    }
}
