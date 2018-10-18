using ProjectSyncWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjectSyncWebAPI.Repository
{
    public class SyncManagerRepository
    {
        public List<PageViewModel> GetPages()
        {
            List<PageViewModel> pageViewModel = new List<PageViewModel>();
            string query = "Select PageID,PageName from Pages";
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = @"Data Source=AJAY-PC\SQLEXPRESS;Initial Catalog=Practice;Integrated Security=True";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                
                DataTable data = new DataTable();
                data.Load(reader);

                foreach(DataRow row in data.Rows)
                {
                    pageViewModel.Add(new PageViewModel()
                    {
                        PageID = row["PageID"] != null ? Convert.ToInt32(row["PageID"]) : -1,
                        PageName = row["PageName"] != null? Convert.ToString(row["PageName"]):string.Empty
                    });
                }

                conn.Close();
                return pageViewModel;
            }
            catch(Exception ex)
            {
                conn.Close();
                throw ex;
            }
        }
    }
}