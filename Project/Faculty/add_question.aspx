<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/admin.Master" AutoEventWireup="true" CodeBehind="add_question.aspx.cs" Inherits="Project.Faculty.add_question" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="margin-left:50px;">
        <tr>
            <td style="width: 142px">
                <asp:Label ID="Que" runat="server">Question: -</asp:Label>
            </td>
            <td>
                <asp:TextBox ID="question" runat="server" Height="77px" TextMode="MultiLine" Cssclass="form-control" Width ="225px"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 142px">
                <asp:Label ID="Op1" runat="server">OptionA: -</asp:Label>
            </td>
            <td>
                <asp:TextBox ID="option1" runat="server" Cssclass="form-control" Width ="225px"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 142px">
                <asp:Label ID="Op2" runat="server">OptionB: -</asp:Label>
            </td>
            <td>
                <asp:TextBox ID="option2" runat="server" Cssclass="form-control" Width ="225px"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 142px">
                <asp:Label ID="Op3" runat="server">OptionC: -</asp:Label>
            </td>
            <td>
                <asp:TextBox ID="option3" runat="server" Cssclass="form-control" Width ="225px"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 142px">
                <asp:Label ID="Op4" runat="server">OptionD: -</asp:Label>
            </td>
            <td style="height: 23px">
                <asp:TextBox ID="option4" runat="server" Cssclass="form-control" Width ="225px"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 142px">
                <asp:Label ID="ans" runat="server">Answer: -</asp:Label>
            </td>
            <td>
                <asp:RadioButtonList ID="answer" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem>A</asp:ListItem>
                    <asp:ListItem>B</asp:ListItem>
                    <asp:ListItem>C</asp:ListItem>
                    <asp:ListItem>D</asp:ListItem>
                </asp:RadioButtonList>
                <br />
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align:center; ">
                <br />
                <br />
                <asp:Button ID="add_que" runat="server" Text="Add Question" CssClass="btn btn-primary" OnClick="add_que_Click" />&nbsp;
                <asp:Button ID="Button1" runat="server" Text="Add Another Question" CssClass="btn btn-primary " OnClick="Button1_Click" />&nbsp;
                <asp:Button ID="Button2" runat="server" Text="Show Question" CssClass="btn btn-primary " OnClick="Button2_Click" />&nbsp;
                <asp:Button ID="Button3" runat="server" Text="Finish" CssClass="btn btn-primary" />
                <asp:Label ID="result" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
