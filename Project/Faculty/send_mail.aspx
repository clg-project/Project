<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/admin.Master" AutoEventWireup="true" CodeBehind="send_mail.aspx.cs" Inherits="Project.Faculty.send_mail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="p1" runat="server" style="margin-left:50px;">
    
    <asp:DropDownList ID="d1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Category_name" DataValueField="Category_id" />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TestConnectionString %>" SelectCommand="SELECT [Category_name], [Category_id] FROM [category]"></asp:SqlDataSource>
        <br /><br />
    <asp:Button ID="b1" runat="server" Text="Send Email" CssClass="btn btn-primary" OnClick="b1_Click"/>
        <asp:Label ID="resultmsg" runat="server"></asp:Label>
        </asp:Panel>
</asp:Content>
