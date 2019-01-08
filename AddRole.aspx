<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddRole.aspx.cs" Inherits="emppro.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <a href="admin.aspx">Back</a>
    <div class="a">
    <asp:Label ID="Label1" runat="server" Text="Role Id"></asp:Label>
    &nbsp;
    <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
    <br /><br />
    <asp:Label ID="Label2" runat="server" Text="Role"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="width: 37px" Text="Add" />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
        </div>
</asp:Content>
