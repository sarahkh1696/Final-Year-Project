<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign up for a new Account</title>
    <link rel="stylesheet" type="text/css" href="QTPharmacy.css" />
    <style type="text/css">
        .newStyle1 {
            font-family: calibri;
            color: #800000;
        }
        .auto-style1 {
            font-family: calibri;
            color: #800000;
            font-weight: normal;
            text-decoration: underline;
        }
        .newStyle2 {
            font-family: calibri;
        }
        .newStyle3 {
            color: #A80D6A;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    
        <asp:Panel ID="Panel1" runat="server" BorderStyle="Solid" 
        style="top: 26px; left: 11px; position: absolute; height: 544px; width: 1229px" BackColor="#D3E5F0">
            <h1>
                &nbsp;&nbsp; <span class="auto-style1">Create a New Account </span>&nbsp;</h1>
            <asp:Label ID="lblFirstName" runat="server" 
                style="z-index: 1; left: 134px; top: 100px; position: absolute; width: 98px" 
                Text="First Name" Font-Names="Calibri" Font-Size="Medium"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server" 
                
                style="z-index: 1; left: 292px; top: 100px; position: absolute; width: 220px" CssClass="newStyle2"></asp:TextBox>
            <asp:Label ID="lblLastName" runat="server" 
                style="z-index: 1; left: 134px; top: 141px; position: absolute; width: 102px" 
                Text="Last Name" Font-Names="Calibri" Font-Size="Medium"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server" 
                
                style="z-index: 1; left: 293px; top: 138px; position: absolute; width: 220px" CssClass="newStyle2"></asp:TextBox>
            <asp:Label ID="lblEmail" runat="server" 
                style="z-index: 1; left: 134px; top: 185px; position: absolute; width: 145px" 
                Text="Email Address" Font-Names="Calibri" Font-Size="Medium"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" 
                
                style="z-index: 1; left: 293px; top: 182px; position: absolute; width: 220px" CssClass="newStyle2"></asp:TextBox>
            <asp:Button ID="btnResetPassword" runat="server" 
                style="z-index: 1; left: 650px; top: 168px; position: absolute; width: 276px" 
                Text="Reset my password" OnClick="btnPassword_Click" Font-Names="Calibri" Font-Size="Medium" />
            <asp:Label ID="lblPassword" runat="server" 
                style="z-index: 1; left: 134px; top: 227px; position: absolute; width: 104px" 
                Text="Password" Visible="False" Font-Names="Calibri" Font-Size="Medium"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" 
                style="z-index: 1; left: 292px; top: 229px; position: absolute; width: 220px; height: 23px;" 
                Visible="False" TextMode="Password" CssClass="newStyle2"></asp:TextBox>
            <asp:Label ID="lblError" runat="server" 
                
                
                style="z-index: 1; left: 20px; top: 462px; position: absolute; width: 844px; font-weight: 700;" Font-Names="Calibri" Font-Size="Medium" CssClass="newStyle3"></asp:Label>
            <asp:Button ID="btnDone" runat="server" Font-Names="Calibri" Font-Size="Medium" OnClick="btnDone_Click" style="z-index: 1; left: 734px; top: 459px; position: absolute; width: 128px" Text="Done" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCreateAccount" runat="server" Height="53px" OnClick="btnCreateAccount_Click" Text="Create Account" Width="201px" />
        </asp:Panel>
        </form>
</body>
</html>

