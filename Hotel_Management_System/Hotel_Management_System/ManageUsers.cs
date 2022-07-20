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
       
        public string Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string status { get; set; }
        public string position { get; set; }
        private const string SelectQuery = "select id as ID , username, password, status,position from Users";
        private const string UpdateQuery = "update Users set username = @username, position =@position, status ='true' , where id = @ID";
        public static string DataBasePath = Properties.Settings.Default.My_DataBaseConnectionString;

        public ManageUsers()
        {
            InitializeComponent();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'users_dataset.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.users_dataset.Users);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            
        }

        

        public void updateuser(ManageUsers user)
        {

            using (SqlConnection connection = new SqlConnection(DataBasePath))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(UpdateQuery, connection))
                {

                    command.Parameters.AddWithValue("@id", user.Id);
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
            ManageUsers user = new ManageUsers();
            user.Id = label6.Text;
            user.username = textBox1.Text;
            user.status = comboBox2.GetItemText(comboBox2.SelectedItem);
            user.position = comboBox1.GetItemText(comboBox1.SelectedIndex);
            user.updateuser(user);
            dataGridView1.DataSource = GetUsers();
            MessageBox.Show(@"user has been added successfully");
            
            
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var index = e.RowIndex;
            label6.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
