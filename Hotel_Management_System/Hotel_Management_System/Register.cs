using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Hotel_Management_System
{
    public partial class Register : Form
    {
        private const string InsertQuery = "insert into Users (username,password,status,position) values(@User, @Pass, @Stat,@pos)";
        private const string SelectQuery = "select username,password,status,position from Users";
        public static string DataBasePath = Properties.Settings.Default.My_DataBaseConnectionString;
        public string user { get; set; }
        public string pass { get; set; }
        public string sta { get; set; }
        public string pos { get; set; }

        public Register()
        {
            InitializeComponent();
            dataGridView1.DataSource = GetUsers();
        }

        public static DataTable GetUsers()
        {
            DataTable datatable = new DataTable();
            using (SqlConnection con = new SqlConnection(DataBasePath))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(SelectQuery, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                    {
                        adapter.Fill(datatable);
                    }
                }
            }
            return datatable;
        }

        public bool InsertUser(Register user)
        {
            int rows;
            using (SqlConnection connection = new SqlConnection(DataBasePath))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(InsertQuery, connection))
                {
                    Login form1 = new Login();
                    command.Parameters.AddWithValue("@User", user.user);
                    command.Parameters.AddWithValue("@Pass", user.pass);
                    command.Parameters.AddWithValue("@Stat", "false");
                    command.Parameters.AddWithValue("@pos", "user");
                    rows = command.ExecuteNonQuery();
                    MessageBox.Show("success");
                }

            }
            return (rows > 0) ? true : false;


        }

        private void Register_Sign_Up_Button_Click(object sender, EventArgs e)
        {
            Register user1 = new Register();
            user1.user = Register_Name_TextBox.Text;
            user1.pass = Register_Password_TextBox.Text;
            user1.sta = "false";
            user1.pos = "user";
            bool success = InsertUser(user1);
            dataGridView1.DataSource = GetUsers();
             if (success)
            {

                
                MessageBox.Show(@"user has been added successfully");
            }
            else
                MessageBox.Show(@"error occured. please try again...");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        }

       
        }

     




        

       
    

