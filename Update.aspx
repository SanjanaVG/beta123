<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="emppro.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1
        {
            margin-left:10px;
        }
        
        .auto-style2 {
            height: 56px;
        }
        
        </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="c">
        <a href="admin.aspx">Back</a>
    </div>
    <br />
    <table class="auto-style1">
<tr>
    <td><asp:Label ID="Label1" runat="server" Text="Employee ID"></asp:Label></td>
    <td><asp:TextBox ID="TxtEmpId" runat="server" CssClass="auto-style1" ReadOnly></asp:TextBox></td>

    <td><asp:Label ID="Label2" runat="server" Text="Employee Name"></asp:Label></td>
    <td><asp:TextBox ID="TxtEmpName" runat="server" CssClass="auto-style1"></asp:TextBox></td>
  
    <td><asp:Label ID="Label3" runat="server" Text="Date of Birth"></asp:Label></td>
    <td><asp:TextBox ID="TxtDob" runat="server" CssClass="auto-style1"></asp:TextBox></td>
 
</tr>
<tr><td class="auto-style2"><asp:Label ID="Label13" runat="server" Text="Gender"></asp:Label></td>
    <td class="auto-style2"><asp:RadioButtonList ID="RadioButtonList1" runat="server" CssClass="auto-style2" Height="16px" Width="130px">
    <asp:ListItem text="Female" Value="Female"></asp:ListItem>
    <asp:ListItem text="Male" Value="Male"></asp:ListItem>
    </asp:RadioButtonList></td>
    <td class="auto-style2"><asp:Label ID="Label5" runat="server" Text="Contact No."></asp:Label></td>
    <td class="auto-style2"><asp:TextBox ID="TxtContact" runat="server" TextMode="Phone" CssClass="auto-style1"></asp:TextBox></td>
    <td class="auto-style2"><asp:Label ID="Label6" runat="server" Text="Email ID"></asp:Label></td>
    <td class="auto-style2"><asp:TextBox ID="TxtEmail" runat="server" TextMode="Email" CssClass="auto-style1"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TxtEmail" ErrorMessage="Enter valid EmailId" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td>
</tr>

<tr><td><asp:Label ID="Label7" runat="server" Text="Date of Joining"></asp:Label></td>
    <td><asp:TextBox ID="TxtDoj" runat="server" CssClass="auto-style1"></asp:TextBox></td>
   
    <td><asp:Label ID="Label8" runat="server" Text="Department"></asp:Label></td>
    <td><asp:TextBox ID="TxtDept" runat="server" CssClass="auto-style1"></asp:TextBox></td>

    <td><asp:Label ID="Label9" runat="server" Text="Designation"></asp:Label></td>
    <td><asp:TextBox ID="TxtDesi" runat="server" CssClass="auto-style1"></asp:TextBox></td></tr>
    
<tr><td><asp:Label ID="Label10" runat="server" Text="Salary"></asp:Label></td>
    <td><asp:TextBox ID="TxtSal" runat="server" TextMode="Number" CssClass="auto-style1"></asp:TextBox></td>
    
    <td><asp:Label ID="Label11" runat="server" Text="Password"></asp:Label></td>
    <td><asp:TextBox ID="TxtPass" runat="server" CssClass="auto-style1"></asp:TextBox></td>
    
    <td><asp:Label ID="Label12" runat="server" Text="Role ID"></asp:Label></td>
    <td><asp:TextBox ID="TxtRoleId" runat="server" TextMode="Number" CssClass="auto-style1"></asp:TextBox></td></tr>
    </table>
    <br />
    <div class="a">
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Text="Reset" OnClick="Button2_Click" />
    <br />
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblMsg" runat="server"></asp:Label>
    </div>
</asp:Content>
