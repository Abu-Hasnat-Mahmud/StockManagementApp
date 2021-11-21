<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StockInUI.aspx.cs" Inherits="StockManagementWebApp.UI.StockInUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   
</head>
<body>
    <form id="form1" runat="server">
        
        <table>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="Company"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="companyNameDropDownList" runat="server" AppendDataBoundItems="True" AutoPostBack="True" OnSelectedIndexChanged="companyNameDropDownList_SelectedIndexChanged" >
                    </asp:DropDownList>
                </td>
            </tr>
            
             <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label2" runat="server" Text="Item"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="itemNameDropDownList" runat="server" OnSelectedIndexChanged="itemNameDropDownList_SelectedIndexChanged" AutoPostBack="True" AppendDataBoundItems="True">
                    </asp:DropDownList>
                </td>
            </tr>
            
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" Text="Reorder Level"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="reorderLevelTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            
             <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label4" runat="server" Text="Available Quantity"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="availableQuantityTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            
             <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label5" runat="server" Text="Stock In Quantity"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="stockInQuantityTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="saveButton" runat="server" Text="Save" Height="28px" OnClick="saveButton_Click" Width="103px" />
                </td>
                <td>
                    <asp:Label ID="outputLabel" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
    
    </form>
</body>
</html>
