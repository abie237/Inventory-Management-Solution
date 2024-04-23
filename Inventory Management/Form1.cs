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

namespace Inventory_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stock_ManagementDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.stock_ManagementDataSet.Users);

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;


            SqlConnection con = new SqlConnection("Data Source=ABIEL;Initial Catalog=Stock_Management;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            con.Open();
            string query = "SELECT COUNT(*) FROM [USERS] WHERE user_name=@user_name AND password=@password";
            string rolequery = "SELECT USER_TYPE FROM USERS WHERE user_name=@user_name";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand rolecmd = new SqlCommand(rolequery, con);
            cmd.Parameters.AddWithValue("@user_name", txtusername.Text);
            cmd.Parameters.AddWithValue("@password", txtpassword.Text);
            rolecmd.Parameters.AddWithValue("@user_name", txtusername.Text);
            int count = (int)cmd.ExecuteScalar();



            //validation of the user input
            if (count > 0)
            {
                string role = rolecmd.ExecuteScalar().ToString();
                if (role == "Admin")
                {
                    usertab.Visible = false;
                    admintab.Visible = true;
                    MessageBox.Show("Hello Admin", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    groupBox1.Visible = false;
                }
                else
                {
                    usertab.Visible = true;
                    admintab.Visible = false;
                    MessageBox.Show("Hello Member", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    groupBox1.Visible = false;
                }

            }
            else
            {
                //error box message in case of false parameters entered
                MessageBox.Show("Wrong Username or Password");
                txtusername.Clear();
                txtpassword.Clear();
                txtusername.Focus();
            }

            con.Close();

        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stock_ManagementDataSet);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void user_nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void user_idLabel_Click(object sender, EventArgs e)
        {

        }

        private void user_typeLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {

        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ABIEL;Initial Catalog=Stock_Management;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Users values(@user_id,@user_name,@password,@user_type)", con);
            cmd.Parameters.AddWithValue("@user_id", user_idTextBox.Text);
            cmd.Parameters.AddWithValue("@user_name", user_nameTextBox.Text);
            cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);
            cmd.Parameters.AddWithValue("@user_type", user_typeTextBox.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("User Registered");
        }

        private void btnupdateuser_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ABIEL;Initial Catalog=Stock_Management;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update Users set user_name=@user_name, password=@password, user_type=@user_type where user_id=@user_id ", con);
            cmd.Parameters.AddWithValue("@user_id", user_idTextBox.Text);
            cmd.Parameters.AddWithValue("@user_name", user_nameTextBox.Text);
            cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);
            cmd.Parameters.AddWithValue("@user_type", user_typeTextBox.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update Succesful");

        }

        private void btndeleteuser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Delete code here
                SqlConnection con = new SqlConnection("Data Source=ABIEL;Initial Catalog=Stock_Management;Integrated Security=True;TrustServerCertificate=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Users where user_id=@user_id", con);
                cmd.Parameters.AddWithValue("@user_id", user_idTextBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Delete Successful");
            }
            else
            {
                // Abort deletion
                MessageBox.Show("Delete Aborted");
            }
        }

        private void btnshowuser_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ABIEL;Initial Catalog=Stock_Management;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Users where user_id=@user_id OR user_name=@user_name", con);
            cmd.Parameters.AddWithValue("@user_id", user_idTextBox.Text);
            cmd.Parameters.AddWithValue("@user_name", user_nameTextBox.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
