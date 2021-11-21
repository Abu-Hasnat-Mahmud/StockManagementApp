using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StockManagementWebApp.DAL.Gateway;
using StockManagementWebApp.DAL.Models;

namespace StockManagementWebApp.BLL
{
    public class CategorySetupManager
    {
        private CategorySetupGateway categorySetupGateway;

        public CategorySetupManager()
        {
            categorySetupGateway=new CategorySetupGateway();
        }

        public string SetCategory(CategorySetup categorySetup)
        {
            if (categorySetup.CategoryName == "")
            {
                return "Please Insert Category Name";
            }
            else
            { 
                if (categorySetupGateway.IsNameExist(categorySetup.CategoryName))
                {
                    return "Category Name Allready Exist";
                }
                else
                {
                    int rowAffect = categorySetupGateway.SetCategory(categorySetup);
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

        public List<CategorySetup> GetAllCategroy()
        {
            return categorySetupGateway.GetAllCategory();
        }

        public string UpdateCategory(CategorySetup categorySetup)
        {
            int rowAffect =categorySetupGateway.UpdateCategory(categorySetup);
            if (rowAffect > 0)
            {
                return "Update Successful";
            }
            else
            {
                return "Update Failed";
            }
        }

        public CategorySetup GetCategoryById(int id)
        {
           return categorySetupGateway.GetCategoryById(id);
        }
    }
}