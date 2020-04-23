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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Workers frm = new Workers();
            frm.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MethodWork frm = new MethodWork();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Training frm = new Training();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Students frm = new Students();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
 Spravoch frm = new Spravoch();
            frm.Show();
        }
    }
}
