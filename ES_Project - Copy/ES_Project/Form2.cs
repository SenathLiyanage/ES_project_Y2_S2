using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES_Project
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
          //  lbl_loguser.Text = log;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            Form1 b = new Form1();
            b.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 c = new Form3();
            c.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ulog.type))
            {
                if (ulog.type == "A")
                {
                    btn_NewMor.Visible = true;
                    btn_Pay.Visible = true;
                    btn_Rep.Visible = true;
                    btn_Mes.Visible = true;
                    btn_Cus.Visible = true;
                    btn_Web.Visible = true;
                }
                else if (ulog.type == "C")
                {
                    btn_NewMor.Visible = true;
                    btn_Pay.Visible = true;
                    btn_Rep.Visible = false;
                    btn_Mes.Visible = false;
                    btn_Cus.Visible = true;
                    btn_Web.Visible = true;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
