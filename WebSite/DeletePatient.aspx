<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeletePatient.aspx.cs" Inherits="DeletePatient" %>

<!DOCTYPE html>
<script runat="server">

</script>


<html>
<head id="Head1" runat="server">
    <title></title>
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
            top: 7%;
            width: 21%;
            height: 77%;
        }
        .newStyle4 {
            font-family: calibri;
            font-size: medium;
            color: #000000;
        }
        .auto-style3 {
            left: 0%;
            top: 90%;
            height: 12%;
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
        .newStyle16 {
            font-family: calibri;
            color: #000000;
        }
        .newStyle17 {
            font-family: calibri;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        
        <header class="auto-style1"> 
            <strong class="newStyle3">
            <br />
        </strong>
        </header>
        <article> 
       
            <td class="auto-style5">
            </tr>
                <br />
                 <br />
       
            </td>
            <td class="auto-style4">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblMessage" runat="server" Text="Are sure you want to delete this record?" CssClass="newStyle17"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;<br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
               
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnYes" runat="server" Text="Yes" CssClass="auto-style7" OnClick="btnYes_Click" Width="90px" />
                
                &nbsp;
                
                <asp:Button ID="btnNo" runat="server" Text="No" CssClass="auto-style8" Width="94px" OnClick="btnNo_Click" />
                       

        </article>

        <nav class="auto-style2">
                
                <br />
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
                <asp:LinkButton ID="LinkButton7" runat="server" CssClass="newStyle4" OnClick="LinkButton7_Click">Payments</asp:LinkButton>
                <br />
                <br />
                <asp:LinkButton ID="LinkButton8" runat="server" CssClass="newStyle4" OnClick="LinkButton8_Click">Consultants</asp:LinkButton>
                <br />
                <br />
                <asp:LinkButton ID="LinkButton9" runat="server" CssClass="newStyle16" OnClick="LinkButton9_Click">Drugs</asp:LinkButton>
                <br />
                <br />
            </nav>
        <footer class="auto-style3">
                Footer text here
                </footer>
    </form>
</body>
</html>