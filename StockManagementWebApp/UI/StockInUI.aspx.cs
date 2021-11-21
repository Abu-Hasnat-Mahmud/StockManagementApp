using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StockManagementWebApp.BLL;
using StockManagementWebApp.DAL.Models;

namespace StockManagementWebApp.UI
{
    public partial class StockInUI : System.Web.UI.Page
    {
        CompanySetupManager companySetupManager=new CompanySetupManager();
        ItemSetupManager itemSetupManager=new ItemSetupManager();
        StockInManager stockInManager=new StockInManager();
        ItemSetup itemSetup=new ItemSetup();
        StockIn stockIn = new StockIn();
      
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    companyNameDropDownList.DataSource = companySetupManager.GetAllCompany();
            //    companyNameDropDownList.DataTextField = "CompanyName";
            //    companyNameDropDownList.DataValueField = "Id";
            //    companyNameDropDownList.DataBind();
            //    companyNameDropDownList.Items.Insert(0,new ListItem("Select Company","0"));
            //}
                     
        }
        protected void companyNameDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int companyId = Convert.ToInt32(companyNameDropDownList.SelectedValue);
            //itemNameDropDownList.DataSource = itemSetupManager.GetAllItem(companyId);
            //itemNameDropDownList.DataTextField = "ItemName";
            //itemNameDropDownList.DataValueField = "Id";
            //itemNameDropDownList.DataBind();
            //itemNameDropDownList.Items.Insert(0, new ListItem("Select Item", "0"));
          
        }

        protected void itemNameDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int itemId = Convert.ToInt32(itemNameDropDownList.SelectedValue);
           // reorderLevelTextBox.Text = stockInManager.GetReorderLevel(itemId).ToString();
            itemSetup = stockInManager.GetReorderLevel(itemId);
            reorderLevelTextBox.Text = itemSetup.ReorderLevel.ToString();
            availableQuantityTextBox.Text = Convert.ToString(stockIn.StockInQuantity);
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {           
            stockIn.CompanyName = companyNameDropDownList.Text;
            stockIn.ItemName = itemNameDropDownList.Text;
            //stockIn.AvailableQuantity = Convert.ToInt32(availableQuantityTextBox.Text);
            stockIn.StockInQuantity = Convert.ToInt32(stockInQuantityTextBox.Text);

            outputLabel.Text = stockInManager.SetStock(stockIn);
        }
       
    }
}