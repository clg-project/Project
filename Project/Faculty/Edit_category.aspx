<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/admin.Master" AutoEventWireup="true" CodeBehind="Edit_category.aspx.cs" Inherits="Project.Faculty.Edit_category" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="p1" runat="server">
        <table>
            <tr>
                <td>Category name:</td>
                <td><asp:TextBox ID="textbox1" runat="server" /></td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="b1" runat="server" CssClass="btn btn-primary" Text="Submit" OnClick="b1_Click" />
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="p2" runat="server" >
        <asp:Label ID="resultmsg" runat="server" />
    </asp:Panel>
</asp:Content>
