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
        public int Id { get; set; }


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

        public DataRow GetUser(int id)
        {
            try
            {
                SportsDBDataSetTableAdapters.usersTableAdapter adapter = new SportsDBDataSetTableAdapters.usersTableAdapter();
                DataTable records = adapter.GetUserDetails(id);

                if (records.Rows.Count > 0)
                {
                    return records.Rows[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching user details: " + ex.Message);
            }
            return null;
        }

        public int RegisterUser(string username, string password, string email)
        {
            try
            {
                SportsDBDataSetTableAdapters.usersTableAdapter adapter = new SportsDBDataSetTableAdapters.usersTableAdapter();

                // The method returns the count of rows inserted
                int rowsAffected = adapter.InsertUser(username, email, password);

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
