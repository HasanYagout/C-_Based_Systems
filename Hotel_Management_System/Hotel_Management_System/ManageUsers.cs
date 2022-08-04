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
    public partial class ManageUsers : Form
    {
       
        public string ID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string status { get; set; }
        public string position { get; set; }
        private const string InsertQuery = "insert into Users (username,password,status,position) values(@Username, @Password, @Status,@position)";
        private const string SelectQuery = "select id as ID , username, password, status,position from Users";
        private const string UpdateQuery = "update Users set username = @username, position =@position,status=@status  where id = @ID";
        public static string DataBasePath = Properties.Settings.Default.My_DataBaseConnectionString;

        public ManageUsers()
        {
            InitializeComponent();
            buttons();
           
           
            
        }
        public void buttons()
        {


            if (string.IsNullOrEmpty(UserName_TextBox.Text) || string.IsNullOrEmpty(Password_TextBox.Text) || string.IsNullOrEmpty(ConfirmPassword_TextBox.Text) || Access_ComboBox.SelectedItem == null || Position_ComboBox.SelectedItem == null)
            {
                    Add_Button.Enabled = false;
                  Update_Button.Enabled = false;
                    Clear_Button.Enabled = true;

            }



            if (!string.IsNullOrEmpty(UserName_TextBox.Text) && !string.IsNullOrEmpty(Password_TextBox.Text) && !string.IsNullOrEmpty(ConfirmPassword_TextBox.Text) && Access_ComboBox.SelectedItem != null && Position_ComboBox.SelectedItem != null)
            {

                Add_Button.Enabled = true;
                Update_Button.Enabled = true;
                Clear_Button.Enabled = true;
            }

            if (Password_TextBox.Enabled == false && ConfirmPassword_TextBox.Enabled == false)
            {
                Update_Button.Enabled = true;
            }

            else if (string.IsNullOrEmpty(UserName_TextBox.Text) && string.IsNullOrEmpty(Password_TextBox.Text) && Access_ComboBox.SelectedItem == null && Position_ComboBox.SelectedItem == null && string.IsNullOrEmpty(ConfirmPassword_TextBox.Text))
            {

                Clear_Button.Enabled = false;
            }
           
        
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'users_dataset.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.users_dataset.Users);

        }


       



        public bool InsertUser(ManageUsers user)
        {
            int rows;
            using (SqlConnection connection = new SqlConnection(DataBasePath))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(InsertQuery, connection))
                {
                    Login form1 = new Login();
                    command.Parameters.AddWithValue("@Username", user.username);
                    command.Parameters.AddWithValue("@Password", user.password);
                    command.Parameters.AddWithValue("@Status", user.status);
                    command.Parameters.AddWithValue("@position", user.position);
                    rows = command.ExecuteNonQuery();
                    
                }

            }
            return (rows > 0) ? true : false;


        }


        public void clear()
        {
            DBID_Label.Text = "";
            UserName_TextBox.Text = "";
            Password_TextBox.Text = "";
            Position_ComboBox.Text = "";
            Access_ComboBox.Text = "";
            ConfirmPassword_TextBox.Text = "";
        
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (UserName_TextBox.Text.Length > 3 && UserName_TextBox.Text.Length < 10 && Password_TextBox.Text.Length > 7 && Password_TextBox.Text.Length < 13 && Password_TextBox.Text.Equals(ConfirmPassword_TextBox.Text))
                {

                    buttons();
                    ManageUsers manageusers = new ManageUsers();
                    manageusers.username = UserName_TextBox.Text;
                    manageusers.password = Password_TextBox.Text;
                    manageusers.status = Access_ComboBox.GetItemText(Access_ComboBox.SelectedItem);
                    manageusers.position = Position_ComboBox.GetItemText(Position_ComboBox.SelectedItem);
                    InsertUser(manageusers);
                    MessageBox.Show("added");
                    DataGridView.DataSource = GetUsers();
                    
                }
                if (UserName_TextBox.Text.Length < 3 || UserName_TextBox.Text.Length > 9)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
           
            

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
            buttons();
            Clear_Button.Enabled = false;
            Password_TextBox.Enabled = true;
            Update_Button.Enabled = false;
            ConfirmPassword_TextBox.Enabled = true;
        }

        

        public void updateuser(ManageUsers user)
        {

            using (SqlConnection connection = new SqlConnection(DataBasePath))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(UpdateQuery, connection))
                {

                    command.Parameters.AddWithValue("@id", user.ID);
                    command.Parameters.AddWithValue("@username", user.username);
                    command.Parameters.AddWithValue("@status", user.status);
                    command.Parameters.AddWithValue("@position", user.position);
                    command.ExecuteNonQuery();



                }

            }
        
        }



        public static DataTable GetUsers()
        {
            DataTable datatable = new DataTable();
            using (SqlConnection connection = new SqlConnection(DataBasePath))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(SelectQuery, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(datatable);
                    }
                }
            }
            return datatable;
        }




        private void button2_Click(object sender, EventArgs e)
        {
          
            
            
            
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            Password_TextBox.Enabled = false;
            ConfirmPassword_TextBox.Enabled = false;
            buttons();
            var index = e.RowIndex;
            DBID_Label.Text = DataGridView.Rows[index].Cells[0].Value.ToString();
            UserName_TextBox.Text = DataGridView.Rows[index].Cells[1].Value.ToString();
            Password_TextBox.Text = "";
            Access_ComboBox.Text = DataGridView.Rows[index].Cells[2].Value.ToString();
            Position_ComboBox.Text = DataGridView.Rows[index].Cells[3].Value.ToString();
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

        private void UserName_TextBox_TextChanged(object sender, EventArgs e)
        {
            buttons();
           

        }

        private void Password_TextBox_TextChanged(object sender, EventArgs e)
        {
            buttons();
        }

        private void Access_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttons();
        }

        private void Position_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttons();
        }

        private void UserName_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar)  || e.KeyChar == (char)Keys.Back);
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            DataGridView.DataSource = GetUsers();
            
            ManageUsers user = new ManageUsers();
            user.ID = DBID_Label.Text;
            user.username = UserName_TextBox.Text;
            user.status = Access_ComboBox.GetItemText(Access_ComboBox.SelectedItem);
            user.position = Position_ComboBox.GetItemText(Position_ComboBox.SelectedItem);
            user.updateuser(user);
            MessageBox.Show(@"user has been added successfully");
            DataGridView.DataSource = GetUsers();
            clear();
            buttons();
        }

       
    }
}
