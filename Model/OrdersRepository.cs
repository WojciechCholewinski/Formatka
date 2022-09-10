using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formatka.Model
{
    public class OrdersRepository
    {
        public List<Order> orderRepository { get; set; }

        public OrdersRepository()
        {
            orderRepository = GetOrdersRepo();
        }

        /* Function: Returns all the records in table
         * with the help of stored procedure
         * Used to populate the Repository (Collection)
         */
        public List<Order> GetOrdersRepo()
        {
            List<Order> listOfOrders = new List<Order>();

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connString))
            {
                if (conn == null)
                {
                    throw new Exception("Connection String is Null. Set the value of Connection String in MovieCatalog->Properties-?Settings.settings");
                }

                SqlCommand query = new SqlCommand("SELECT * from Orders", conn);
                conn.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    Order m = new Order();
                    m.Id = (int)row["id"];
                    m.Id_Customer = (int)row["Customer"];
                    m.Id_Service = (int)row["Id_Service"];
                    m.Delivery_date = row["Delivery_date"].ToString();
                    m.Date_of_order = row["Date_of_order"].ToString();
                    
                    listOfOrders.Add(m);
                }

                return listOfOrders;
            }
        }

        /*
         * Function: Return records that matches the Search Query String
         * with the help of stored procedure
         */
        //public List<Customer> GetMovieRepoSearch(string searchQuery)
        //{
        //    List<Customer> listOfCustomers = new List<Customer>();
        //    using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connString))
        //    {
        //        if (conn == null)
        //        {
        //            throw new Exception("Connection String is Null. Set the value of Connection String in MovieCatalog->Properties-?Settings.settings");
        //        }
        //        SqlCommand query = new SqlCommand("searchRecords", conn);
        //        conn.Open();
        //        query.CommandType = CommandType.StoredProcedure;
        //        SqlParameter param = new SqlParameter("PESELPhrase", SqlDbType.VarChar);
        //        param.Value = searchQuery;
        //        query.Parameters.Add(param);

        //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query);
        //        DataTable dataTable = new DataTable();
        //        sqlDataAdapter.Fill(dataTable);

        //        foreach (DataRow row in dataTable.Rows)
        //        {
        //            Customer m = new Customer();
        //            m.Id = (int)row["id"];
        //            m.First_Name = row["First_Name"].ToString();
        //            m.Surname = row["Surname"].ToString();
        //            m.PESEL = row["PESEL"].ToString();
        //            m.Id_card_number = row["Id_card_number"].ToString();
        //            m.Mail = row["Mail"].ToString();
        //            m.Phone_Number = row["Phone_Number"].ToString();
        //            m.Main_Address = row["Main_Address"].ToString();
        //            m.Correspondence_Address = row["Correspondence_Address"].ToString();
        //        }
        //        return listOfCustomers;
        //    }
        //}

        ///*
        // * Function: Add new record to the Database
        // * with the help of stored procedure
        // */
        //public void addNewRecord(Customer customerRecord)
        //{
        //    using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connString))
        //    {
        //        if (conn == null)
        //        {
        //            throw new Exception("Connection String is Null. Set the value of Connection String in MovieCatalog->Properties-?Settings.settings");
        //        }
        //        else if (customerRecord == null)
        //            throw new Exception("The passed argument 'movieRecord' is null");

        //        SqlCommand query = new SqlCommand("addCustomer", conn);
        //        conn.Open();
        //        query.CommandType = CommandType.StoredProcedure;
        //        SqlParameter param1 = new SqlParameter("pFirst_Name", SqlDbType.NVarChar);
        //        SqlParameter param2 = new SqlParameter("pSurname", SqlDbType.NVarChar);
        //        SqlParameter param3 = new SqlParameter("pPESEL", SqlDbType.VarChar);
        //        SqlParameter param4 = new SqlParameter("pId_card_number", SqlDbType.VarChar);
        //        SqlParameter param5 = new SqlParameter("pMail", SqlDbType.VarChar);
        //        SqlParameter param6 = new SqlParameter("pPhone_Number", SqlDbType.VarChar);
        //        SqlParameter param7 = new SqlParameter("pMain_Address", SqlDbType.NVarChar);
        //        SqlParameter param8 = new SqlParameter("pCorrespondence_Address", SqlDbType.NVarChar);

        //        param1.Value = customerRecord.First_Name;
        //        param2.Value = customerRecord.Surname;
        //        param3.Value = customerRecord.PESEL;
        //        param4.Value = customerRecord.Id_card_number;
        //        param5.Value = customerRecord.Mail;
        //        param6.Value = customerRecord.Phone_Number;
        //        param7.Value = customerRecord.Main_Address;
        //        param8.Value = customerRecord.Correspondence_Address;

        //        query.Parameters.Add(param1);
        //        query.Parameters.Add(param2);
        //        query.Parameters.Add(param3);
        //        query.Parameters.Add(param4);
        //        query.Parameters.Add(param5);
        //        query.Parameters.Add(param6);
        //        query.Parameters.Add(param7);
        //        query.Parameters.Add(param8);

        //        query.ExecuteNonQueryAsync();
        //    }
        }

    }



