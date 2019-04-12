<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/main.Master" AutoEventWireup="true" CodeBehind="forgotten_password.aspx.cs" Inherits="Project.forgotten_password" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>
        Forget Password?</h2>
    <p>
        &nbsp;</p>
    <p>
        Email Id:
        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" Width="225px"></asp:TextBox>
&nbsp;&nbsp; </p>
    
    <p style="margin-left: 50px">
        <asp:Button ID="Button1" runat="server" Text="Recover Now" CssClass="btn btn-primary" OnClick="Button1_Click"  />
    &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Resultmsg" runat="server"></asp:Label>
    </p>
</asp:Content>
