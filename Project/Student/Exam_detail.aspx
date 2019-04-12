<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/student.Master" AutoEventWireup="true" CodeBehind="Exam_detail.aspx.cs" Inherits="Project.Student.Exam_detail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .t1{

        }
        .t1 tr{

        }
        .t1 td{
            margin-left:100px;
        }
        .auto-style1 {
            width: 166px;
        }
        .auto-style2 {
            width: 160px;
        }
    </style>
    <asp:Panel ID="p1" runat="server" style="margin-left:50px;">
    <table CssClass="table t1 table-striped" >
        <tr><th colspan="2">&nbsp;</th></tr>
        
        <tr>
            <th colspan="2">&nbsp;</th>
        </tr>
        <tr>
            <th colspan="2">
                <asp:Label ID="lab1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="28px" ForeColor="Red">Exam Details</asp:Label>
            </th>
        </tr>
        
        <tr>
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <th>
                Exam name
            </th>
            <th><asp:Label ID="ename" runat="server" /></th>
        </tr>
        
        <tr>
            <td class="auto-style1">Total Marks </td>
            <td class="auto-style2">
                <asp:Label ID="tot_que" runat="server" />
            </td>
        </tr>
        <tr><td class="auto-style1">Required Marks</td><td class="auto-style2"><asp:Label ID="Req_mark" runat="server" /></td></tr>
        <tr><td class="auto-style1">Time(in minutes)</td><td class="auto-style2"><asp:Label ID="time" runat="server" />&nbsp;</td></tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
        <tr><td colspan="2">
            <asp:Button ID="Start" runat="server" CssClass="btn btn-primary" OnClick="Start_Click" Text="Start" Width="93px" />
            </td></tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="p2" runat="server" style="margin-left:50px;padding-right:10px;" BorderStyle="Solid" BorderWidth="1px" BorderColor="Black">
        
        <asp:Label ID="resultmsg" runat="server" style="margin-left:10px;"/>
        
    </asp:Panel>
</asp:Content>
