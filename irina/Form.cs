using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UserInterfaces
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            // Optional: Handle title label click
        }

        private void picCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStudentSearch_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=Arrow;Initial Catalog=StudentInfo;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM [Student] WHERE RegisterNum = @RegisterNum";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RegisterNum", txtStudentRegisterNumber.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        this.Visible = false;
                        StudentHome studentHomeForm = new StudentHome();
                        studentHomeForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Register Number.");
                    }
                }
            }
        }

        private void btnClearStudentSearch_Click(object sender, EventArgs e)
        {
            txtStudentRegisterNumber.Clear();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Optional: Handle form load logic
        }

        private void lblSubtitle_Click(object sender, EventArgs e)
        {
            // Optional: Handle subtitle label click
        }

        private void picAppLogo_Click(object sender, EventArgs e)
        {
            // Optional: Handle logo click
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=Arrow;Initial Catalog=StudentInfo;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM [logging] WHERE username = @Username AND password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", txtAdminUsername.Text);
                    command.Parameters.AddWithValue("@Password", txtAdminPassword.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        this.Visible = false;
                        AdminHome adminHomeForm = new AdminHome();
                        adminHomeForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password.");
                    }
                }
            }
        }

        private void btnClearAdminLogin_Click(object sender, EventArgs e)
        {
            txtAdminUsername.Clear();
            txtAdminPassword.Clear();
        }

        private void picCloseApp_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}