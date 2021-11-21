<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ItemSetupUI.aspx.cs" Inherits="StockManagementWebApp.UI.ItemSetupUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Category"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="categoryDropDownList" runat="server" Height="16px" Width="126px"></asp:DropDownList>
                </td>
            </tr>
            
             <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="CompanyName"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="companyDropDownList" runat="server" Height="17px" Width="125px"></asp:DropDownList>
                </td>
            </tr>
            
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Item Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="itemNameTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            
             <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Reorder Level"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="reorderLevelTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
                <td>
                    <asp:Button ID="saveButton" runat="server" Text="Save" Width="84px" OnClick="saveButton_Click" />
                </td>
                <td>
                   <asp:Label ID="outputLabel" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
