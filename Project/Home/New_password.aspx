<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/main.Master" AutoEventWireup="true" CodeBehind="New_password.aspx.cs" Inherits="Project.Home.New_password" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
        New password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Field is required"></asp:RequiredFieldValidator>
    </p>
    <p>
        Confirm password:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox1" ControlToValidate="TextBox2" ErrorMessage="Pasword doesn't match"></asp:CompareValidator>
    </p>
    <p style="margin-left: 120px">
        <asp:Button ID="Button1" runat="server" Text="Submit" CssClass="btn btn-primary btn-block" OnClick="Button1_Click" />
        <asp:Label ID="Resultmsg" runat="server"></asp:Label>
    </p>
</asp:Content>
