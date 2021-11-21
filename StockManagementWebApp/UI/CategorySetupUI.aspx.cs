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
    public partial class CategorySetupUI : System.Web.UI.Page
    {
        CategorySetupManager categorySetupManager=new CategorySetupManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            categoryNameGridView.DataSource = categorySetupManager.GetAllCategroy();
            categoryNameGridView.DataBind();
        }

        protected void categoryNameSaveButton_Click(object sender, EventArgs e)
        {
            CategorySetup categorySetup=new CategorySetup();
            categorySetup.CategoryName = categoryNameTextBox.Text;
            outputLabel.Text = categorySetupManager.SetCategory(categorySetup);

            categoryNameGridView.DataSource = categorySetupManager.GetAllCategroy();
            categoryNameGridView.DataBind();
        }

        protected void updateLinkButton_OnClick(object sender, EventArgs e)
        {
            LinkButton updateLinkButton = (LinkButton)sender;
            DataControlFieldCell dataControlFieldCell = (DataControlFieldCell)updateLinkButton.Parent;
            GridViewRow gridViewRow = (GridViewRow)dataControlFieldCell.Parent;
            HiddenField hiddenField = (HiddenField)gridViewRow.FindControl("idHiddenField");
            int id = Convert.ToInt32(hiddenField.Value);

           Response.Redirect("CategoryNameUpdateUI.aspx?Id="+id);
        }
    }
}