<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CategoryNameUpdateUI.aspx.cs" Inherits="StockManagementWebApp.UI.CategoryNameUpdateUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <asp:HiddenField ID="idHiddenField" runat="server" />
                    <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="idTextBox" runat="server" ReadOnly="True" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Category"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="categoryNameTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="cancleButton" runat="server" Text="Cancle" OnClick="cancleButton_OnClick" />
                </td>
                <td>
                    <asp:Button ID="updateButton" runat="server" Text="Update" OnClick="updateButton_OnClick" />
                </td>
            </tr>
            <tr>
                <asp:Label ID="outputLabel" runat="server" Text=""></asp:Label>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
