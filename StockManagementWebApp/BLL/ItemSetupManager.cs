using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StockManagementWebApp.DAL.Gateway;
using StockManagementWebApp.DAL.Models;

namespace StockManagementWebApp.BLL
{
    public class ItemSetupManager
    {
        private ItemSetupGateway itemSetupGateway;

        public ItemSetupManager()
        {
            itemSetupGateway=new ItemSetupGateway();
        }

        public string SetItem(ItemSetup itemSetup)
        {
            if (itemSetup.ItemName == "")
            {
                return "Please Insert Item";
            }
            
            else
            {
                if (itemSetupGateway.IsRegNoExist(itemSetup.ItemName))
                {
                    return "This Item Allready Exist";
                }
                else
                {
                    int rowAffect = itemSetupGateway.SetItem(itemSetup);
                    if (rowAffect > 0)
                    {
                        return "Save Successful";
                    }
                    else
                    {
                        return "Save Failed";
                    }
                }
            }            
        }

        public List<ItemSetup> GetAllItem(int Id)
        {
            return itemSetupGateway.GetAllItem(Id);
        }

        
    }
}