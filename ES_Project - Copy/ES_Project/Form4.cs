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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Printing;

namespace ES_Project
{
    public partial class Form4 : Form
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

        public Form4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

       private void Form4_Load(object sender, EventArgs e)
       {

            /* string connectionString = "detailsDBString";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
              connection.Open();
                string sql = "SELECT Bill_Num, Name, Address, NIC_Num, Con_Num, Pro_Info, Tot_Wgt, Tot_Prd, Amt FROM FormData ORDER BY Id DESC";
               using (SqlCommand command = new SqlCommand(sql, connection))
                {
                   SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                   {
                        label_00.Text = reader.GetString(1);
                        label_11.Text = reader.GetString(2);
                        label_22.Text = reader.GetString(3);
                        label_33.Text = reader.GetString(4);
                        label_44.Text = reader.GetString(5);
                        label_55.Text = reader.GetString(6);
                        label_66.Text = reader.GetString(7);
                        label_77.Text = reader.GetString(8);
                        label_88.Text = reader.GetString(9);
                       
                    }
                }
            }*/

            textBox1.Text = Bill_Num;
            textBox2.Text = Name;
            textBox3.Text = Address;
            textBox4.Text = NIC_Num;
            textBox5.Text = Con_Num;
            textBox6.Text = Pro_Info;
            textBox7.Text = Tot_Wgt;
            textBox8.Text = Tot_Prd;
            textBox9.Text = Amt;


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
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
