<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/student.Master" AutoEventWireup="true" CodeBehind="Student_homepage.aspx.cs" Inherits="Project.Student_homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

   

  


    <table style="margin-left:50px;">
        <tr><th>&nbsp;</th></tr>
        <tr><th>&nbsp;</th></tr>
        <tr><th><asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" ForeColor="Red" Text="Online Examination System..."></asp:Label></th></tr>
        <tr><td>&nbsp;</td></tr>
        <tr><td><asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" ForeColor="Red">Rules for Exam :</asp:Label></td></tr>
        <tr><td>&nbsp;</td></tr>
        <tr><td>   ~  All Questions are not mendatory.<br /></td></tr>
        <tr><td> ~  You can skip questions without attempting which will count as 0 mark.<br /></td></tr>
        <tr><td>~  Exam should be completed within time limit of each exam.<br /></td></tr>
        <tr><td> ~  Each correct answer give you 1 marks.<br /></td></tr>

    </table>

</asp:Content>
