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
    public partial class Mydoctor : Form
    {
        public Mydoctor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Tag = this;
            main.Show(this);
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var mecg = (MyECG)Tag;
            mecg.Show();
            Close();
        }
    }
}
