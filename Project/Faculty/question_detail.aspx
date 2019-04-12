<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/admin.Master" AutoEventWireup="true" CodeBehind="question_detail.aspx.cs" Inherits="Project.Faculty.question_detail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DetailsView ID="DetailsView1" runat="server" cssclass="table table-bordered" style="margin-left:50px;width:100%;height:50px;" AutoGenerateRows="False" Height="50px" Width="125px" OnPageIndexChanging="DetailsView1_PageIndexChanging">
        <Fields>
            <asp:BoundField  HeaderText="Question" DataField="Question" >
                 <HeaderStyle Font-Bold="true" CssClass="col-md-2" />
            </asp:BoundField>
            <asp:BoundField HeaderText="Option A" DataField="Option1" >
                <HeaderStyle Font-Bold="true" CssClass="col-md-2" />
            </asp:BoundField>
            <asp:BoundField HeaderText="Option B" DataField="Option2">
                <HeaderStyle Font-Bold="true" CssClass="col-md-2" />
            </asp:BoundField>
            <asp:BoundField HeaderText="Option C" DataField="Option3" >
                <HeaderStyle Font-Bold="true" CssClass="col-md-2" />
            </asp:BoundField>
            <asp:BoundField HeaderText="Option D" DataField="Option4" >
                <HeaderStyle Font-Bold="true" CssClass="col-md-2" />
            </asp:BoundField>
            <asp:BoundField HeaderText="Answer" DataField="Answer" >
                <HeaderStyle Font-Bold="true" CssClass="col-md-2" />
            </asp:BoundField>
        </Fields>
        <FooterTemplate>
            <asp:Button ID="back" Text="Back" runat="server" cssclass="btn btn-primary" OnClick="back_Click"/>
        </FooterTemplate>
    </asp:DetailsView>
    </asp:Content>
