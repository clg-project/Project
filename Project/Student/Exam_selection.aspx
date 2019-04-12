<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/student.Master" AutoEventWireup="true" CodeBehind="Exam_selection.aspx.cs" Inherits="Project.Student.Exam_selection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   


    <table style="margin-left:50px;">
        <tr><th colspan="2">&nbsp;</th>
        </tr>

        <tr><th colspan="2">&nbsp;</th>
        </tr>

        <tr><th colspan="2"><asp:Label ID="lab1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="28px" ForeColor="Red">Exam Selection</asp:Label></th>
        </tr>

        <tr><td>&nbsp;</td>
            <td>
                 &nbsp;</td>
        </tr>

        <tr><td>&nbsp;</td>
            <td>
                 &nbsp;</td>
        </tr>

        <tr><td>Select Exam  :  </td>
            <td style="margin-left:50px;">
                 <asp:DropDownList ID="DropDownList1" runat="server" DataTextField="Exam_name" DataValueField="Exam-id" CssClass="form-control" OnSelectedIndexChanged ="DropDownList1_SelectedIndexChanged" Width="150px">
        </asp:DropDownList>
            </td>
        </tr>

        <tr><td>&nbsp;</td><td>&nbsp;</td></tr>



        <tr><td>&nbsp;</td><td>&nbsp;</td></tr>



        <tr><td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" CssClass="btn btn-primary" Text="Start Exam" /></td></tr>



    </table>
</asp:Content>
