using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RestaurantManager
{
    public partial class ManagerForm : Form
    {
        public SqlConnection conn = new SqlConnection(Connect.connectionString);
        public ManagerForm()
        {
            InitializeComponent();
        }

        //  ------  Order Management Options  ------
        private void omAddBtn_Click(object sender, EventArgs e)
        {
            //goes to method
            GroupVisability();
            //makes the group box visible
            addOrderGroup.Visible = true;
        }
        private void omRmvBtn_Click(object sender, EventArgs e)
        {
            //goes to method
            GroupVisability();
            //makes the group box visible
            rmvOrderGroup.Visible = true;
        }
        private void omModBtn_Click(object sender, EventArgs e)
        {
            //goes to method
            GroupVisability();
            //makes the group box visible
            modOrderGroup.Visible = true;
        }

        //  ------  Reservation Management Options  ------
        private void rmViewBtn_Click_1(object sender, EventArgs e)
        {
            //goes to method
            GroupVisability();

            //makes the group box / data grid view visible
            rsvGroup.Visible = true;
            dgv_RsvInfo.Visible = true;

            //declares a query
            string query = "Select * from Reservations";
            SqlCommand cmd = new SqlCommand(query, conn);

            //creates an adapter and datatable object 
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable reservations = new DataTable();
            
            //adds the query result to the data grif view table
            adapter.Fill(reservations);
            dgv_RsvInfo.DataSource = reservations;
        }
        private void rmAddBtn_Click(object sender, EventArgs e)
        {
            //goes to method
            GroupVisability();
            //makes the group box visible
            addRsvGroup.Visible = true;
        }
        private void rmRmvBtn_Click(object sender, EventArgs e)
        {
            //goes to method
            GroupVisability();
            //makes the group box visible
            rmRsvGroup.Visible = true;
        }


        //  ------  User Input For Task Management Options  ------
        private void tmAddBtn_Click(object sender, EventArgs e)
        {
            //goes to method
            GroupVisability();
            //makes the group box visible
            addTaskGroup.Visible = true;
        }
        private void tmUpdBtn_Click(object sender, EventArgs e)
        {
            //goes to method
            GroupVisability();
            //makes the group box visible
            updTaskGroup.Visible = true;
        }



        //  ------  User Input For Order Management  ------
        private void addOrderBtn_Click(object sender, EventArgs e)
        {
            // ----  Creates an Order ---

            //asigns the textbox values to variables
            string orderTime = tb_orderTime.Text;
            string discount = tb_discount.Text;
            string status = tb_status.Text;
            string orderType = tb_orderType.Text;
            string userID = tb_ordUserID.Text;

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


            // --- Creates Order Detail ---

            //gets the text box values, assigns it to variables
            string itemID = tb_ordItemID.Text;
            string tableID = tb_ordTableID.Text;

            //gets orderid of the most recent order
            string getOrderID = "select top 1 orderID from Orders order by OrderTime desc;";
            SqlCommand cmd2 = new SqlCommand(getOrderID, conn);

            //gets the orderId that was created from above procedure
            int result = Convert.ToInt32(cmd2.ExecuteScalar());

            SqlCommand cmd3 = new SqlCommand("AddOrderDetails", conn);
            //tells the program that it is a stored procedure being used
            cmd3.CommandType = CommandType.StoredProcedure;

            //adds the variable as the parameters 
            cmd3.Parameters.AddWithValue("@itemID", itemID);
            cmd3.Parameters.AddWithValue("@tableID", tableID);
            cmd3.Parameters.AddWithValue("@orderID", result);

            //executes query; confirms task; closes connection
            cmd3.ExecuteNonQuery();
            lb_orderAdded.Visible = true;
            conn.Close();
        }
        private void rmvOrderBtn_Click(object sender, EventArgs e)
        {
            //creates a command that uses the addemployye stored procedure
            SqlCommand cmd = new SqlCommand("removeOrderItem", conn);
            //tells the program that it is a stored procedure being used
            cmd.CommandType = CommandType.StoredProcedure;
            string orderID = tb_rmvOrderID.Text;
            string itemID = tb_rmvItemID.Text;

            //gets text box values; assigns them to variables
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Parameters.AddWithValue("@itemID", itemID);

            //opens conn; executes query
            conn.Open();
            cmd.ExecuteNonQuery();

            //confirms action; closes conn
            lb_OrderRemoved.Visible = true;
            conn.Close();

        }
        private void updOrderBtn_Click(object sender, EventArgs e)
        {
            //creates a command that uses the addemployye stored procedure
            SqlCommand cmd = new SqlCommand("UpdateOrder", conn);
            //tells the program that it is a stored procedure being used
            cmd.CommandType = CommandType.StoredProcedure;
            string orderID = tb_updOrderID.Text;
            string status = tb_updStatus.Text;
            string discount = tb_updDiscount.Text;

            //assigns text box values to variables
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Parameters.AddWithValue("@discount", discount);
            cmd.Parameters.AddWithValue("@status", status);
            
            //opens conn; executes procedure
            conn.Open();
            cmd.ExecuteNonQuery();
            //confirms action; closes conn
            lb_orderUpd.Visible = true;
            conn.Close();
        }
        private void addItemBtn_Click(object sender, EventArgs e)
        {
            //creates a command that uses the addemployye stored procedure
            SqlCommand cmd = new SqlCommand("addOrderMenuItem", conn);
            //tells the program that it is a stored procedure being used
            cmd.CommandType = CommandType.StoredProcedure;
            string itemid = tb_modAddItem.Text;
            string tableid = tb_modTableID.Text;
            string orderid = tb_modOrderID.Text;

            //assigns text box values to variables
            cmd.Parameters.AddWithValue("@itemid", itemid);
            cmd.Parameters.AddWithValue("@tableid", tableid);
            cmd.Parameters.AddWithValue("@orderID", orderid);

            //opens conn; executes procedure
            conn.Open();
            cmd.ExecuteNonQuery();
            //confirms action; closes conn
            lb_itemAdded.Visible = true;
            conn.Close();
        }

        //  ------  User Input For Reservation Management  ------

        private void addRsvBtn_Click(object sender, EventArgs e)
        {
            //creates a command that uses the addemployye stored procedure
            SqlCommand cmd = new SqlCommand("AddReservation", conn);
            //tells the program that it is a stored procedure being used
            cmd.CommandType = CommandType.StoredProcedure;

            //assigns text box values to variables
            string name = tb_rsvName.Text;
            string time = tb_rsvTime.Text;
            string size = tb_rsvSize.Text;
            string table = tb_rsvTable.Text;

            //adds the variables to parameters
            cmd.Parameters.AddWithValue("@customername", name);
            cmd.Parameters.AddWithValue("@Reservationtime", time);
            cmd.Parameters.AddWithValue("@groupsize", size);
            cmd.Parameters.AddWithValue("@tableID", table);

            //opens conn; executes procedure
            conn.Open();
            cmd.ExecuteNonQuery();
            //confirms action; closes connection
            lb_rsvAdded.Visible = true;
            conn.Close();
        }
        private void rmRsvBtn_Click(object sender, EventArgs e)
        {
            //creates a command that uses the addemployye stored procedure
            SqlCommand cmd = new SqlCommand("RemoveRsv", conn);
            //tells the program that it is a stored procedure being used
            cmd.CommandType = CommandType.StoredProcedure;

            //assigns text box values to variables
            string rsvID = tb_RmvRsvID.Text;

            //adds the variable to the parameter
            cmd.Parameters.AddWithValue("@reservationID", rsvID);

            //opens conn; executes procedure
            conn.Open();
            cmd.ExecuteNonQuery();
            //confirms action; closes connection
            lb_RsvRemoved.Visible = true;
            conn.Close();
        }


        //  ------  User Input For Task Management  ------

        private void addTaskBtn_Click(object sender, EventArgs e)
        {
            //creates a command that uses the addemployye stored procedure
            SqlCommand cmd = new SqlCommand("CreateTask", conn);
            //tells the program that it is a stored procedure being used
            cmd.CommandType = CommandType.StoredProcedure;

            //assigns text box values to variables
            string date = tb_taskDate.Text;
            string desc = tb_taskDesc.Text;
            string userID = tb_taskUserID.Text;
            string status = tb_taskStatus.Text;
            string complete = tb_taskComplete.Text;

            //adds the variables to parameters
            cmd.Parameters.AddWithValue("@duedate", date);
            cmd.Parameters.AddWithValue("@description", desc);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@completedBy", complete);


            //opens conn; executes procedure
            conn.Open();
            cmd.ExecuteNonQuery();

            //confirms action; closes connection
            lb_taskAdded.Visible = true;
            conn.Close();
        }
        private void updStatusBtn_Click(object sender, EventArgs e)
        {

            //creates a command that uses the addemployye stored procedure
            SqlCommand cmd = new SqlCommand("updateTaskStatus", conn);
            //tells the program that it is a stored procedure being used
            cmd.CommandType = CommandType.StoredProcedure;

            //assigns text box values to variables
            string assignmentid = tb_updTaskID.Text;
            string status = tb_updTaskStatus.Text;
            string complete = tb_updComplete.Text;

            //adds the variables to parameters
            cmd.Parameters.AddWithValue("@assignmentid", assignmentid);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@completedBy", complete);

            //opens conn; executes procedure
            conn.Open();
            cmd.ExecuteNonQuery();
            //confirms action; closes connection
            lb_updStatus.Visible = true;
            conn.Close();
        }



        //method to make group boxes invisible
        public void GroupVisability()
        {
            //array of the groupboxes
            GroupBox[] groupNames = { addOrderGroup, rmvOrderGroup, modOrderGroup, addRsvGroup, addTaskGroup, updTaskGroup, rsvGroup, rmRsvGroup };

            //loops through the grou box array
            for (int i = 0; i < groupNames.Length; i++)
            {
                //sets each box to invisible 
                groupNames[i].Visible = false;
            }
        }


    }
}
