<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompanySetupUI.aspx.cs" Inherits="StockManagementWebApp.UI.CompanySetupUI" %>

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
                    <asp:Label ID="Label1" runat="server" Text="Company Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="companyNameTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
                <td>
                     <asp:Button ID="companyNameSaveButton" runat="server" Text="Save" Width="87px" OnClick="companyNameSaveButton_Click" />
                </td>
                <td>
                     <asp:Label ID="outputLabel" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
 

        <asp:GridView ID="companyNameGridView" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField HeaderText="SL">
                    <ItemTemplate>
                        <asp:HiddenField ID="idHiddenField" Value='<%#Eval("Id") %>' runat="server" />
                        <asp:Label ID="Label2" runat="server" Text='<%#Container.DataItemIndex+1 %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="Company Name">
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%#Eval("CompanyName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            
        </asp:GridView>
    </form>
</body>
</html>
