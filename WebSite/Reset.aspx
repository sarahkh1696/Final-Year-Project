<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Reset.aspx.cs" Inherits="Reset" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Resend My Password</title>
    <link rel="stylesheet" type="text/css" href="QTPharmacy.css" />
    <style type="text/css"> .newStyle1 {
            font-family: calibri;
            color: #A80D6A;
        }
        .auto-style1 {
            font-family: calibri;
            color: #A80D6A;
            text-decoration: underline;
        }
        .auto-style2 {
            text-align: center;
            font-weight: normal;
        }
        .newStyle2 {
            font-family: calibri;
        }
        .newStyle3 {
            font-family: calibri;
            color: #A80D6A;
        }
        .newStyle4 {
            font-family: calibri;
        }
        .newStyle5 {
            font-family: calibri;
            color: #A80D6A;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    
        <asp:Panel ID="Panel1" runat="server" BorderStyle="Ridge" 
        style="top: 25px; left: 21px; position: absolute; height: 507px; width: 1216px" BackColor="#d3e5f0">
                    <h1 class="auto-style2">
                        &nbsp;<span class="auto-style1">Reset My Password </span>
                    </h1>
            <asp:Label ID="lblError" runat="server" 
                style="z-index: 1; left: 29px; top: 416px; position: absolute; width: 842px; font-weight: 700;" Font-Names="Calibri" Font-Size="Medium" CssClass="newStyle5"></asp:Label>

                    <asp:Button ID="btnDone" runat="server" Font-Names="Calibri" Font-Size="Medium" OnClick="btnDone_Click" style="z-index: 1; left: 772px; top: 407px; position: absolute; width: 128px; height: 33px;" Text="Done" />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <asp:Button ID="btnResetPassword" runat="server" Font-Names="Calibri" Font-Size="Medium" OnClick="btnResetPassword_Click" style="z-index: 1; left: 189px; top: 238px; position: absolute; width: 422px" Text="Reset my password" />
                    <br />
                    <asp:Label ID="lblEmail" runat="server" Font-Names="Calibri" style="z-index: 1; left: 134px; top: 145px; position: absolute; width: 129px" Text="Email Address"></asp:Label>
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="newStyle4" Font-Names="Calibri" Font-Size="Medium" style="z-index: 1; left: 274px; top: 143px; position: absolute; width: 284px"></asp:TextBox>

        </asp:Panel>
        </form>
</body>
</html>

