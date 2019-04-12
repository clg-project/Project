<%@ Page Title="" Language="C#" MasterPageFile="../Masterpage/Site2.Master" AutoEventWireup="true" CodeBehind="Faculty_Registration.aspx.cs" Inherits="Project.Faculty_Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <asp:Panel ID="Panel1" runat="server" Height="384px" Width="499px">
                        
        <div>            
            <table style="text-align: justify; margin-left:50px;">
                <tr>
                    <td colspan="2" style="padding-bottom:50px;padding-left:70px;"> 
                        <asp:Label ID="Label1" runat="server" style="margin-bottom:10px;" Text="Faculty Registration" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 175px;margin-left:30px;">       
                        F_id</td>
                    <td style="width:500px;">
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"  Width="225px"></asp:TextBox>
                        <asp:RequiredFieldValidator style="margin-bottom:20px;" ID="RequiredFieldValidator1" runat="server"  Display="static" ErrorMessage="*plz fill the field" ControlToValidate="TextBox1" ForeColor="Red" ValidationGroup="errmsg"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 175px; height: 35px"> F_name</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" style="margin-bottom:20px;" Width="225px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Display="Dynamic" ErrorMessage="*plz fill the field" ControlToValidate="TextBox2" ForeColor="#CC0000" ValidationGroup="errmsg"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 175px; height: 35px"> E-mail id</td>
                    <td style="height: 35px">
                        <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" style="margin-bottom:20px;" Width="225px"></asp:TextBox>
                        <asp:RequiredFieldValidator  ID="RequiredFieldValidator3" runat="server" Display="Dynamic" ErrorMessage="*plz fill the field" ControlToValidate="TextBox3" ForeColor="#CC0000" ValidationGroup="errmsg"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox3" Display="Dynamic" ErrorMessage="*Email ID is not in correct format" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="errmsg"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 175px"> password</td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" style="margin-bottom:20px;" TextMode="Password" Width="225px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Display="Dynamic" ErrorMessage="*plz fill the field" ControlToValidate="TextBox4" ForeColor="#CC0000" ValidationGroup="errmsg"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 175px; height: 26px;">Confirm password</td>
                    <td style="height: 26px">
                        <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control" style="margin-bottom:20px;" Width="222px" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" Display="Dynamic" ErrorMessage="*plz fill the field" ForeColor="#CC0000" ValidationGroup="errmsg"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox4" ControlToValidate="TextBox5" Display="Dynamic" ErrorMessage="*password should be match" ForeColor="#CC0000" ValidationGroup="errmsg"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="padding-top:40px;padding-left:110px;">
                        <asp:Button ID="Button1" runat="server" Text="Add Faculty" OnClick="Button1_Click" CssClass="btn btn-primary" ValidationGroup="errmsg" />

                    </td>
                </tr>
            </table>
            
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </div>
            </asp:Panel>
</asp:Content>
