<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/HomeMP.Master" AutoEventWireup="true" CodeBehind="code_verification.aspx.cs" Inherits="Project.Home.code_verification" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Enter Code: -</p>
    <p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Enter" />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Resultmsg" runat="server"></asp:Label>
    </p>
</asp:Content>
