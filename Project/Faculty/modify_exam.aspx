<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/admin.Master" AutoEventWireup="true" CodeBehind="modify_exam.aspx.cs" Inherits="Project.Faculty.modify_exam" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="w-100" style="margin-left:50px">
        <tr>
            <td colspan="2"><h1 style="color: #FF0000">Modify Exam</h1></td>
           
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>
           
        </tr>
        <tr>
            <td style="height: 29px;">Exam Name</td>
            <td style="height: 29px">
                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" Width="225px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="height: 29px">Total Marks</td>
            <td style="height: 29px">
                <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" Width="225px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="height: 29px">Required Marks</td>
            <td style="height: 29px">
                <asp:TextBox ID="req_mrk" runat="server" CssClass="form-control" Width="225px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Time</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" Width="225px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="height: 29px">Start Date</td>
            <td style="height: 29px">
                <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" Width="225px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>End date</td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control" Width="225px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="Button1" runat="server" Text="Modify" OnClick="Button1_Click" cssclass="btn btn-primary"/>
                <asp:Label ID="resultmsg" runat="server"></asp:Label>
            </td>
        </tr>
    </table>

</asp:Content>
