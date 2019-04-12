<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/admin.Master" AutoEventWireup="true" CodeBehind="show_question.aspx.cs" Inherits="Project.Faculty.show_question" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div >
    <asp:GridView ID="GridView1" runat="server" CssClass="table table-bordered" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" AutoGenerateColumns="False" GridLines="None" OnRowCommand="GridView1_RowCommand" style="margin-left:30px;">
        <Columns>
            <asp:TemplateField HeaderText="Question Name">
                <ItemTemplate>
                    <asp:Label runat="server" ID="Label1" Text='<%#Bind("Question") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Question ID">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("Que_id") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:HyperLink ID="btn_detailsexam" runat="server" CssClass="btn" BackColor="#343A40" BorderStyle="None" ForeColor="White" NavigateUrl='<%# "~/Faculty/question_detail.aspx?qid=" + Eval("Que_id")+"&exam_id="+Eval("Exam_id") %>'>
                                            <i class="fa fa-info-circle" aria-hidden="true"></i> Details
                                    </asp:HyperLink>
                                    <asp:HyperLink ID="btn_editexam" runat="server" CssClass="btn" BackColor="#343A40" BorderStyle="None" ForeColor="White" NavigateUrl='<%# "~/Faculty/modify_question.aspx?qid=" + Eval("Que_id")+"&exam_id="+Eval("Exam_id") %>'>
                                            <i class="fa fa-pencil-square-o" aria-hidden="true"></i> Edit
                                    </asp:HyperLink>
                                    <asp:LinkButton ID="btn_deleteexam" runat="server" CssClass="btn" BackColor="#343A40" BorderStyle="None" ForeColor="White" CommandArgument='<%# Eval("Que_id") %>' CommandName="deleteexamquestion">
                                            <i class="fa fa-trash" aria-hidden="true"></i> Delete
                                    </asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <EmptyDataTemplate>
            There is no question.
        </EmptyDataTemplate>
        <PagerStyle CssClass="card-footer" HorizontalAlign="Right" />
    </asp:GridView>
        </div>
    </asp:Content>
