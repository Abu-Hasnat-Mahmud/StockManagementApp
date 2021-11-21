using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using StockManagementWebApp.DAL.Gateway;
using StockManagementWebApp.DAL.Models;

namespace StockManagementWebApp.DAL.Gateway
{
    public class CompanySetupGateway:CommonGateway
    {
        public int SetCompany(CompanySetup companySetup)
        {
            string query = "INSERT INTO CompanySetupTB VALUES('" + companySetup.CompanyName + "')";
            Command=new SqlCommand(query,Connection);
            Connection.Open();
            int rowAffect = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffect;
        }

        public bool IsRegNoExist(string name)
        {
            string query = "SELECT * FROM CompanySetupTB WHERE CompanyName='"+name+"'";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            bool isExists = Reader.HasRows;
            Connection.Close();
            return isExists;
        }

        public List<CompanySetup> GetAllCompany()
        {
            string query = "SELECT * FROM CompanySetupTB";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<CompanySetup> Companys = new List<CompanySetup>();
            while (Reader.Read())
            {
                CompanySetup companySetup = new CompanySetup();
                companySetup.Id = Convert.ToInt32(Reader["Id"]);
                companySetup.CompanyName = Reader["CompanyName"].ToString();

                Companys.Add(companySetup);
            }
            Connection.Close();
            return Companys;
        }



    }
}