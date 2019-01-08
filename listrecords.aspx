<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="listrecords.aspx.cs" Inherits="emppro.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <a href="admin.aspx">Back</a> 
<div class="a">
    <h2>Employee records</h2>
    <p>Sort by <asp:DropDownList ID="DropDownList1" runat="server">
         <asp:ListItem Value="EmpId" Selected="False">Employee Id</asp:ListItem>
        <asp:ListItem Value="EmpName" Selected="False">Employee Name</asp:ListItem>
        </asp:DropDownList>
    </p>
    <asp:DataGrid ID="DataGrid1" runat="server"  Width="96%" CssClass="auto-style1" Height="217px" style="margin-left: 19px; margin-top: 109px;" AllowSorting="true">
        <Columns>
                                  <asp:BoundColumn HeaderText="EmpId" 
                                                   SortExpression="EmpId" />
             <asp:BoundColumn HeaderText="EmpName" 
                                                   SortExpression="EmpName" />


        </Columns>
    </asp:DataGrid>
    <br />
    <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label>
</div>
</asp:Content>
