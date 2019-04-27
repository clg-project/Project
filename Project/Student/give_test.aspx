<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/student.Master" AutoEventWireup="true" CodeBehind="give_test.aspx.cs" Inherits="Project.give_test" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        $('body').bind('unload',function()
        {
            alert('hello');
        });
    </script>
    <asp:ScriptManager ID="ScriptManager1" runat="server" >
        </asp:ScriptManager>
    <asp:UpdatePanel ID="upanel"  runat="server" style="margin-left:50px;" UpdateMode="Conditional">
    <ContentTemplate>

        <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
        </asp:Timer>
         <br />
        Time: -
        <asp:Label ID="clock" runat="server"></asp:Label>
        
        <br />
        <br />
        <asp:Panel ID="panel" runat="server">
        Question
        <asp:Label ID="qno" runat="server"></asp:Label>
        &nbsp;of
        <asp:Label ID="totque" runat="server"></asp:Label>
        <br />
        <br />
        Question:
        <asp:Label ID="Que_test" runat="server"></asp:Label>
        <br />
        <br />
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="op" />
        <asp:Label ID="option1" runat="server"></asp:Label>
        <br />
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="op" />
        <asp:Label ID="option2" runat="server"></asp:Label>
        <br />
        <asp:RadioButton ID="RadioButton3" runat="server" GroupName="op" />
        <asp:Label ID="option3" runat="server"></asp:Label>
        <br />
            <asp:RadioButton ID="RadioButton4" runat="server" GroupName="op" />
            <asp:Label ID="option4" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Submit" runat="server" CssClass="btn btn-primary" OnClick="Submit_Click" Text="Submit" />
            <asp:Label ID="resultmsg" runat="server"></asp:Label>
            <br />
            <br />
            
           
            <asp:Button ID="previous" runat="server" CssClass="btn btn-primary" Text="Previous" style="margin-right:20px;" OnClick="previous_Click" />
        <asp:Button ID="Next" runat="server" CssClass="btn btn-primary" OnClick="next_Click" Text="Next" style="margin-right:20px;" />
        
        <asp:Button ID="Button2" runat="server" CssClass="btn btn-primary" OnClick="Finish_Click1" Text="Finish Exam" />
        </asp:Panel>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
            <asp:AsyncPostBackTrigger ControlID="Button2" EventName="Click" />
        </Triggers>
        </asp:UpdatePanel>    
    <asp:Label ID="Label3" runat="server" style="margin-left:50px;"></asp:Label>
</asp:Content>
