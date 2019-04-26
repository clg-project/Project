<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/main.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Project.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
   <asp:Panel ID="p1" runat="server" Style="margin-left:50px;margin-right:auto;">
        <asp:Label ID="Login_Error" runat="server" Enabled="False" ForeColor="#FF3300"></asp:Label>
        <br />
        <br />
   
       <asp:Label ID="Label3" runat="server" Text="Select User :"></asp:Label>
    <asp:RadioButtonList ID="login_user" runat="server"  RepeatDirection="Horizontal" Width="300px">
        <asp:ListItem Value="Admin">Admin</asp:ListItem>
        <asp:ListItem Value="Faculty">Faculty</asp:ListItem>
        <asp:ListItem Value="Student">Student</asp:ListItem>
    </asp:RadioButtonList>

        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="login_user" Display="Dynamic" ErrorMessage="*Select User type" ForeColor="#FF3300" ValidationGroup="log"></asp:RequiredFieldValidator>

        <p >
    <asp:Label ID="Label1" runat="server" Text="Username :"></asp:Label>
    
    
    
    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" Width="250px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="*Enter Username" ForeColor="#FF3300" ValidationGroup="log"></asp:RequiredFieldValidator>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</p>
<p >
    <asp:Label ID="Label2" runat="server" Text="Password    :"></asp:Label>
    &nbsp;
    <asp:TextBox ID= "TextBox2" runat="server" TextMode="Password" CssClass="form-control" Width="250px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="*Enter Password" ForeColor="#FF3300" ValidationGroup="log"></asp:RequiredFieldValidator>
</p>
<p style="margin-left:12px" >
    <asp:Button ID="Button1" runat="server" Text="Login" CssClass="btn btn-primary" OnClick="Button1_Click" ValidationGroup="log" Width="100px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Home/forgotten_password.aspx">forget password ?</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
</p>
       </asp:Panel>

</asp:Content>
