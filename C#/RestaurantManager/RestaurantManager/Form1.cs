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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

// I used mainly stackoverflow.com create this; I didn't have time to simplify and make it less repetitive


namespace RestaurantManager
{
    public partial class Form1 : Form
    {
        public SqlConnection conn = new SqlConnection(Connect.connectionString);
        public Form1()
        {
            InitializeComponent();
        }

        //runs when the submit button is pressed
        private void submitButton_Click(object sender, EventArgs e)
        {
            //gets the input from the text box
            string userID = tb_userID.Text;
            string password = tb_password.Text;


            try
            {
                //query to get the roleID only if the user login info matches with a user in the db
                string getUser = "Select roleID from users where userID = @userID AND password =@password";
                
                SqlCommand cmd = new SqlCommand(getUser, conn);

                //sets the parameters with the user input in the text boxes
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Parameters.AddWithValue("@password", password);

                conn.Open();

                //gets a single value (first column of first row) from the query (gets the roleID)
                int result = Convert.ToInt32(cmd.ExecuteScalar());

                //checks what role id the user has
                if (result == 1) //admin
                {
                    //creates an object for the admin users
                    AdminForm admin = new AdminForm();

                    //shows the admin window
                    admin.Show();

                }
                else if (result == 2) //manager
                {
                    //creates an object for the manager users
                    ManagerForm manager = new ManagerForm();

                    //shows the admin window
                    manager.Show();
                }
                else if (result == 3) //staff
                {
                    //creates an object for the staff users
                    StaffForm staff = new StaffForm();

                    //shows the admin window
                    staff.Show();
                }
            }
            //runs if the user input doesn't have a match
            catch
            {
                //shows a pop up message
                MessageBox.Show("Invalid UserID or Password");
            }
            conn.Close();
        }
        
        private void viewReportsBtn_Click(object sender, EventArgs e)
        {
            //makes group box visible
            salesGroup.Visible = true;
        }

        private void viewSalesBtn_Click(object sender, EventArgs e)
        {
            //creates a command that uses the addemployye stored procedure
            SqlCommand cmd = new SqlCommand("getDailySales", conn);
            //tells the program that it is a stored procedure being used
            cmd.CommandType = CommandType.StoredProcedure;

            //adds the text box value to a variable
            string ordertime = tb_dateSales.Text;

            //adds the variale to the parameter
            cmd.Parameters.AddWithValue("@ordertime", ordertime);

            //creates an adapter / dataTable object
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dailySaleTotal = new DataTable();

            //adds the query result to the data grid view 
            adapter.Fill(dailySaleTotal);
            dgv_Sales.DataSource = dailySaleTotal;
        }

        private void topSalesBtn_Click(object sender, EventArgs e)
        {

            //creates a command that uses the addemployye stored procedure
            SqlCommand cmd = new SqlCommand("Top3Items", conn);
            //tells the program that it is a stored procedure being used
            cmd.CommandType = CommandType.StoredProcedure;

            //creates an adapter / dataTable object
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable top3Items = new DataTable();

            //adds the query result to the data grid view 
            adapter.Fill(top3Items);
            dgv_Sales.DataSource = top3Items;
        }

        private void rpViewRsvBtn_Click(object sender, EventArgs e)
        {
            //declares a query
            string query = "Select * from Reservations";
            SqlCommand cmd = new SqlCommand(query, conn);

            //creates an adapter and datatable object 
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable reservations = new DataTable();

            //adds the query result to the data grif view table
            adapter.Fill(reservations);
            dgv_Sales.DataSource = reservations;
        }
    }

    //makes a class so all the forms can get the connection string
    class Connect
    {
        //assigns the connection string
        public static string connectionString = "Server=localhost;Database=RestaurantManagerDB;Trusted_Connection=True;";
    }   
}
