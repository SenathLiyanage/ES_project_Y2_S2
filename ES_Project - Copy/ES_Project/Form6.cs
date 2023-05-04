using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES_Project
{
    public partial class Form6 : Form
    {


        public string Bill_Num { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string NIC_Num { get; set; }
        public string Con_Num { get; set; }
        public string Pro_Info { get; set; }
        public string Tot_Wgt { get; set; }
        public string Tot_Prd { get; set; }
        public string Amt { get; set; }
        public string Amt1 { get; set; }
        public string Amt2 { get; set; }
        public string Amt3 { get; set; }


        public Form6()
        {
            InitializeComponent();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            textBox_12.Text = Bill_Num;
            textBox_2.Text = Name;
            textBox_3.Text = Address;
            textBox_1.Text = NIC_Num;
            textBox_4.Text = Con_Num;
            textBox_5.Text = Pro_Info;
            textBox_6.Text = Tot_Wgt;
            textBox_7.Text = Tot_Prd;
            textBox_8.Text = Amt;
            textBox_9.Text = Amt1;
            textBox_10.Text = Amt2;
            textBox_11.Text = Amt3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            printDocument.Print();
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5 = new Form5();
            form5.Show();
        }
    }
}
