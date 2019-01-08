<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ResetPassword.aspx.cs" Inherits="emppro.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <% if ((int)Session["Role1"] == 20001)
             { %>
   <a href="admin.aspx">Back</a>
<% } %>
    <%else
             {
                 if (current.Text != "pass1234")
                 { %>
    <a href="search.aspx">Back</a>
    <%}
             else
             {%>
    <a href="loginpage.aspx">Back</a>
    <%}
             } %>

    
    <div class="a">
    Reset your password<br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Current Password"></asp:Label>
&nbsp;<asp:TextBox ID="current" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
   
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Text="New Password"></asp:Label>
&nbsp;&nbsp;<asp:TextBox ID="newpass" runat="server" TextMode="Password"></asp:TextBox>
    &nbsp;
        <br />
        <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label2" runat="server" Text="Confirm Password"></asp:Label>
&nbsp;<asp:TextBox ID="conpass" runat="server" TextMode="Password"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="newpass" ControlToValidate="conpass" ErrorMessage="Password doesn't match"></asp:CompareValidator>
    <br /><br />
    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
        <br />
        </div>
</asp:Content>
