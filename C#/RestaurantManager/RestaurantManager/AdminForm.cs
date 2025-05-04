using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RestaurantManager
{
    public partial class AdminForm : Form
    {      
        public AdminForm()
        {
            InitializeComponent();
        }

        //  ------  Employee Management Options  ------
        private void empMgmtAddBtn_Click(object sender, EventArgs e)
        {
            //goes to method
            GroupVisability();
            //makes the group box visible
            addEmpGroup.Visible = true; 
        }
        private void empMgmtRmvBtn_Click(object sender, EventArgs e)
        {
            //goes to method
            GroupVisability();
            //makes the group box visible
            removeEmpGroup.Visible = true;
        }

        //  ------  Menu Management Options  ------
        private void mmAddButton_Click(object sender, EventArgs e)
        {
            //goes to method
            GroupVisability();
            //makes the group box visible
            addMenuGroup.Visible = true;
        }
        private void mmRemoveButton_Click(object sender, EventArgs e)
        {
            //goes to method
            GroupVisability();
            //makes the group box visible
            removeMenuGroup.Visible = true;
        }
        private void mmModifyButton_Click(object sender, EventArgs e)
        {
            //goes to method
            GroupVisability();
            //makes the group box visible
            modMenuGroup.Visible = true;
        }


        //  ------  User Input For Employee Management  ------

        private void addEmpBtn_Click(object sender, EventArgs e)
        {
            //asigns the textbox values to variables
            string password = tb_password.Text;
            string roleID = tb_roleID.Text;
            string fName = tb_fName.Text;
            string lName = tb_lName.Text;
            string address = tb_address.Text;
            string city = tb_city.Text;
            string state = tb_state.Text;
            string zip = tb_zip.Text;
            string phone = tb_phone.Text;

            //creates a connection
            SqlConnection conn = new SqlConnection(Connect.connectionString);

            //creates a command that uses the addemployye stored procedure
            SqlCommand cmd = new SqlCommand("AddEmployee", conn);
            //tells the program that it is a stored procedure being used
            cmd.CommandType = CommandType.StoredProcedure;

            //sets the parameters as the user input from the text boxes
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@roleID", roleID);
            cmd.Parameters.AddWithValue("@firstName", fName);
            cmd.Parameters.AddWithValue("@lastName", lName);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@city", city);
            cmd.Parameters.AddWithValue("@state", state);
            cmd.Parameters.AddWithValue("@zip", zip);
            cmd.Parameters.AddWithValue("@phonenumber", phone);

            //opens the connection, executes the stored procedure
            conn.Open();
            cmd.ExecuteNonQuery();

            //makes the confirmation message visible
            lb_empAdded.Visible = true;
            //closes connection
            conn.Close();
        }
        private void rmvEmpBtn_Click(object sender, EventArgs e)
        {
            //creates a connection
            SqlConnection conn = new SqlConnection(Connect.connectionString);

            //assigns the remove userid input to a variable
            string rmvUserID = tb_rmvUserID.Text;

            //creates a command that uses the addemployye stored procedure
            SqlCommand cmd = new SqlCommand("RemoveEmployee", conn);
            //tells the program that it is a stored procedure being used
            cmd.CommandType = CommandType.StoredProcedure;

            //sets the parameter as the user input from the text boxe
            cmd.Parameters.AddWithValue("@userid", rmvUserID);

            //opens the connection, executes the stored procedure
            conn.Open();
            cmd.ExecuteNonQuery();
         
            //makes confirmation message visible
            lb_empRemoved.Visible = true;
            //closes connection
            conn.Close();
        }

        //  ------  User Input For Menu Management  ------
        private void addItemBtn_Click(object sender, EventArgs e)
        {
            //asigns the textbox values to variables
            string itemName = tb_itemName.Text;
            string category = tb_category.Text;
            string desc = tb_desc.Text;
            string price = tb_price.Text;

            //creates a connection
            SqlConnection conn = new SqlConnection(Connect.connectionString);

            //creates a command that uses the addemployye stored procedure
            SqlCommand cmd = new SqlCommand("AddMenuItem", conn);
            //tells the program that it is a stored procedure being used
            cmd.CommandType = CommandType.StoredProcedure;

            //sets the parameters as the user input from the text boxes
            cmd.Parameters.AddWithValue("@itemName", itemName);
            cmd.Parameters.AddWithValue("@category", category);
            cmd.Parameters.AddWithValue("@description", desc);
            cmd.Parameters.AddWithValue("@price", price);

            //opens the connection, executes the stored procedure
            conn.Open();
            cmd.ExecuteNonQuery();

            //makes confirmation message visible; closes connection
            lb_itemAdded.Visible = true;
            conn.Close();
        }
        private void rmvItemBtn_Click(object sender, EventArgs e)
        {
            //creates a connection
            SqlConnection conn = new SqlConnection(Connect.connectionString);

            //assigns the remove userid input to a variable
            string rmvItemID = tb_rmvItemID.Text;

            //creates a command that uses the addemployye stored procedure
            SqlCommand cmd = new SqlCommand("RemoveMenuItem", conn);
            //tells the program that it is a stored procedure being used
            cmd.CommandType = CommandType.StoredProcedure;

            //sets the parameter as the user input from the text boxe
            cmd.Parameters.AddWithValue("@itemID", rmvItemID);

            //opens the connection, executes the stored procedure
            conn.Open();
            cmd.ExecuteNonQuery();

            //confirm removing; closes connection
            lb_itemRemoved.Visible = true;
            conn.Close();
        }
        private void modItemBtn_Click(object sender, EventArgs e)
        {
            //asigns the textbox values to variables
            string modItemID = tb_modItemID.Text;
            string modItemName = tb_modItemName.Text;
            string modCategory = tb_modCat.Text;
            string modDesc = tb_modDesc.Text;
            string modPrice = tb_modPrice.Text;

            //creates a connection
            SqlConnection conn = new SqlConnection(Connect.connectionString);

            //creates a command that uses the addemployye stored procedure
            SqlCommand cmd = new SqlCommand("ModifyMenuItem", conn);
            //tells the program that it is a stored procedure being used
            cmd.CommandType = CommandType.StoredProcedure;

            //sets the parameters as the user input from the text boxes
            cmd.Parameters.AddWithValue("@itemID", modItemID);
            cmd.Parameters.AddWithValue("@itemName", modItemName);
            cmd.Parameters.AddWithValue("@category", modCategory);
            cmd.Parameters.AddWithValue("@description", modDesc);
            cmd.Parameters.AddWithValue("@price", modPrice);

            //opens the connection, executes the stored procedure
            conn.Open();
            cmd.ExecuteNonQuery();

            //confirm modify; closes conn
            lb_itemMod.Visible = true;
            conn.Close();
        }


        //method to make all the group boxes invisible
        public void GroupVisability()
        {
            //array of the groupboxes
            GroupBox[] groupNames = { addEmpGroup, removeEmpGroup, addMenuGroup, removeMenuGroup, modMenuGroup };

            //loops through the grou box array
            for (int i = 0; i < groupNames.Length; i++)
            {
                //sets each box to invisible 
                groupNames[i].Visible = false;
            }
        }
    }
}
