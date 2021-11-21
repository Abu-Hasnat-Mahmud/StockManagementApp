using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using StockManagementWebApp.DAL.Models;

namespace StockManagementWebApp.DAL.Gateway
{
    public class CategorySetupGateway:CommonGateway
    {
        public int SetCategory(CategorySetup categorySetup)
        {
            string query = "INSERT INTO CategorySetupTB VALUES('" + categorySetup.CategoryName + "')";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            int rowAffect = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffect;
        }
        public bool IsNameExist(string name)
        {
            string query = "SELECT * FROM CategorySetupTB WHERE CategoryName='" + name + "'";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            bool isExists = Reader.HasRows;
            Connection.Close();
            return isExists;
        }

        public List<CategorySetup> GetAllCategory()
        {
            string query = "SELECT * FROM CategorySetupTB";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<CategorySetup> Categorys = new List<CategorySetup>();
            while (Reader.Read())
            {
                CategorySetup categorySetup=new CategorySetup();
                categorySetup.Id = Convert.ToInt32(Reader["Id"]);
                categorySetup.CategoryName = Reader["CategoryName"].ToString();

                Categorys.Add(categorySetup);
            }
            Connection.Close();
            return Categorys;
        }

        public int UpdateCategory(CategorySetup categorySetup)
        {
            string query = "Update CategorySetupTB SET CategoryName='" + categorySetup.CategoryName + "' WHERE id=" +
                           categorySetup.Id;
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            int rowAffect = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffect;
        }

        public CategorySetup GetCategoryById(int id)
        {
            string query = "SELECT * FROM CategorySetupTB WHERE Id=" + id;
            Command=new SqlCommand(query,Connection);

            Connection.Open();
            Reader = Command.ExecuteReader();
            Reader.Read();
            CategorySetup categorySetup=new CategorySetup();

            if (Reader.HasRows)
            {
                categorySetup.Id = Convert.ToInt32(Reader["Id"]);
                categorySetup.CategoryName = Reader["CategoryName"].ToString();
            }
            Connection.Close();
            return categorySetup;
        }
    }
}