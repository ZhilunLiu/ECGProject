using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ECGProject
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            setLableText();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyECG mecg = new MyECG();
            mecg.Tag = this;
            mecg.Show(this);
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mydoctor mdo = new Mydoctor();
            mdo.Tag = this;
            mdo.Show(this);
            Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {    
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void setLableText()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\charl\OneDrive\桌面\ECGproject\test.mdf;Integrated Security=True;Connect Timeout=30 ");
            con.Open();
            string query1 = "select * from Dates where id = 1";
            string query2 = "select count(date) from Dates";

            SqlCommand cmd = new SqlCommand(query1, con);
            SqlCommand cmd2 = new SqlCommand(query2, con);
            //int count = 0;
            object count = cmd2.ExecuteScalar();
            SqlDataReader dr = cmd.ExecuteReader();
            if (count != null) { label12.Text = count.ToString(); }
            while (dr.Read())
            {
                label5.Text = dr["Date"].ToString();
                label10.Text = dr["period"].ToString();
                //count++;
               
            }
            //label12.Text = count.ToString;
        }
    }
}
