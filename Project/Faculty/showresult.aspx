<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/admin.Master" AutoEventWireup="true" CodeBehind="showresult.aspx.cs" Inherits="Project.Faculty.showresult" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="p1" runat="server" style="display:inline;">
    <table style="margin-left:50px;margin-top:50px;">
     <tr>   <td style="padding-bottom:50px;">Exam:
        <asp:DropDownList ID="DropDownList1" runat="server" DataTextField="Exam_name" DataValueField="Exam-id">
        </asp:DropDownList>
    </td></tr>
     <tr style="text-align:center"><td>   <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" CssClass="btn btn-primary" Text="Submit" />
     </td></tr>
         </table>
    </asp:Panel>
    <br />
    <asp:Panel ID="p2" runat="server" style="margin-left:100px;">
    
        <asp:GridView ID="GridView1" CssClass="table table-bordered" style="display:block;" runat="server" AutoGenerateColumns="False" >
            <Columns>
                <asp:BoundField DataField="Student_id" HeaderText="Student ID" SortExpression="Student_id" />           
                <asp:BoundField DataField="Result" HeaderText="Result" SortExpression="Result" />
                <asp:BoundField DataField="Marks" HeaderText="Marks" SortExpression="Marks" />
            </Columns>
            <EmptyDataTemplate>
                No Records.
            </EmptyDataTemplate>
        </asp:GridView>
        <asp:Button ID="Button2" runat="server" CssClass="btn btn-primary" OnClick="Button2_Click" Text="Download Report" />
    
    </asp:Panel>
</asp:Content>
