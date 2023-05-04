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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_Bill.Clear();
            txt_Name.Clear();
            txt_Add.Clear();
            txt_Nic.Clear();
            txt_Con.Clear();
            txt_Pro.Clear();
            txt_Weg.Clear();
            txt_Per.Clear();
            txt_Amo.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // string connectionString = "detailsDBString";
            // string connectionString = "Data Source=myServerAddress;Initial Catalog=myDataBase;User Id=myUsername;Password=myPassword;";

            // Server = myServerAddress; Database = myDataBase; User Id = myUsername; Password = myPassword;
            // using (SqlConnection connection = new SqlConnection(connectionString))
            //  {
            //  connection.Open();
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\ASUS\\Desktop\\ES_Project - Copy\\ES_Project\\detailsDB.mdf\";Integrated Security=True;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            command.CommandText = "INSERT INTO tbldetails (Bill_Num, Name, Address, NIC_Num, Con_Num, Pro_Info, Tot_Wgt, Tot_Prd, Amt) VALUES (@Bill_Num, @Name, @Address, @NIC_Num, @Con_Num, @Pro_Info, @Tot_Wgt, @Tot_Prd, @Amt)";

               // using (SqlCommand command = new SqlCommand(sql, connection))
               // {
                    command.Parameters.AddWithValue("@Bill_Num", txt_Bill.Text);
                    command.Parameters.AddWithValue("@Name", txt_Name.Text);
                    command.Parameters.AddWithValue("@Address", txt_Add.Text);
                    command.Parameters.AddWithValue("@NIC_Num", txt_Nic.Text);
                    command.Parameters.AddWithValue("@Con_Num", txt_Con.Text);
                    command.Parameters.AddWithValue("@Pro_Info", txt_Pro.Text);
                    command.Parameters.AddWithValue("@Tot_Wgt", txt_Weg.Text);
                    command.Parameters.AddWithValue("@Tot_Prd", txt_Per.Text);
                    command.Parameters.AddWithValue("@Amt", txt_Amo.Text);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            // Display the entered values in another form
            Form4 form4 = new Form4();
            form4.Bill_Num = txt_Bill.Text;
            form4.Name = txt_Name.Text;
            form4.Address = txt_Add.Text;
            form4.NIC_Num = txt_Nic.Text;
            form4.Con_Num = txt_Con.Text;
            form4.Pro_Info = txt_Pro.Text;
            form4.Tot_Wgt = txt_Weg.Text;
            form4.Tot_Prd = txt_Per.Text;
            form4.Amt = txt_Amo.Text;


            form4.Show();


            // }

            // Show a message to the user
            MessageBox.Show("Form data saved successfully!");

                //this.Hide();
                //Form4 form4 = new Form4();
                //form4.Show();
            

        }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }
    }
}


