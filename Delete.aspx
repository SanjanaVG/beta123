<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="emppro.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="a">
    <asp:Label ID="Label1" runat="server" Text="Employee Id"></asp:Label>
    &nbsp;<asp:TextBox ID="Eid" runat="server"></asp:TextBox>
        <br />
        <br />
    <asp:Button ID="Button1" runat="server" Text="Delete" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
 </div>
</asp:Content>
