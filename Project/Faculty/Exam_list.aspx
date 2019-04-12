<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/admin.Master" AutoEventWireup="true" CodeBehind="Exam_list.aspx.cs" Inherits="Project.Faculty.Exam_list" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:GridView ID="GridView1" runat="server" CssClass="table table-bordered" style="margin-left:50px;" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:TemplateField HeaderText="Exam name">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("Exam_name") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Passing mark">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("Total_Marks") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Required mark">
                <ItemTemplate>
                    <asp:Label ID="req_marks" runat="server" Text='<%# Bind("Req_marks") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Time">
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("Time") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Start Date">
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("Start_date","{0:dd/MM/yyyy}") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="End Date">
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server"  Text='<%# Bind("End_date","{0:dd/MM/yyyy}") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Button">
               <ItemTemplate>
                   <asp:Button ID="edit" runat="server" Text="Edit" CssClass="btn btn-primary" PostBackUrl='<%# "~/Faculty/modify_exam.aspx?exam_id="+Eval("[Exam-id]") %>'/>
                   <asp:Button ID="Delete" runat="server" Text="Delete" CssClass="btn btn-primary" CommandName="deleteexam" CommandArgument='<%# Eval("[Exam-id]") %>'/>
               </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <br />
    <asp:Label ID="resultmsg" runat="server" />
</asp:Content>
