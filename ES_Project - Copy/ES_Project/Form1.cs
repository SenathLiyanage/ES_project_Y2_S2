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

namespace ES_Project
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.loginDBConnectionString);
        SqlDataAdapter da;
        //SqlDataReader dr;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //string log;

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            // Form2 a = new Form2();
            // a.Show();

            con.Open();
            cmd = new SqlCommand("SELECT * FROM tbllog WHERE NICnumber=@NICnumber AND Password=@Password", con);
            cmd.Parameters.AddWithValue("@NICnumber", txtname.Text);
            cmd.Parameters.AddWithValue("@Password", txtpwd.Text);
           
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds); 
            int i = ds.Tables[0].Rows.Count;
            if (i == 1)
            {
                 SqlDataReader dr = cmd.ExecuteReader();
                 dr.Read();
                 if (dr[2].ToString() == "Admin123")
                 {
                     ulog.type = "A";
                 }
                 else if (dr[2].ToString() == "Cashier123")
                 {
                     ulog.type = "C";
                 }

               //  log = "Welcome:" + txtname.Text;
                 this.Hide();
                 Form2 a = new Form2();
                 a.Show();
                 
            }

            else
            {
                MessageBox.Show("Please Check Your NIC-NUmber Or Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
