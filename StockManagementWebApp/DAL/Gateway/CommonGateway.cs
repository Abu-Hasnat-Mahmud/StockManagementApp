﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace StockManagementWebApp.DAL.Gateway
{
    public class CommonGateway
    {
        private string connectionString =
            WebConfigurationManager.ConnectionStrings["StockManagmentConString"].ConnectionString;

        public SqlCommand Command { get; set; }
        public SqlConnection Connection { get; set; }
        public SqlDataReader Reader { get; set; }

        public CommonGateway()
        {
            Connection=new SqlConnection(connectionString);
        }
    }
}