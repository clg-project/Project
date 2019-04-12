<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/admin.Master" AutoEventWireup="true" CodeBehind="showresult.aspx.cs" Inherits="Project.Faculty.showresult" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="p1" runat="server" style="display:inline;">
    <table style="margin-left:50px;margin-top:50px;">
     <tr>   <td style="padding-bottom:50px;">Exam:
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Exam_name" DataValueField="column1">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TestConnectionString %>" SelectCommand="SELECT [Exam-id] AS column1, [Exam_name] FROM [Exam]"></asp:SqlDataSource>
    </td></tr>
     <tr style="text-align:center"><td>   <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" CssClass="btn btn-primary" Text="Button" />
     </td></tr>
         </table>
    </asp:Panel>
    <br />
    <asp:Panel ID="p2" runat="server">
    
        <asp:GridView ID="GridView1" CssClass="table table-bordered" style="display:block;" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2">
            <Columns>
                <asp:BoundField DataField="Student_id" HeaderText="Student Id" SortExpression="Student_id" />
                <asp:BoundField DataField="Result" HeaderText="Result" SortExpression="Result" />
                <asp:BoundField DataField="Marks" HeaderText="Marks" SortExpression="Marks" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:TestConnectionString %>" SelectCommand="SELECT [Student_id], [Result], [Marks] FROM [Result] WHERE ([Exam_id] = @Exam_id)">
            <SelectParameters>
                <asp:QueryStringParameter Name="Exam_id" QueryStringField="exam_id" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    
    </asp:Panel>
</asp:Content>
