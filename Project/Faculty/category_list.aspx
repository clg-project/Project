<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/admin.Master" AutoEventWireup="true" CodeBehind="category_list.aspx.cs" Inherits="Project.Faculty.category_list" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <asp:Panel ID="p1" runat="server" style="margin-left:50px;">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:TemplateField HeaderText="Category name">
                    <ItemTemplate>
                        <asp:Label ID="name" runat="server" Text='<%# Bind("Category_name") %>' />
                    </ItemTemplate>
                    </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="editcat" runat="server" Text="Edit" CssClass="btn btn-primary"  />
                        <asp:Button ID="deletecat" runat="server" Text="Delete"  CssClass="btn btn-primary" CommandName="deletecat" CommandArgument='<%# Eval("Category_id") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
               
            </Columns>
             <EmptyDataTemplate>
                     There is no question.
                </EmptyDataTemplate>
        </asp:GridView>
        
    </asp:Panel>
    <asp:Panel ID="p2" runat="server">
        <asp:Label ID="resultmsg" runat="server" />
    </asp:Panel>
</asp:Content>
