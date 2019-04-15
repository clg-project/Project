<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/student.Master" AutoEventWireup="true" CodeBehind="Student_homepage.aspx.cs" Inherits="Project.Student_homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

   <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" ForeColor="Red" Text="Online Examination System..."></asp:Label><br /><br />
    <br /><br /><br /><p><asp:Label ID="Label2" runat="server" Text="Rules for Exam :" ForeColor="Red" Font-Bold="True" Font-Italic="True" Font-Size="X-Large"></asp:Label></p>
    <br /><br /><br /><br />

    <p>
        ~  All Questions are not mendatory.<br />
        ~  You can skip questions without attempting which will count as 0 mark.<br />
        ~  Exam should be completed within time limit of each exam.<br />
        ~  Each correct answer give you 1 marks.<br />

    </p>

</asp:Content>
