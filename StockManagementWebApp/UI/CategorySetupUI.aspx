<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CategorySetupUI.aspx.cs" Inherits="StockManagementWebApp.UI.CategorySetupUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Default.css" rel="stylesheet" />

</head>
<body>
<nav id="nav-1">
        <a class="link-1" href="CategorySetupUI.aspx">Category Setup</a>
        <a class="link-1" href="CompanySetupUI.aspx">Company Setup</a>
        <a class="link-1" href="ItemSetupUI.aspx">Item Setup</a>
        <a class="link-1" href="#">Stock In</a>
        <a class="link-1" href="#">Stock Out</a>
        <a class="link-1" href="#">Stock Item</a>
        <a class="link-1" href="#">Stock Sell</a>
        
</nav>
    <form id="form1" runat="server">
     <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="CategoryName"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="categoryNameTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
                <td>
                    <asp:Button ID="categoryNameSaveButton" runat="server" Text="Save" OnClick="categoryNameSaveButton_Click" Width="92px" />
                </td>
                <td>
                     <asp:Label ID="outputLabel" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
         <asp:GridView ID="categoryNameGridView" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField HeaderText="SL">
                    <ItemTemplate>
                          <asp:HiddenField ID="idHiddenField" runat="server" Value='<%#Eval("Id") %>'/>
                        <asp:Label ID="Label2" runat="server" Text='<%#Container.DataItemIndex+1%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="Category Name">
                    <ItemTemplate>                       
                        <asp:Label ID="Label3" runat="server" Text='<%#Eval("CategoryName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                
                 <asp:TemplateField HeaderText="Action">
                    <ItemTemplate>                       
                        <asp:LinkButton ID="updateLinkButton" runat="server" OnClick="updateLinkButton_OnClick">Update</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            
        </asp:GridView>
    </form>
</body>
</html>
