<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="emppro.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <form id="form1">
        
    <nav id="nav">  
      
        <div class="b">
         <a href="Loginpage.aspx">Logout</a> 
            
        </div>
        </nav>
       </form>

</asp:Content>
    
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Welcome,&nbsp;<asp:Label ID="lblMsg" runat="server" Font-Bold="True" Font-Size="Medium"></asp:Label><br /><br />
 <a href="Search.aspx">Search</a>&nbsp;&nbsp;<a href="add.aspx">Add</a>&nbsp;&nbsp;<a href="AddRole.aspx">Add Role</a>&nbsp;&nbsp;<a href="WebForm8.aspx">Update</a>&nbsp;&nbsp;<a href="ResetPassword.aspx">Reset Password</a>&nbsp;&nbsp;<a href="Delete.aspx">Delete</a>&nbsp;&nbsp;<a href="listrecords.aspx">List records</a>&nbsp;&nbsp;
  
</asp:Content>
 
