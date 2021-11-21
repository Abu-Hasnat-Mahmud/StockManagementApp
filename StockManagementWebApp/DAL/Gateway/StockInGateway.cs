using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using StockManagementWebApp.DAL.Models;

namespace StockManagementWebApp.DAL.Gateway
{
    public class StockInGateway:CommonGateway
    {
        public int SetStock(StockIn stockIn)
        {
            string query = "INSERT INTO StockInTB VALUES('" + stockIn.CompanyName + "','" + stockIn.ItemName + "','"+stockIn.StockInQuantity+"')";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            int rowAffect = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffect;
        }

        public ItemSetup GetReorderLevel(int itemId)
        {
            string query = "select ItemSetupTB.ReorderLevel from ItemSetupTB where Id ='"+itemId+"'";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            ItemSetup itemSetup=new ItemSetup();
            while (Reader.Read())
            {
                itemSetup.ReorderLevel = Convert.ToInt32(Reader["ReorderLevel"]);
            }
            Connection.Close();
            return itemSetup;
        }

        //public ItemSetup GetQuantityByItem(int id)
        //{
        //    string query = "SELECT * FROM StockInTB WHERE Id"=+id;
        //    Command = new SqlCommand(query, Connection);
        //    Connection.Open();
        //    Reader = Command.ExecuteReader();
        //    ItemSetup itemSetup = new ItemSetup();
        //    while (Reader.Read())
        //    {
        //        itemSetup.ReorderLevel = Convert.ToInt32(Reader["ReorderLevel"]);
        //    }
        //    Connection.Close();
        //    return itemSetup;
        //}
    }
}