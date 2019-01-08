<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" Inherits="emppro.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="a">
    <asp:Label ID="Label1" runat="server" Text="Employee Id"></asp:Label>
    &nbsp;<asp:TextBox ID="empid" runat="server" Text="Ex:10000"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
        </div>
</asp:Content>
 