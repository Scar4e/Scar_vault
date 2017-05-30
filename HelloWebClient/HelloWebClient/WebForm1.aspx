<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HelloWebClient.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 345px;
            width: 430px;
        }
        .auto-style1 {
            height: 29px;
        }
    </style>
</head>
<body style="width: 402px; height: 291px;">
    <form id="form1" runat="server">
        <table>
            <tr>
               <td>
                   <asp:Label ID="ID_Label" runat="server" Font-Bold="True" Text="ID"></asp:Label>
                     <asp:TextBox ID="ID_TextBox" runat="server" style="margin-left: 167px" Width="170px"></asp:TextBox>
               </td> 
            </tr>
             <tr>
               <td>
                   <asp:Label ID="Name_Label" runat="server" Font-Bold="True" Text="Name"></asp:Label>
                     <asp:TextBox ID="Name_TextBox" runat="server" style="margin-left: 145px" Width="170px"></asp:TextBox>
               </td> 
            </tr>
             <tr>
               <td>
                   <asp:Label ID="Gender_Label" runat="server" Font-Bold="True" Text="Gender"></asp:Label>
                     <asp:TextBox ID="Gender_TextBox" runat="server" style="margin-left: 133px" Width="170px" ></asp:TextBox>
               </td> 
            </tr>
             <tr>
               <td>
                   <asp:Label ID="DateOfBirth_Label" runat="server" Font-Bold="True" Text="Date Of Birth"></asp:Label>
                     <asp:TextBox ID="DateOfBirth_TextBox" runat="server" style="margin-left: 91px" Width="170px"></asp:TextBox>
               </td> 
            </tr>
             <tr>
               <td class="auto-style1">
                   <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Datatype"></asp:Label>
                     <asp:DropDownList ID="DropDownList1" runat="server"     Height="25px" style="margin-left: 122px" Width="176px"
                          OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">    
                          <asp:ListItem Text="Select Data Type" value="-1"></asp:ListItem>
                         <asp:ListItem Text="Fulltime Data Type" value="1"></asp:ListItem>
                         <asp:ListItem Text="Parttime Data Type" value="2"></asp:ListItem>
             </asp:DropDownList>
               </td> 
            </tr>
             <tr id="trAnnualSalary" runat="server" visible="false">
               <td>
                   <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="AnnualSalary"></asp:Label>
                     <asp:TextBox ID="AnnualSalary_TextBox" runat="server" style="margin-left: 91px" Width="170px"></asp:TextBox>
               </td> 
            </tr>
            <tr id="trHourlyPay" runat="server" visible="false">
               <td>
                   <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="HourlyPay"></asp:Label>
                     <asp:TextBox ID="HourlyPay_TextBox" runat="server" style="margin-left: 110px" Width="170px"></asp:TextBox>
               </td> 
            </tr>
            <tr id="trHoursWorked" runat="server" visible="false">
               <td>
                   <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="HoursWorked"></asp:Label>
                     <asp:TextBox ID="HoursWorked_TextBox" runat="server" style="margin-left: 86px" Width="170px"></asp:TextBox>
               </td> 
            </tr>
        </table>
        
      
        <asp:Button ID="GetEmpButton" runat="server" Font-Bold="True" OnClick="GetEmp" style="margin-left: 29px; margin-top: 13px" Text="GetEmloyee" Width="126px" />
        <asp:Button ID="InsEmpButton" runat="server" Font-Bold="True" OnClick="InsEmp" style="margin-left: 54px" Text="SaveEmployee" Width="121px" />
        
      
        <p style="margin-left: 7px; margin-top: 40px">
            <asp:Label ID="StatusCheck_Label" runat="server" Font-Bold="True" ForeColor="#33CC33"></asp:Label>
        </p>
        
      
    </form>
</body>
</html>
