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
    public partial class CompanySetupUI : System.Web.UI.Page
    {
        CompanySetupManager companySetupManager=new CompanySetupManager();
        protected void Page_Load(object sender, EventArgs e)
        {       
                companyNameGridView.DataSource = companySetupManager.GetAllCompany();
                companyNameGridView.DataBind();
            
        }

        protected void companyNameSaveButton_Click(object sender, EventArgs e)
        {
            CompanySetup companySetup=new CompanySetup();

            companySetup.CompanyName = companyNameTextBox.Text;
            outputLabel.Text = companySetupManager.SetCompany(companySetup);
            companyNameGridView.DataSource = companySetupManager.GetAllCompany();
            companyNameGridView.DataBind();
        }
    }
}