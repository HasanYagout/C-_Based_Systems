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


namespace Hotel_Management_System
{
    public partial class Login : Form
    {
        private const string InsertQuery = "insert into Users (username,password,status,position) values(@User, @Pass, @Stat,@pos)";
        private const string SelectQuery = "select username,password,status,position from Users";
        public static string DataBasePath = Properties.Settings.Default.My_DataBaseConnectionString;
        public string user { get; set; }
        public string pass { get; set; }
        public string sta { get; set; }
        public string pos { get; set; }

       public Login()
        {
            InitializeComponent();
        }

        private void Login_button_click(object sender, EventArgs e)
        {
            ValidateUser();
            this.Visible = false;
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }







        public  DataTable GetUsers()
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








        //public void addUser()
        //{
        //    Login form1 = new Login();
        //    bool success = form1.InsertAdminUser(form1);

        //}







        //public bool InsertAdminUser(Login user)
        //{
        //    int rows;
        //    using (SqlConnection connection = new SqlConnection(DataBasePath))
        //    {
        //        connection.Open();
        //        using (SqlCommand command = new SqlCommand(InsertQuery, connection))
        //        {
        //            Login form1 = new Login();
        //            command.Parameters.AddWithValue("@User", "hasan");
        //            command.Parameters.AddWithValue("@Pass", "123");
        //            command.Parameters.AddWithValue("@Stat", "true");
        //            command.Parameters.AddWithValue("@pos", "admin");
        //            rows = command.ExecuteNonQuery();
        //            MessageBox.Show("success");
        //        }

        //    }
        //    return (rows > 0) ? true : false;


        //}

        public void ValidateUser()
        {
            using (SqlConnection connection = new SqlConnection(DataBasePath))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(SelectQuery, connection))
                {
                    
                    //command.Parameters.AddWithValue();
                        SqlDataReader reader1;
                    reader1=command.ExecuteReader();
                    if (reader1.Read())
                    {
                        
                        string user1= reader1["username"].ToString();
                        string user2 = reader1["password"].ToString();
                        string user3 = reader1["status"].ToString();
                        string user4 = reader1["position"].ToString();

                        if (textBox1.Text.Equals(user1) && textBox2.Text.Equals(user2) && user3.Equals("true")&&user4.Equals("admin"))
                        {
                            MainWindow mainwindow = new MainWindow();
                            mainwindow.Show();

                        }
                        else
                            MessageBox.Show("username or password is uncorrect try again!");
                    }
                    
                
                }
            }
                
        }
       

        
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'my_DataBaseDataSet1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.my_DataBaseDataSet1.Users);

        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            
        }

       

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
       

        

    }
}
