<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/admin.Master" AutoEventWireup="true" CodeBehind="select_exam.aspx.cs" Inherits="Project.Faculty.select_exam" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
        <br />
        <br />
        <br />

        <table style="margin-left:60px;">
            <tr><td colspan="2">
                <asp:Label ID="lab1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="28px" ForeColor="Red">Exam Selection</asp:Label>
                </td>
            </tr>
            <tr><td>&nbsp;</td>
                <td> &nbsp;</td>
            </tr>
            <tr><td>&nbsp;</td>
                <td> &nbsp;</td>
            </tr>
            <tr><td>Select Exam :  </td>
                <td> <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Exam_name" DataValueField="Exam-id" >
        </asp:DropDownList>
                     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TestConnectionString %>" SelectCommand="SELECT * FROM [Exam] WHERE ([F_id] = @F_id)">
                         <SelectParameters>
                             <asp:SessionParameter Name="F_id" SessionField="faculty" Type="String" />
                         </SelectParameters>
                    </asp:SqlDataSource>
                </td>
            </tr>
            <tr><td colspan="2">&nbsp;</td>
            </tr>


            <tr><td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button1" runat="server" Text="Add Question" CssClass="btn btn-primary" OnClick="Button1_Click" />
                       <asp:Button ID="show" runat="server" CssClass="btn btn-primary" Text="Show Question" style="margin-left:50px;" OnClick="show_Click" />
                       </td>
            </tr>


            <tr><td colspan="2">&nbsp;</td>
            </tr>


        </table>
</asp:Content>
