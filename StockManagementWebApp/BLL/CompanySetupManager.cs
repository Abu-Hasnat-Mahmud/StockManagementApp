using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StockManagementWebApp.DAL.Gateway;
using StockManagementWebApp.DAL.Models;

namespace StockManagementWebApp.BLL
{
    public class CompanySetupManager
    {
        private CompanySetupGateway companySetupGateway;

        public CompanySetupManager()
        {
            companySetupGateway=new CompanySetupGateway();
        }

        public string SetCompany(CompanySetup companySetup)
        {
            if (companySetup.CompanyName=="")
            {
                return "Please Insert CompanyName Name";
            }
            else
            {
                if (companySetupGateway.IsRegNoExist(companySetup.CompanyName))
                {
                    return "CompanyName Name Allready Exist";
                }
                else
                {
                    int rowAffect = companySetupGateway.SetCompany(companySetup);
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

        public List<CompanySetup> GetAllCompany()
        {
            return companySetupGateway.GetAllCompany();
        }
    }
}