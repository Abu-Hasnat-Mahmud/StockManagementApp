using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StockManagementWebApp.BLL;
using StockManagementWebApp.DAL.Models;

namespace StockManagementWebApp.UI
{
    public partial class CategoryNameUpdateUI : System.Web.UI.Page
    {
        CategorySetupManager categorySetupManager=new CategorySetupManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["Id"]);
                CategorySetup categorySetup = categorySetupManager.GetCategoryById(id);
                idTextBox.Text = Convert.ToString(categorySetup.Id);
                idHiddenField.Value = Convert.ToString(categorySetup.Id);
                categoryNameTextBox.Text = categorySetup.CategoryName;
            }
        }

        protected void cancleButton_OnClick(object sender, EventArgs e)
        {
           Response.Redirect("CategorySetupUI.aspx");
        }

        protected void updateButton_OnClick(object sender, EventArgs e)
        {
            CategorySetup categorySetup=new CategorySetup();
            categorySetup.Id = Convert.ToInt32(idHiddenField.Value);
            categorySetup.CategoryName = categoryNameTextBox.Text;
            outputLabel.Text = categorySetupManager.UpdateCategory(categorySetup);
            Response.Redirect("CategorySetupUI.aspx");
        }
    }
}