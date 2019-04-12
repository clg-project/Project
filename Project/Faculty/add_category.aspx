<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/admin.Master" AutoEventWireup="true" CodeBehind="add_category.aspx.cs" Inherits="Project.Faculty.add_category" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Panel ID="p1" runat="server" style="margin-left:50px;" >
        <table>
            <div style="float:left;">
                <tr>
                    <th colspan="2">
                        <asp:Label ID="lab1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" ForeColor="Red">Add Category</asp:Label>
                        </th>
                </tr>
            </div>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="padding-right:30px;">Category Name :</td>
                <td>
                    <asp:TextBox ID="textbox1" cssclass="form-control" runat="server"  />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="textbox1" Display="Dynamic" ErrorMessage="*Enter Category name" ForeColor="Red" ValidationGroup="errmsg"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr align="center">
                <td colspan="2"> 
                    <asp:Button ID="button1" runat="server" OnClick="button1_Click" CssClass="btn btn-primary" Text="Submit" ValidationGroup="errmsg" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="show" runat="server" PostBackUrl="~/Faculty/category_list.aspx" cssclass="btn btn-primary" Text="Show Category" />
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
