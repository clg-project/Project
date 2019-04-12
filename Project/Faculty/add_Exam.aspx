<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/admin.Master" AutoEventWireup="true" CodeBehind="add_Exam.aspx.cs" Inherits="Project.Faculty.add_Exam" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="420px">
      
    <table class=".table" style="margin-left:60px;">
        <tr><th colspan="2"><asp:Label ID="lab1" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="Red" style="margin-bottom:20px;" Font-Size="X-Large">Adding Exam</asp:Label></th></tr>
        <tr>
            <th>&nbsp;</th>
            <th>&nbsp;</th>
        </tr>
        <tr><td>Exam name : </td><td><asp:TextBox ID="Ename" runat="server"  CssClass="form-control" style="margin-bottom:20px;"  Width="225px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Ename" Display="Dynamic" ErrorMessage="*plz fill the field" ForeColor="Red" ValidationGroup="errmsg"></asp:RequiredFieldValidator>
            </td></tr>
        <tr><td>Total Marks : </td><td><asp:TextBox ID="marks" runat="server" CssClass="form-control"  style="margin-bottom:20px;" Width="225px" ></asp:TextBox> 
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="marks" Display="Dynamic" ErrorMessage="*plz fill the field" ForeColor="Red" ValidationGroup="errmsg"></asp:RequiredFieldValidator>
            </td></tr>
        <tr><td>Required Maks :</td><td><asp:TextBox ID="req_marks" runat="server" CssClass="form-control" style="margin-bottom:20px;" Width="225px" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="req_marks" Display="Dynamic" ErrorMessage="*plz fill the field" ForeColor="Red" ValidationGroup="errmsg"></asp:RequiredFieldValidator>
            </td></tr>
        <tr><td>Time limitation(In Minutes) : </td><td> <asp:TextBox ID="time" runat="server" format="HH:MM:SS" CssClass="form-control"  style="margin-bottom:20px;" Width="225px" OnTextChanged="time_TextChanged"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="time" Display="Dynamic" ErrorMessage="*plz fill the field" ForeColor="Red" ValidationGroup="errmsg"></asp:RequiredFieldValidator>
            </td></tr>
        <tr><td style="height: 71px">Start date : </td><td style="height: 71px">  <asp:TextBox ID="start_date" runat="server" format="dd:mm:yyyy" TextMode="Date" CssClass="form-control"  style="margin-bottom:20px;" Width="225px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="start_date" Display="Dynamic" ErrorMessage="*plz fill the field" ForeColor="Red" ValidationGroup="errmsg"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="start_date" Display="Dynamic" ErrorMessage="*Start date should be in the future" ForeColor="Red" Operator="GreaterThanEqual" Type="Date" ValidationGroup="errmsg"></asp:CompareValidator>
            </td></tr>
        <tr><td>End date : </td><td><asp:TextBox ID="end_date" runat="server" TextMode="Date" CssClass="form-control" style="margin-bottom:20px;"  Width="225px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="end_date" Display="Dynamic" ErrorMessage="*plz fill the field" ForeColor="Red" ValidationGroup="errmsg"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="start_date" ControlToValidate="end_date" Display="Dynamic" ErrorMessage="*End Date should be in the future" ForeColor="Red" Operator="GreaterThan" Type="Date" ValidationGroup="errmsg"></asp:CompareValidator>
            </td></tr>
        <tr>
            <td>
                Select Category :
            </td>
            <td>
                <asp:DropDownList ID="dropdownlist1" runat="server" DataTextField="Category_name" DataValueField="Category_id"></asp:DropDownList>

                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="dropdownlist1" Display="Dynamic" ErrorMessage="*Select Category" ForeColor="Red" ValidationGroup="errmsg"></asp:RequiredFieldValidator>

            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr align="center"><td colspan="2"><asp:Button ID="Button1" runat="server" Text="Add Exam" CssClass="btn btn-primary"  OnClick="Button1_Click" ValidationGroup="errmsg"  />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button2" runat="server" CssClass="btn btn-primary" PostBackUrl="~/Faculty/Exam_list.aspx" Text="Show Exam List" />
            <asp:Label ID="result" runat="server"></asp:Label>
            </td></tr>
    </table>

         </asp:Panel>
   

</asp:Content>
