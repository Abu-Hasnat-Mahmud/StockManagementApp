using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using StockManagementWebApp.BLL;
using StockManagementWebApp.DAL.Models;

namespace StockManagementWebApp.UI
{
    public partial class ItemSetupUI : System.Web.UI.Page
    {
        CategorySetupManager categorySetupManager=new CategorySetupManager();
        CompanySetupManager companySetupManager=new CompanySetupManager();
        ItemSetupManager itemSetupManager=new ItemSetupManager();
        ItemSetup itemSetup = new ItemSetup();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                categoryDropDownList.DataSource = categorySetupManager.GetAllCategroy();
                categoryDropDownList.DataTextField = "CategoryName";
                categoryDropDownList.DataValueField = "CategoryName"; 
                categoryDropDownList.DataBind();

                categoryDropDownList.Items.Insert(0, new ListItem("Select Category", "0"));

                companyDropDownList.DataSource = companySetupManager.GetAllCompany();
                companyDropDownList.DataTextField = "CompanyName";
                companyDropDownList.DataValueField = "CompanyName";
                companyDropDownList.DataBind();

                companyDropDownList.Items.Insert(0, new ListItem("Select Company","0"));
            }
        }

       

        protected void saveButton_Click(object sender, EventArgs e)
        {
            itemSetup.Category = categoryDropDownList.Text;
            itemSetup.CompanyName = companyDropDownList.Text;
            itemSetup.ItemName = itemNameTextBox.Text;
            if (reorderLevelTextBox.Text=="")
            {
                itemSetup.ReorderLevel = 0;
            }
            else
            {
                itemSetup.ReorderLevel = Convert.ToInt32(reorderLevelTextBox.Text);
            }
            itemSetup.CategoryId = categoryDropDownList.SelectedIndex;
            itemSetup.CompanyId = companyDropDownList.SelectedIndex;

            outputLabel.Text = itemSetupManager.SetItem(itemSetup);
        }
    }
}