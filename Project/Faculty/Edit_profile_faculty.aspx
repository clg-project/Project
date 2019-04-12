<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/admin.Master" AutoEventWireup="true" CodeBehind="Edit_profile_faculty.aspx.cs" Inherits="Project.Edit_profile_faculty" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



     <table  style="text-align: justify; margin-left:50px;border-collapse:unset;" class="col-lg-offset-4" >
                <tr>
                    <td  colspan="2" style="padding-bottom:50px;padding-left:70px;vertical-align:middle"> 
                        <asp:Label ID="Label1" runat="server" style="margin-bottom:10px;" Text="Profile Updation" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
   
                <tr>
                    <td style="width: 175px; height: 35px;vertical-align:middle"> F_name</td>
                    <td style="height: 35px;vertical-align:middle">
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" style="margin-bottom:20px;" Width="225px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Display="Dynamic" ErrorMessage="*plz fill the field" ControlToValidate="TextBox2" ForeColor="Red" ValidationGroup="errmsg"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 175px; height: 35px;vertical-align:middle"> E-mail id</td>
                    <td style="height: 35px;vertical-align:middle">
                        <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" style="margin-bottom:20px;" Width="225px"></asp:TextBox>
                        <asp:RequiredFieldValidator  ID="RequiredFieldValidator3" runat="server" Display="Dynamic" ErrorMessage="*plz fill the field" ControlToValidate="TextBox3" ForeColor="Red" ValidationGroup="errmsg"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox3" Display="Dynamic" ErrorMessage="*Email ID is not in correct format" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="errmsg"></asp:RegularExpressionValidator>
                    </td>
                </tr>
               
                <tr>
                    <td colspan="2" style="padding-top:40px;padding-left:110px;">
                        <asp:Button ID="Button1" runat="server" Text="Edit" CssClass="btn btn-primary" ValidationGroup="errmsg" Width="90px" OnClick="Button1_Click" />
                        <asp:Label ID="resulmsg" runat="server" />
                    </td>
                </tr>
            </table>
            



</asp:Content>
