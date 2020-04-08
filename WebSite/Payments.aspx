<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Payments.aspx.cs" Inherits="Payments" %>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>Payments</title>
    <link href="QTPharmacy.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .newStyle1 {
            font-family: calibri;
        }
        .newStyle2 {
            color: #A80D6A;
            text-decoration: underline;
            font-family: calibri;
        }
        .auto-style1 {
            color: #A80D6A;
            text-decoration: underline;
            font-family: calibri;
            text-align: center;
            left: 0%;
            top: 0%;
            height: 11%;
        }
        .newStyle3 {
            font-size: large;
        }
        .auto-style2 {
            left: -1%;
            top: 8%;
            width: 21%;
            height: 80%;
        }
        .newStyle4 {
            font-family: calibri;
            font-size: medium;
            color: #000000;
        }
        .newStyle5 {
            font-family: calibri;
            font-weight: normal;
            font-style: inherit;
            color: #808080;
            text-decoration: blink;
            font-size: medium;
        }
        .newStyle6 {
            font-family: calibri;
        }
        .newStyle7 {
            font-family: calibri;
        }
        .newStyle8 {
            font-family: calibri;
        }
        .newStyle9 {
            font-family: calibri;
        }
        .newStyle10 {
            font-family: calibri;
        }
        .newStyle11 {
            font-family: calibri;
        }
        .newStyle12 {
            font-family: calibri;
        }
        .auto-style4 {
            width: 559px;
            height: 267px;
        }
        .newStyle13 {
            font-family: calibri;
        }
        .newStyle14 {
            font-family: calibri;
        }
        .newStyle15 {
            font-family: calibri;
        }
        . {
            font-family: calibri;
        }
        .auto-style5 {
            height: 267px;
            width: 488px;
        }
        .newStyle16 {
            color: #000000;
        }
        .auto-style9 {
            left: 20%;
            top: 12%;
        }
        .newStyle17 {
            color: #800000;
            font-family: calibri;
        }
        .auto-style10 {
            margin-top: 6px;
        }
        .newStyle18 {
            font-family: calibri;
        }
        .newStyle19 {
            font-family: calibri;
        }
        .newStyle20 {
            font-family: calibri;
        }
        .newStyle21 {
            font-family: calibri;
        }
        .newStyle22 {
            color: #000000;
        }
        .newStyle23 {
            font-family: calibri;
        }
        .newStyle24 {
            font-family: calibri;
            color: #000000;
        }
        .newStyle25 {
            font-family: calibri;
            color: #A80D6A;
        }
        .auto-style11 {
            left: 0%;
            top: 90%;
        }
        .newStyle26 {
            font-family: calibri;
        }
        .newStyle27 {
            font-family: calibri;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        
        <header class="auto-style1"> 
            <strong class="newStyle3">
            <br />
            Payments
        </strong>
        </header>
        <article class="auto-style9"> 
             <table>
        <tr>
            <td class="auto-style5">
                <br />
                <br />
                <asp:Label ID="lblPaymentID" runat="server" Text="Payment ID :" Width="200px" CssClass="newStyle9"></asp:Label>
                <asp:TextBox ID="txtPaymentID" runat="server" CssClass="newStyle1" Width="173px"></asp:TextBox>
                <br />
                <asp:Label ID="lblPatientID" runat="server" Text="PatientID:" Width="200px" CssClass="newStyle8"></asp:Label>
                <asp:TextBox ID="txtPatientID" runat="server" CssClass="newStyle1" Width="174px"></asp:TextBox>
                <br />
                <asp:Label ID="lblPaymentType" runat="server" Text="Payment Type:" Width="200px" CssClass="newStyle20"></asp:Label>
                <asp:DropDownList ID="ddlPaymentType" runat="server" AutoPostBack="True" CssClass="newStyle1" Width="70px">
                    <asp:ListItem>Cash</asp:ListItem>
                    <asp:ListItem>Card</asp:ListItem>
                </asp:DropDownList>
                <br />
                <asp:Label ID="lblPaymentDate" runat="server" Text="Payment Date:" Width="200px" CssClass="newStyle10"></asp:Label>
                <asp:TextBox ID="txtPaymentDate" runat="server" CssClass="newStyle1" Width="174px"></asp:TextBox>
                <br />
                <asp:Label ID="lblPrice" runat="server" Text="Price:" Width="200px" CssClass="newStyle19"></asp:Label>
                <asp:TextBox ID="txtPrice" runat="server" Width="174px" CssClass="newStyle27"></asp:TextBox>
                <br />

&nbsp;&nbsp;&nbsp;
                <br />
                <br />
                &nbsp;<br />
                <br />
             <strong>   
                 <asp:Label ID="lblError" runat="server" CssClass="newStyle25" Text="lblError"></asp:Label>
                </strong>
                <br />

            </td>
            <td class="auto-style4">
                &nbsp;<br />
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
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" Width="85px" />
                
                &nbsp;&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="87px" OnClick="btnCancel_Click" CssClass="auto-style10" />

                </table>

        </article>
 <nav class="auto-style2">
                
               
                <br />
                
               
                <asp:LinkButton ID="LinkButton3" runat="server" CssClass="newStyle4" OnClick="LinkButton3_Click">Home</asp:LinkButton>
                <br />
                <br />
                <asp:LinkButton ID="LinkButton4" runat="server" CssClass="newStyle4" OnClick="LinkButton4_Click">View Patients</asp:LinkButton>
                <br />
                <br />
                <asp:LinkButton ID="LinkButton5" runat="server" CssClass="newStyle4" OnClick="LinkButton5_Click">Orders</asp:LinkButton>
                <br />
                <br />
                <asp:LinkButton ID="LinkButton7" runat="server" CssClass="newStyle4" OnClick="LinkButton7_Click">View Payments</asp:LinkButton>
                <br />
                <br />
                <asp:LinkButton ID="LinkButton8" runat="server" CssClass="newStyle4" OnClick="LinkButton8_Click">Consultants</asp:LinkButton>
                <br />
                <br /> 
                <asp:LinkButton ID="LinkButton9" runat="server" CssClass="newStyle24" OnClick="LinkButton9_Click">View Drugs</asp:LinkButton>
            </nav>
            </form>
    <footer class="auto-style11">
                <span class="newStyle26">Footer text here
         </span>
         </footer>
</body>
</html>
