using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StockManagementWebApp.DAL.Gateway;
using StockManagementWebApp.DAL.Models;

namespace StockManagementWebApp.BLL
{
    public class StockInManager
    {
        private StockInGateway stockInGateway;
      
        public StockInManager()
        {
            stockInGateway=new StockInGateway();
        }
        public string SetStock(StockIn stockIn)
        {
            
           int rowAffect = stockInGateway.SetStock(stockIn);
           if (rowAffect > 0)
           {
               return "Save Successful";
           }
           else
           {
               return "Save Failed";
           }             
            
        }

        public ItemSetup GetReorderLevel(int itemId)
        {
            return stockInGateway.GetReorderLevel(itemId);
        }


    }
}