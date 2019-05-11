using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DoctorRecommendationProject.Repository
{
    public class DBConnection
    {
        public SqlConnection con;
        public void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["DoctorRecommendationDB"].ToString();
            con = new SqlConnection(constring);
        }
    }
}