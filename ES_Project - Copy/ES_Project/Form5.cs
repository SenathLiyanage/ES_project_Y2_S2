using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES_Project
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txt_Name1.Clear();
            txt_Add1.Clear();
            txt_Nic1.Clear();
            txt_Con1.Clear();
            txt_Amo1.Clear();
            txt_Amo_P.Clear();
            txt_Amo_D.Clear();
            txt_Per1.Clear();
            txt_Weg1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\ASUS\\Desktop\\ES_Project - Copy\\ES_Project\\detailsDB.mdf\";Integrated Security=True;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            command.CommandText = "INSERT INTO tbldetails (Bill_Num, Name, Address, NIC_Num, Con_Num, Pro_Info, Tot_Wgt, Tot_Prd, Amt) VALUES (@Bill_Num, @Name, @Address, @NIC_Num, @Con_Num, @Pro_Info, @Tot_Wgt, @Tot_Prd, @Amt)";

            command.Parameters.AddWithValue("@Bill_Num", txt_Bill1.Text);
            //command.Parameters.AddWithValue("@Bill_Num", txt_Name1.Text);
            command.Parameters.AddWithValue("@Name", txt_Name1.Text);
            command.Parameters.AddWithValue("@Address", txt_Add1.Text);
            command.Parameters.AddWithValue("@NIC_Num", txt_Nic1.Text);
            command.Parameters.AddWithValue("@Con_Num", txt_Con1.Text);
            command.Parameters.AddWithValue("@Pro_Info", txt_Pro1.Text);
            command.Parameters.AddWithValue("@Tot_Wgt", txt_Weg1.Text);
            command.Parameters.AddWithValue("@Tot_Prd", txt_Per1.Text);
            command.Parameters.AddWithValue("@Amt", txt_Amo1.Text);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            // Display the entered values in another form
            Form6 form6 = new Form6();
            form6.Bill_Num = txt_Bill1.Text;
            form6.Name = txt_Name1.Text;
            form6.Address = txt_Add1.Text;
            form6.NIC_Num = txt_Nic1.Text;
            form6.Con_Num = txt_Con1.Text;
            form6.Pro_Info = txt_Pro1.Text;
            form6.Tot_Wgt = txt_Weg1.Text;
            form6.Tot_Prd = txt_Per1.Text;
            form6.Amt = txt_Amo1.Text;
            form6.Amt1 = txt_Amo_D.Text;
            form6.Amt2 = txt_Amo_P.Text;


            form6.Show();

            MessageBox.Show("Form data saved successfully!");

            //this.Hide();
            // Form6 form6 = new Form6();
            // form6.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\ASUS\\Desktop\\ES_Project - Copy\\ES_Project\\detailsDB.mdf\";Integrated Security=True;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM tbldetails WHERE Bill_Num=@Bill_Num";
            command.Parameters.AddWithValue("@Bill_Num", txtSearch.Text);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                //txt_Bill1.Text = reader["Bill_Num"].ToString();
                txt_Name1.Text = reader["Name"].ToString();
                txt_Add1.Text = reader["Address"].ToString();
                txt_Nic1.Text = reader["NIC_Num"].ToString();
                txt_Con1.Text = reader["Con_Num"].ToString();
                txt_Pro1.Text = reader["Pro_Info"].ToString();
                txt_Weg1.Text = reader["Tot_Wgt"].ToString();
                txt_Per1.Text = reader["Tot_Prd"].ToString();
                txt_Amo1.Text = reader["Amt"].ToString();
            }
            else
            {
                MessageBox.Show("Bill number not found!");
            }
            reader.Close();
            connection.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
