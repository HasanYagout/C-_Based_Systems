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
            buttons();
            Clear_Button.Enabled = false;
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
            try {
            
                if((Name_TextBox.Text.Length > 3 && Name_TextBox.Text.Length < 10 && Password_TextBox.Text.Length > 7 && Password_TextBox.Text.Length < 13 && Password_TextBox.Text.Equals(ConfirmPassword_TextBox.Text)))
                {
                
                  Register user1 = new Register();
            user1.user = Name_TextBox.Text;
            user1.pass = Password_TextBox.Text;
            user1.sta = "false";
            user1.pos = "user";
            bool success = InsertUser(user1);
            if (success)
            {


                MessageBox.Show(@"user has been added successfully");
            }
            else
                MessageBox.Show(@"error occured. please try again...");
                }
                if (Name_TextBox.Text.Length < 3 || Name_TextBox.Text.Length > 9)
                {

                    MessageBox.Show("name should be at least 3 charachters");
                }
                if (Password_TextBox.Text.Length < 8 || Password_TextBox.Text.Length > 12)
                {
                    MessageBox.Show("password should be from 8 to 12  charachters");

                }
                if (!Password_TextBox.Text.Equals(ConfirmPassword_TextBox.Text))
                {
                    MessageBox.Show("password and confirm password should be the same");
                }
            
            }
            catch (Exception ex){

                MessageBox.Show(ex.Message);
            }

          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'my_DataBaseDataSet5.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.my_DataBaseDataSet5.Users);

        }

        private void Register_Load_1(object sender, EventArgs e)
        {

        }
        public void clear()
        {

            Name_TextBox.Text = "";
            Password_TextBox.Text = "";
            ConfirmPassword_TextBox.Text="";

        
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Clear_Button.Enabled = false;
            clear();
        }


        public void buttons()
        {
            if (string.IsNullOrEmpty(Name_TextBox.Text) || string.IsNullOrEmpty(Password_TextBox.Text) || string.IsNullOrEmpty(ConfirmPassword_TextBox.Text))
            {
                SignUp_Button.Enabled = false;
                Clear_Button.Enabled = true;
            }

            if (string.IsNullOrEmpty(Name_TextBox.Text) && string.IsNullOrEmpty(Password_TextBox.Text) && string.IsNullOrEmpty(ConfirmPassword_TextBox.Text))
            {
                SignUp_Button.Enabled = false;
                Clear_Button.Enabled = false;
            
            }
            if (!string.IsNullOrEmpty(Name_TextBox.Text) && !string.IsNullOrEmpty(Password_TextBox.Text) && !string.IsNullOrEmpty(ConfirmPassword_TextBox.Text)&&Password_TextBox.Text.Equals(ConfirmPassword_TextBox.Text))
            {
                SignUp_Button.Enabled = true;
            }
            
        
        }
        private void Name_TextBox_TextChanged(object sender, EventArgs e)
        {
            buttons();
        }

        private void Password_TextBox_TextChanged(object sender, EventArgs e)
        {
            buttons();
        }

        private void ConfirmPassword_TextBox_TextChanged(object sender, EventArgs e)
        {
            buttons();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }


}











