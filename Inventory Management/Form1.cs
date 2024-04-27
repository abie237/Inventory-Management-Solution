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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            // TODO: This line of code loads data into the 'stock_ManagementDataSet.Stock_Transactions' table. You can move, or remove it, as needed.
            this.stock_TransactionsTableAdapter.Fill(this.stock_ManagementDataSet.Stock_Transactions);
            // TODO: This line of code loads data into the 'stock_ManagementDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.stock_ManagementDataSet.Product);
            // TODO: This line of code loads data into the 'stock_ManagementDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.stock_ManagementDataSet.Category);
            // TODO: This line of code loads data into the 'stock_ManagementDataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.stock_ManagementDataSet.Supplier);
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

            //searching in the supplier table
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

        private void button1_Click(object sender, EventArgs e)
        {

            //supplier search
            using (SqlConnection con = new SqlConnection("Data Source=ABIEL;Initial Catalog=Stock_Management;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Supplier where supplier_id=@supplier_id or adress like @adress", con);
                cmd.Parameters.AddWithValue("@supplier_id", supplier_idTextBox.Text);
                cmd.Parameters.AddWithValue("@adress", adressTextBox.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void product_idLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnshowuser_Click_1(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ABIEL;Initial Catalog=Stock_Management;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Users ", con);
            cmd.Parameters.AddWithValue("@user_id", user_idTextBox.Text);
            cmd.Parameters.AddWithValue("@user_name", user_nameTextBox.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //displaying in the supplier Table
            SqlConnection con = new SqlConnection("Data Source=ABIEL;Initial Catalog=Stock_Management;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from supplier ", con);
            cmd.Parameters.AddWithValue("@user_id", user_idTextBox.Text);
            cmd.Parameters.AddWithValue("@user_name", user_nameTextBox.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //searching in the categories table
            using (SqlConnection con = new SqlConnection("Data Source=ABIEL;Initial Catalog=Stock_Management;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Category where Category_id=@Category_id OR Category_name=@Category_name", con);
                cmd.Parameters.AddWithValue("@category_id", category_idTextBox.Text);
                cmd.Parameters.AddWithValue("@category_name", ( category_nameTextBox.Text));


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView3.DataSource = dt;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //displaying in the categories table
            using (SqlConnection con = new SqlConnection("Data Source=ABIEL;Initial Catalog=Stock_Management;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Category", con);
                cmd.Parameters.AddWithValue("@category_id", category_idTextBox.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView3.DataSource = dt;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //searching in the products table
            using (SqlConnection con = new SqlConnection("Data Source=ABIEL;Initial Catalog=Stock_Management;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from product where Product_id = @product_id or product_name=@product_name OR serialnumber=@serialnumber", con);
                cmd.Parameters.AddWithValue("@product_id", product_idTextBox.Text);
                cmd.Parameters.AddWithValue("@product_name",  product_nameTextBox.Text);
                cmd.Parameters.AddWithValue("@serialnumber",serialnumberTextBox.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                productDataGridView.DataSource = dt;
            }
        }
       private void serialnumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //displaying in the products table
            using (SqlConnection con = new SqlConnection("Data Source=ABIEL;Initial Catalog=Stock_Management;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from product", con);
                cmd.Parameters.AddWithValue("@product_id", product_idTextBox.Text);
                cmd.Parameters.AddWithValue("@product_name", product_nameTextBox.Text);
                cmd.Parameters.AddWithValue("@serialnumber", serialnumberTextBox.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                productDataGridView.DataSource = dt;
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contactTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Adding supplier (action done by Admin)
            // Adding supplier (action done by Admin)
            SqlConnection con = new SqlConnection("Data Source=ABIEL;Initial Catalog=Stock_Management;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmt = new SqlCommand(" INSERT INTO supplier VALUES (@supplier_id, @supplier_name, @contact, @address)", con);
            cmt.Parameters.AddWithValue("@supplier_id", TextBox3.Text);
            cmt.Parameters.AddWithValue("@supplier_name", textBox2.Text);
            cmt.Parameters.AddWithValue("@contact", int.Parse(contactTextBox.Text));
            cmt.Parameters.AddWithValue("@address", asuppliertxtbox.Text);
            cmt.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Supplier Added Successfully");


        }

        private void button10_Click(object sender, EventArgs e)
        {
            //deleteting a supplier //action done by admin

            if (MessageBox.Show("Do you want to delete this Supplier?", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Delete code here
                SqlConnection con = new SqlConnection("Data Source=ABIEL;Initial Catalog=Stock_Management;Integrated Security=True;TrustServerCertificate=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from supplier where supplier_id=@supplier_id", con);
                cmd.Parameters.AddWithValue("@supplier_id", supplier_idTextBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Supplier Deleted Successfully");
            }
            else
            {
                // Abort deletion
                MessageBox.Show("Delete Aborted");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //updating supplier information . //Done by admin only
            if (MessageBox.Show("Do you want to Update This Supplier Information", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection("Data Source=ABIEL;Initial Catalog=Stock_Management;Integrated Security=True;TrustServerCertificate=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("update Supplier set supplier_name=@supplier_name, contact=@contact, adress=@adress where supplier_id=@supplier_id ", con);
                cmd.Parameters.AddWithValue("@supplier_id", supplier_idTextBox.Text);
                cmd.Parameters.AddWithValue("@supplier_name", supplier_nameTextBox.Text);
                cmd.Parameters.AddWithValue("@contact", contactTextBox.Text);
                cmd.Parameters.AddWithValue("@adress", adressTextBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Update Succesful");
            }
            else
            {
                // Abort deletion
                MessageBox.Show("Update Aborted");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Display all information on supplier Table
            SqlConnection con = new SqlConnection("Data Source=ABIEL;Initial Catalog=Stock_Management;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from supplier ", con);
            cmd.Parameters.AddWithValue("@user_id", user_idTextBox.Text);
            cmd.Parameters.AddWithValue("@user_name", user_nameTextBox.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView4.DataSource = dt;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //searching the suppliers table
            using (SqlConnection con = new SqlConnection("Data Source=ABIEL;Initial Catalog=Stock_Management;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Supplier where supplier_id=@supplier_id or adress like @adress", con);
                cmd.Parameters.AddWithValue("@supplier_id", supplier_idTextBox.Text);
                cmd.Parameters.AddWithValue("@adress", adressTextBox.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView4.DataSource = dt;
            }
        }

        private void dataGridView4_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //searching category by admin
            //searching in the categories table
            using (SqlConnection con = new SqlConnection("Data Source=ABIEL;Initial Catalog=Stock_Management;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Category where Category_id=@Category_id OR Category_name=@Category_name", con);
                cmd.Parameters.AddWithValue("@category_id", textBox5.Text);
                cmd.Parameters.AddWithValue("@category_name", (textBox4.Text));


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView5.DataSource = dt;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //displaying all categories by admin
            using (SqlConnection con = new SqlConnection("Data Source=ABIEL;Initial Catalog=Stock_Management;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Category", con);
                cmd.Parameters.AddWithValue("@category_id", category_idTextBox.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView5.DataSource = dt;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //Adding Category by admin
            SqlConnection con = new SqlConnection("Data Source=ABIEL;Initial Catalog=Stock_Management;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into category values(@category_id,@category_name)", con);
            cmd.Parameters.AddWithValue("@category_id", textBox5.Text);
            cmd.Parameters.AddWithValue("@category_name", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Category Added  Succesfully ! ");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //deleting from a category by admin
            if (MessageBox.Show("Do you want to Delete this Category ?", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Delete code here
                SqlConnection con = new SqlConnection("Data Source=ABIEL;Initial Catalog=Stock_Management;Integrated Security=True;TrustServerCertificate=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from category where category_id=@category_id", con);
                cmd.Parameters.AddWithValue("@Category_id", textBox5.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Category Deleted Successful");
            }
            else
            {
                // Abort deletion
                MessageBox.Show("Delete Aborted");
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            //Updating Category information
            if (MessageBox.Show("Do you want to Update This Supplier Information", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection("Data Source=ABIEL;Initial Catalog=Stock_Management;Integrated Security=True;TrustServerCertificate=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("update category set category_name=@category_name", con);
                cmd.Parameters.AddWithValue("@category_id", textBox5.Text);
                cmd.Parameters.AddWithValue("@category_name", textBox5.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Category Updated Succesfully");
            }
            else
            {
                // Abort deletion
                MessageBox.Show("Update Aborted");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void transaction_idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            //Adding transaction by admin in panel
            using (SqlConnection con = new SqlConnection("Data Source=ABIEL;Initial Catalog=Stock_Management;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into   [stock transactions] values(@transaction_id , @transaction_type ,@product_id, @category_id ,@supplier_id", con);
                cmd.Parameters.AddWithValue("@transaction_id", transaction_idTextBox.Text);
                cmd.Parameters.AddWithValue("@transaction_type", transaction_typeTextBox.Text);
                cmd.Parameters.AddWithValue("@supplier_id", supplier_idTextBox2.Text);
                cmd.Parameters.AddWithValue("@category_id", category_idTextBox1.Text);
                cmd.Parameters.AddWithValue("@product_id", product_idTextBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Transaction Added Succesfully", "Information", MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //showing all transations by admin
            using (SqlConnection con = new SqlConnection("Data Source=ABIEL;Initial Catalog=Stock_Management;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from [Stock transactions]", con);
                cmd.Parameters.AddWithValue("@category_id", category_idTextBox.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                stock_TransactionsDataGridView.DataSource = dt;
            }
        }

        private void TextBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            //showing all from transactions
            using (SqlConnection con = new SqlConnection("Data Source=ABIEL;Initial Catalog=Stock_Management;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [stock transactions] WHERE transaction_id = @transaction_id OR transaction_type LIKE @transaction_type OR product_id = @product_id OR category_id = @category_id OR supplier_id = @supplier_id", con);
                cmd.Parameters.AddWithValue("@transaction_id", transaction_idTextBox.Text);
                cmd.Parameters.AddWithValue("@transaction_type", transaction_typeTextBox.Text);
                cmd.Parameters.AddWithValue("@supplier_id", supplier_idTextBox2.Text);
                cmd.Parameters.AddWithValue("@category_id", category_idTextBox1.Text);
                cmd.Parameters.AddWithValue("@product_id", product_idTextBox1.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                stock_TransactionsDataGridView.DataSource = dt;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //Deleting transaction by admin
            if (MessageBox.Show("Do you want to delete?", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Delete code here
                SqlConnection con = new SqlConnection("Data Source=ABIEL;Initial Catalog=Stock_Management;Integrated Security=True;TrustServerCertificate=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from [strock transaction] where transaction_id=@transaction_id", con);
                cmd.Parameters.AddWithValue("@transaction_id", transaction_idTextBox.Text);
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
    }
}
