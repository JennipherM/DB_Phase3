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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace RestaurantManager
{
    public partial class StaffForm : Form
    {
        public SqlConnection conn = new SqlConnection(Connect.connectionString);
        public StaffForm()
        {
            InitializeComponent();
        }

        //  ------  Order Management Options  ------
        private void st_omAddBtn_Click(object sender, EventArgs e)
        {
            //goes to method
            GroupVisability();
            //makes the group box visible
            stAddOrderGroup.Visible = true;
        }
        private void st_omRmvBtn_Click(object sender, EventArgs e)
        {
            //goes to method
            GroupVisability();
            //makes the group box visible
            stRmvOrderGroup.Visible = true;
        }
        private void st_omModBtn_Click(object sender, EventArgs e)
        {
            //goes to method
            GroupVisability();
            //makes the group box visible
            stModOrderGroup.Visible = true;
        }

        //  ------  Table Management Option  ------
        private void st_tmUpdStatBtn_Click(object sender, EventArgs e)
        {
            //goes to method
            GroupVisability();
            //makes the group box visible
            updStatusGroup.Visible = true;
        }

        //  ------  Bill Management Option  ------
        private void st_bmGenBtn_Click(object sender, EventArgs e)
        {
            //goes to method
            GroupVisability();
            //makes the group box visible
            genBillGroup.Visible = true;

        }


        //  ------  User Input For Order Management  ------
        private void stAddOrdBtn_Click(object sender, EventArgs e)
        {
            //asigns the textbox values to variables
            string orderTime = tb_stOrderTime.Text;
            string discount = tb_stDiscount.Text;
            string status = tb_stStatus.Text;
            string orderType = tb_stOrderType.Text;
            string userID = tb_stOrdUserID.Text;

            //creates a command that uses the addemployye stored procedure
            SqlCommand cmd = new SqlCommand("AddOrder", conn);
            //tells the program that it is a stored procedure being used
            cmd.CommandType = CommandType.StoredProcedure;


            //sets the parameters as the user input from the text boxes
            cmd.Parameters.AddWithValue("@orderTime", orderTime);
            cmd.Parameters.AddWithValue("@discount", discount);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@orderType", orderType);
            cmd.Parameters.AddWithValue("@userID", userID);

            //opens the connection, executes the stored procedure
            conn.Open();
            cmd.ExecuteNonQuery();

            //asigns the textbox values to variables
            string itemID = tb_stOrdItemID.Text;
            string tableID = tb_stOrdTableID.Text;

            //gets orderid of the most recent order
            string getOrderID = "select top 1 orderID from Orders order by OrderTime desc;";
            SqlCommand cmd2 = new SqlCommand(getOrderID, conn);

            int result = Convert.ToInt32(cmd2.ExecuteScalar());

            SqlCommand cmd3 = new SqlCommand("AddOrderDetails", conn);
            //tells the program that it is a stored procedure being used
            cmd3.CommandType = CommandType.StoredProcedure;

            //sets the parameters as the user input from the text boxes
            cmd3.Parameters.AddWithValue("@itemID", itemID);
            cmd3.Parameters.AddWithValue("@tableID", tableID);
            cmd3.Parameters.AddWithValue("@orderID", result);

            //executes the stored procedure; confirms action; closes conn
            cmd3.ExecuteNonQuery();
            lb_stOrderAdded.Visible = true;
            conn.Close();
        }
        private void stRmvOrderBtn_Click(object sender, EventArgs e)
        {
            //creates a command that uses the addemployye stored procedure
            SqlCommand cmd = new SqlCommand("removeOrderItem", conn);
            //tells the program that it is a stored procedure being used
            cmd.CommandType = CommandType.StoredProcedure;

            //asigns the textbox values to variables
            string orderID = tb_stRmvOrderID.Text;
            string itemID = tb_stRmvItemID.Text;

            //sets the parameters as the user input from the text boxes
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Parameters.AddWithValue("@itemID", itemID);

            //opens conn; executes the stored procedure
            conn.Open();
            cmd.ExecuteNonQuery();
            // confirms action; closes conn
            lb_stOrderRemoved.Visible = true;
            conn.Close();
        }
        private void stUpdOrderBtn_Click(object sender, EventArgs e)
        {
            //creates a command that uses the addemployye stored procedure
            SqlCommand cmd = new SqlCommand("UpdateOrder", conn);
            //tells the program that it is a stored procedure being used
            cmd.CommandType = CommandType.StoredProcedure;
            //asigns the textbox values to variables
            string orderID = tb_stUpdOrderID.Text;
            string status = tb_stUpdStatus.Text;
            string discount = tb_stUpdDiscount.Text;

            //sets the parameters as the user input from the text boxes
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Parameters.AddWithValue("@discount", discount);
            cmd.Parameters.AddWithValue("@status", status);


            //opens conn; executes the stored procedure
            conn.Open();
            cmd.ExecuteNonQuery();
            // confirms action; closes conn
            lb_stOrderUpd.Visible = true;
            conn.Close();
        }
        private void stAddItemBtn_Click(object sender, EventArgs e)
        {
            //creates a command that uses the addemployye stored procedure
            SqlCommand cmd = new SqlCommand("addOrderMenuItem", conn);
            //tells the program that it is a stored procedure being used
            cmd.CommandType = CommandType.StoredProcedure;

            //asigns the textbox values to variables
            string itemid = tb_stModAddItem.Text;
            string tableid = tb_stModTableID.Text;
            string orderid = tb_stModOrderID.Text;

            //sets the parameters as the user input from the text boxes
            cmd.Parameters.AddWithValue("@itemid", itemid);
            cmd.Parameters.AddWithValue("@tableid", tableid);
            cmd.Parameters.AddWithValue("@orderID", orderid);


            //opens conn; executes the stored procedure
            conn.Open();
            cmd.ExecuteNonQuery();
            // confirms action; closes conn
            lb_stItemAdded.Visible = true;
            conn.Close();
        }

        //  ------  User Input For Table Management  ------
        private void updTblStatBtn_Click(object sender, EventArgs e)
        {
            //creates a command that uses the addemployye stored procedure
            SqlCommand cmd = new SqlCommand("UpdateTblStatus", conn);
            //tells the program that it is a stored procedure being used
            cmd.CommandType = CommandType.StoredProcedure;

            //asigns the textbox values to variables
            string tableid = tb_updTblID.Text;
            string status = tb_updTblStatus.Text;

            //sets the parameters as the user input from the text boxes
            cmd.Parameters.AddWithValue("@tableid", tableid);
            cmd.Parameters.AddWithValue("@availability", status);


            //opens conn; executes the stored procedure
            conn.Open();
            cmd.ExecuteNonQuery();
            // confirms action; closes conn
            lb_updTblStatus.Visible = true;
            conn.Close();

        }


        //   ------  Generate Bill Info  ------
        private void genBillBtn_Click(object sender, EventArgs e)
        {
            //makes the data grid views visible
            dgv_ItemsOrdered.Visible = true;
            dgv_TotalPrice.Visible = true;

            // --- Gets the Bill with Prices of Individual Items ---

            //creates a command that uses the addemployye stored procedure
            SqlCommand cmd = new SqlCommand("getItemBill", conn);
            //tells the program that it is a stored procedure being used
            cmd.CommandType = CommandType.StoredProcedure;

            //adds the text box value to a variable
            string orderid = tb_gbOrderID.Text;

            //adds the variale to the parameter
            cmd.Parameters.AddWithValue("@orderid", orderid);

            //creates an adapter / dataTable object
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable itemsOrdered = new DataTable();

            //adds the query result to the data grid view 
            adapter.Fill(itemsOrdered);
            dgv_ItemsOrdered.DataSource = itemsOrdered;


            // --- Gets the Total Price of The Bill ---

            //creates a command that uses the addemployye stored procedure
            SqlCommand cmd2 = new SqlCommand("getTotalBill", conn);
            //tells the program that it is a stored procedure being used
            cmd2.CommandType = CommandType.StoredProcedure;

            //adds the variale to the parameter
            cmd2.Parameters.AddWithValue("@orderid", orderid);

            //creates an adapter / dataTable object
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
            DataTable totalPrice = new DataTable();

            //adds the query result to the data grid view 
            adapter2.Fill(totalPrice);
            dgv_TotalPrice.DataSource = totalPrice;
        }

        //method to make groupboxes invisible
        public void GroupVisability()
        {
            //array of the groupboxes
            GroupBox[] groupNames = { stAddOrderGroup, stRmvOrderGroup, stModOrderGroup, updStatusGroup, genBillGroup };

            //loops through the grou box array
            for (int i = 0; i < groupNames.Length; i++)
            {
                //sets each box to invisible 
                groupNames[i].Visible = false;
            }
        }
    }
}
