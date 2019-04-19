<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/student.Master" AutoEventWireup="true" CodeBehind="Result.aspx.cs" Inherits="Project.Result" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    
    <asp:GridView ID="GridView1" runat="server" Cssclass="table table-bordered" AutoGenerateColumns="False" style="margin-left:50px;">
        <Columns>
            <asp:TemplateField HeaderText="Exam Name">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("Exam_name") %>' ></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
                
            <asp:TemplateField HeaderText="Result">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("Result") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Marks">
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("Marks") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <EmptyDataTemplate>
            <asp:Label ID="l1" runat="server">No Records.</asp:Label>
        </EmptyDataTemplate>
    </asp:GridView>
   <asp:Panel ID="p1" runat="server" style="margin-left:50px;">
       <asp:Label ID="Resultmsg" runat="server"></asp:Label>
   </asp:Panel>
    
</asp:Content>
