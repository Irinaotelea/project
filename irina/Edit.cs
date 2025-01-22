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

namespace ApplicationForms
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=Arrow;Initial Catalog=StudentDatabase;Integrated Security=True;"; // Sql connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (!string.IsNullOrWhiteSpace(txtRegisterNumber.Text))
                {
                    string query = "SELECT FullName, EmailAddress, ResidentialAddress, PhoneNumber FROM Students WHERE RegistrationNumber = @RegisterNumber";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@RegisterNumber", txtRegisterNumber.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvStudentDetails.DataSource = new BindingSource(dataTable, null);
                }
                else
                {
                    MessageBox.Show("Please enter a registration number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=Arrow;Initial Catalog=StudentDatabase;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                if (!string.IsNullOrWhiteSpace(txtUpdateRegisterNumber.Text))
                {
                    try
                    {
                        if (string.IsNullOrWhiteSpace(txtUpdateName.Text))
                        {
                            MessageBox.Show("Please enter the full name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (string.IsNullOrWhiteSpace(txtUpdateEmail.Text))
                        {
                            MessageBox.Show("Please enter the email address.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (string.IsNullOrWhiteSpace(txtUpdatePhone.Text))
                        {
                            MessageBox.Show("Please enter the phone number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (string.IsNullOrWhiteSpace(txtUpdateAddress.Text))
                        {
                            MessageBox.Show("Please enter the residential address.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            string updateQuery = "UPDATE Students SET FullName = @FullName, EmailAddress = @Email, PhoneNumber = @Phone, ResidentialAddress = @Address WHERE RegistrationNumber = @RegisterNumber";

                            SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                            updateCommand.Parameters.AddWithValue("@FullName", txtUpdateName.Text);
                            updateCommand.Parameters.AddWithValue("@Email", txtUpdateEmail.Text);
                            updateCommand.Parameters.AddWithValue("@Phone", txtUpdatePhone.Text);
                            updateCommand.Parameters.AddWithValue("@Address", txtUpdateAddress.Text);
                            updateCommand.Parameters.AddWithValue("@RegisterNumber", txtUpdateRegisterNumber.Text);

                            int rowsAffected = updateCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("No records were updated. Please check the registration number.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show($"An error occurred: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a registration number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            // Initialization code, if necessary
        }
    }
}
