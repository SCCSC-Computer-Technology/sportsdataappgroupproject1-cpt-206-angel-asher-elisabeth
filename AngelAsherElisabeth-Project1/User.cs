using AngelAsherElisabeth_Project1.SportsDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngelAsherElisabeth_Project1
{
    public class User
    {
        //id to manage the user
        public int Id { get; set; }
        /**
         * Login method to check if the user exists in the database and return the user id if it does, otherwise return -1
         */
        public int Login(string username, string password)
        {
            try
            {
                SportsDBDataSet.usersDataTable users = new SportsDBDataSet.usersDataTable();

                SportsDBDataSetTableAdapters.usersTableAdapter adapter = new SportsDBDataSetTableAdapters.usersTableAdapter();
                DataTable records = adapter.GetLogin(username, password);

                if (records.Rows.Count > 0)
                {
                    Id = (int)records.Rows[0]["Id"];
                    return Id;
                }
                return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while logging in: " + ex.Message);
                return -1;
            }
        }
        /**
         * GetUser method to fetch the user details from the database and return the record row
         */
        public DataRow GetUser(int id)
        {
            try
            {
                //connect to the user table
                SportsDBDataSetTableAdapters.usersTableAdapter adapter = new SportsDBDataSetTableAdapters.usersTableAdapter();
                //get the user details for the given id using the db query
                DataTable records = adapter.GetUserDetails(id);
                //make sure something was returned
                if (records.Rows.Count > 0)
                {
                    return records.Rows[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching user details: " + ex.Message);
            }
            //if everything fails return null
            return null;
        }
        /**
         * RegisterUser method to add a new user to the db
         */
        public int RegisterUser(string username, string password, string email)
        {
            try
            {
                //connect to the user table
                SportsDBDataSetTableAdapters.usersTableAdapter adapter = new SportsDBDataSetTableAdapters.usersTableAdapter();
               
                // Runs the insert and returns the count of rows inserted
                int rowsAffected = adapter.InsertUser(username, email, password);
                // If rowsAffected is greater than 0, the insert was successful
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Success! User added. " + rowsAffected.ToString());
                }
                return rowsAffected;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                // This catches database-specific errors (Duplicate IDs, Constraint issues)
                MessageBox.Show("Database Error: " + ex.Message);
                return -1;
            }
            catch (Exception ex)
            {
                // This catches everything else
                MessageBox.Show("An error occurred: " + ex.Message);
                return -1;
            }

        }
    }
}
