using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using StockManagementWebApp.DAL.Models;

namespace StockManagementWebApp.DAL.Gateway
{
    public class ItemSetupGateway:CommonGateway
    {
        public int SetItem(ItemSetup itemSetup)
        {
            string query = "INSERT INTO ItemSetupTB VALUES('"+itemSetup.Category+"','"+itemSetup.CompanyName+"','"+itemSetup.ItemName+"','"+itemSetup.ReorderLevel+"','"+itemSetup.CategoryId+"','"+itemSetup.CompanyId+"')";
            Command=new SqlCommand(query,Connection);
            Connection.Open();
            int rowAffect = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffect;
        }

        public bool IsRegNoExist(string name)
        {
            string query = "SELECT * FROM ItemSetupTB WHERE ItemName='"+name+"'";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            bool isExists = Reader.HasRows;
            Connection.Close();
            return isExists;
        }

        public List<ItemSetup> GetAllItem(int Id)
        {
            string query ="select ItemName from ItemSetupTB as i inner join CompanySetupTB as c on i.CompanyId=c.Id where i.CompanyId='"+Id+"'";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<ItemSetup> Items = new List<ItemSetup>();
            while (Reader.Read())
            {
                ItemSetup itemSetup=new ItemSetup();
                //itemSetup.Id = Convert.ToInt32(Reader["Id"]);
                itemSetup.ItemName = Reader["ItemName"].ToString();
                Items.Add(itemSetup);
            }
            Connection.Close();
            return Items;
        }
    }
}