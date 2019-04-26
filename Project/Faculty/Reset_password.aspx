<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/admin.Master" AutoEventWireup="true" CodeBehind="Reset_password.aspx.cs" Inherits="Project.Faculty.Reset_password" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class=".table" style="margin-left:60px;">
        <tr><th>&nbsp;</th><th>&nbsp;</th></tr>
        <tr><th colspan="2"><asp:Label ID="lab1" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="Red" style="margin-bottom:20px;" Font-Size="X-Large">Reset Password</asp:Label></th></tr>
        <tr><th>&nbsp;</th><th>&nbsp;</th></tr>
        <tr><td>New Password : </td><td>
            <asp:TextBox ID="TextBox1" runat="server" TextMode="Password" CssClass="form-control" Width="225px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="*Enter Password" ForeColor="Red" ValidationGroup="errmsg"></asp:RequiredFieldValidator>
            </td></tr>
        <tr><td>&nbsp;</td><td>
            &nbsp;</td></tr>
        <tr><td>Confirm Password :</td><td>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" CssClass="form-control" Width="225px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="*Enter Confirm Password" ForeColor="Red" ValidationGroup="errmsg"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox1" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="*Both password should be same" ForeColor="Red" ValidationGroup="errmsg"></asp:CompareValidator>
            </td></tr>
        <tr><td>&nbsp;</td><td>
            &nbsp;</td></tr>
        <tr><td>&nbsp;</td><td>
            &nbsp;</td></tr>
        <tr><td>
            <asp:Button ID="Button1" runat="server" Text="Reset" CssClass="btn btn-primary" OnClick="Button1_Click" ValidationGroup="errmsg"/>
            </td><td>
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td></tr>


    </table>
</asp:Content>
