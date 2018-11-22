using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECGProject
{
    public partial class MyECG : Form
    {
        public MyECG()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var main = (Main)Tag;
            main.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mydoctor mdo = new Mydoctor();
            mdo.Tag = this;
            mdo.Show(this);
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
