<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/admin.Master" AutoEventWireup="true" CodeBehind="modify_question.aspx.cs" Inherits="Project.Faculty.modify_question" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellspacing="10px" cellpadding="20px">
        <tr>
            <td style="width: 101px">
                <asp:Label ID="Label1" runat="server" Text="Question: "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Textbox1" runat="server"  TextMode="MultiLine" Cssclass="form-control"  Height="67px" Width="323px" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Textbox1" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ValidationGroup="errmsg" BackColor="White" ForeColor="Red">* Plz fill this field</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 101px; height: 80px;">
                <asp:Label ID="Label2" runat="server" Text="Option A: "></asp:Label>
            </td>
            <td style="height: 80px">
                <asp:TextBox ID="Textbox2" runat="server" Cssclass="form-control" Width ="225px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ValidationGroup="errmsg" ControlToValidate="Textbox2" ForeColor="Red">* Plz fill this field</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 101px">
                <asp:Label ID="Label3" runat="server" Text="Option B: "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Textbox3" runat="server" Cssclass="form-control" Width ="225px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ValidationGroup="errmsg" ControlToValidate="Textbox3" ForeColor="Red">* Plz fill this field</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 101px">
                <asp:Label ID="Label4" runat="server" Text="Option C: "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Textbox4" runat="server" Cssclass="form-control" Width ="225px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ValidationGroup="errmsg" ControlToValidate="Textbox4" ForeColor="Red">* Plz fill this field</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 101px">
                <asp:Label ID="Label5" runat="server" Text="Option D: "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Textbox5" runat="server" Cssclass="form-control" Width ="225px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="RequiredFieldValidator" ValidationGroup="errmsg" ControlToValidate="Textbox5" ForeColor="Red">* Plz fill this field</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 101px">
                <asp:Label ID="Label6" runat="server" Text="Answer: "></asp:Label>
            </td>
            <td>
                <asp:RadioButtonList ID="radioanswer" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem>A</asp:ListItem>
                    <asp:ListItem>B</asp:ListItem>
                    <asp:ListItem>C</asp:ListItem>
                    <asp:ListItem>D</asp:ListItem>
                </asp:RadioButtonList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ValidationGroup="errmsg" ControlToValidate="radioanswer" ForeColor="Red">* Plz select the Answer</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="Submit" Text="Modify" runat="server" cssclass="btn btn-primary" OnClick="Submit_Click" ValidationGroup="errmsg" />
                <asp:Label ID="Resultmsg" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
