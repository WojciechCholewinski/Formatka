using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formatka.Model
{
    public class FormatkaRepository
    {
        public List<Customer> formatkaRepository { get; set; }

        public FormatkaRepository()
        {
            formatkaRepository = GetFormatkaRepo();
        }

        /* Function: Returns all the records in table
         * with the help of stored procedure
         * Used to populate the Repository (Collection)
         */
        public List<Customer> GetFormatkaRepo()
        {
            List<Customer> listOfCustomers = new List<Customer>();

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connString))
            {
                if (conn == null)
                {
                    throw new Exception("Connection String is Null. Set the value of Connection String in MovieCatalog->Properties-?Settings.settings");
                }

                SqlCommand query = new SqlCommand("SELECT * from Customers", conn);
                conn.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    Customer m = new Customer();
                    m.Id = (int)row["id"];
                    m.First_Name = row["First_Name"].ToString();
                    m.Surname = row["Surname"].ToString();
                    m.PESEL = row["PESEL"].ToString();
                    m.Id_card_number = row["Id_card_number"].ToString();
                    m.Mail = row["Mail"].ToString();
                    m.Phone_Number = row["Phone_Number"].ToString();
                    m.Main_Address = row["Main_Address"].ToString();
                    m.Correspondence_Address = row["Correspondence_Address"].ToString();

                    listOfCustomers.Add(m);
                }

                return listOfCustomers;
            }
        }

        /*
         * Function: Return records that matches the Search Query String
         * with the help of stored procedure
         */
        public List<Customer> GetMovieRepoSearch(string searchQuery)
        {
            List<Customer> listOfCustomers = new List<Customer>();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connString))
            {
                if (conn == null)
                {
                    throw new Exception("Connection String is Null. Set the value of Connection String in MovieCatalog->Properties-?Settings.settings");
                }
                SqlCommand query = new SqlCommand("searchRecords", conn);
                conn.Open();
                query.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("PESELPhrase", SqlDbType.VarChar);
                param.Value = searchQuery;
                query.Parameters.Add(param);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    Customer m = new Customer();
                    m.Id = (int)row["id"];
                    m.First_Name = row["First_Name"].ToString();
                    m.Surname = row["Surname"].ToString();
                    m.PESEL = row["PESEL"].ToString();
                    m.Id_card_number = row["Id_card_number"].ToString();
                    m.Mail = row["Mail"].ToString();
                    m.Phone_Number = row["Phone_Number"].ToString();
                    m.Main_Address = row["Main_Address"].ToString();
                    m.Correspondence_Address = row["Correspondence_Address"].ToString();
                }
                return listOfCustomers;
            }
        }

        
    }
}
