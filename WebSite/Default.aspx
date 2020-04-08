<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>QTPharmacy</title>
    <link rel="stylesheet" type="text/css" href="QTPharmacy.css" />
    <style type="text/css">
        .newStyle1 {
            font-family: "Calibri Light";
        }
        .newStyle2 {
            font-family: Calibri;
        }
        .newStyle3 {
            font-family: Calibri;
        }
        .newStyle4 {
            font-family: calibri;
        }
        .newStyle5 {
            font-family: calibri;
            font-weight: 700;
        }
        .newStyle6 {
            font-family: calibri;
        }
        .newStyle7 {
            font-family: calibri;
            margin-left: 0px;
        }
        .newStyle8 {
            background-color: #A80D6A;
            font-family: calibri;
        }
        .newStyle9 {
            background-color: #A80D6A;
            font-family: calibri;
        }
        .newStyle10 {
            background-color: #A80D6A;
            font-family: calibri;
            height: 584px;
        }
        .newStyle11 {
            background-color: #A80D6A;
        }
        .newStyle12 {
            background-color: #A80D6A;
        }
        .newStyle13 {
            font-family: calibri;
        }
        .newStyle14 {
            background-image: url('Pictures/drug.png');
        }
        .newStyle15 {
            background-image: none;
        }
        .newStyle16 {
            background-image: none;
        }
        .newStyle17 {
            background-image: url('Pictures/drug.png');
        }
        .newStyle18 {
            font-family: calibri;
            color: #000066;
        }
        .auto-style1 {
            font-family: calibri;
            color: #000066;
            font-weight: normal;
        }
    </style>
</head>
<body>
    <center>
        <form id="form1" runat="server" class="newStyle17">
        <div class="newStyle9">
            <h1 class="auto-style1">QTPharmacy</h1>
            <h2 class="newStyle8">&nbsp;</h2>
            <h2 class="newStyle8"><span class="newStyle2">Sign-in</span></h2>
            <table>
                <tr>
                    <td><asp:Label ID="lblEmail" runat="server" Text="Email Address" CssClass="newStyle3"></asp:Label></td>
                    <td><asp:TextBox ID="txtEMail" runat="server" Width="250px" Height="25px" CssClass="newStyle13"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblPassword" runat="server" Text="Password" CssClass="newStyle4"></asp:Label></td>
                    <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="250px" Height="25px" CssClass="newStyle13"></asp:TextBox></td>
                </tr>
            </table>
        </div>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnLogIn" runat="server" Text="Log In" Width="195px" Height="40px" OnClick="btnLogIn_Click" CssClass="newStyle6"/>
        &nbsp;<br />
            <br />
        <asp:Button ID="btnSignUp" runat="server" Text="Create a new account" CssClass="newStyle7" OnClick="btnSignUp_Click" Width="308px"/>
            <br />
        &nbsp;&nbsp;&nbsp;
        </form>
    </center>
    <p>
            <asp:Label ID="lblError" runat="server" CssClass="newStyle5"></asp:Label>
            </p>
</body>
</html>

