<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/admin.Master" AutoEventWireup="true" CodeBehind="student_list.aspx.cs" Inherits="Project.Faculty.student_list" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" style="margin-left:50px;" CssClass="table table-bordered" AutoGenerateColumns="False" DataKeyNames="Student_id" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:BoundField DataField="F_name" HeaderText="First name" SortExpression="F_name" />
            <asp:BoundField DataField="L_name" HeaderText="Last name" SortExpression="L_name" />
            <asp:BoundField DataField="Student_id" HeaderText="Student Id" ReadOnly="True" SortExpression="Student_id" />
            <asp:BoundField DataField="DOB" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Date Of Birth" SortExpression="DOB" />
            <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
            <asp:BoundField DataField="Contact" HeaderText="Contact No." SortExpression="Contact" />
            <asp:TemplateField HeaderText="Email ID">
                <ItemTemplate>
                    <asp:Label ID="email" runat="server" Text='<%# Bind("[E-mail_id]") %>'/>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="delete" runat="server" Text="Delete" CssClass="btn btn-primary" CommandName="deletestudent" CommandArgument='<%# Eval("Student_id") %>'/>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <EmptyDataTemplate>
            No Student.
        </EmptyDataTemplate>
    </asp:GridView>
    <asp:Label ID="resultmsg" runat="server" style="margin-left:50px;" Text=""></asp:Label>
    </asp:Content>
