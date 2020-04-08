<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewPatients.aspx.cs" Inherits="ViewPatients" %>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>Patients</title>
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
        .auto-style3 {
            left: 0%;
            top: 94%;
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
        .auto-style9 {
            z-index: 1;
            left: 43px;
            top: 33px;
            position: absolute;
            height: 312px;
            width: 324px;
        }
        .newStyle16 {
            font-family: calibri;
        }
        .newStyle17 {
            font-family: calibri;
            color: #808080;
        }
        .newStyle18 {
            color: #800000;
        }
        .newStyle19 {
            color: #000000;
        }
        .auto-style10 {
            left: 20%;
            top: 12%;
        }
        .newStyle20 {
            font-family: calibri;
            color: #A80D6A;
        }
        .newStyle21 {
            font-family: calibri;
            color: #000000;
        }
        .newStyle22 {
            font-family: calibri;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        
        <header class="auto-style1"> 
            <strong class="newStyle3">
            <br />
            View
            Patients
      </strong>
        
        </header>
        <article class="auto-style10"> 
                 <asp:ListBox ID="lstPatients" runat="server" OnSelectedIndexChanged="lstPatients_SelectedIndexChanged" CssClass="auto-style9"></asp:ListBox>
        
            <td class="auto-style5">
               
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                 <br />
       
            <td class="auto-style4">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 </td>
                <br />
               

                 <br />
     
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     
                <br />
                
                &nbsp;
                &nbsp;&nbsp;&nbsp;
                 <br />
                 <br />
                 <br />
                 <br />
                 <br />
                 <br />
                 <br />
                 <br />
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <br />
                 <br />
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:Button ID="btnAdd" runat="server" Text="Add" CssClass="auto-style7" OnClick="btnAdd_Click" Width="90px" />
                <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="auto-style8" Width="94px" OnClick="btnUpdate_Click" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="93px" OnClick="btnDelete_Click" />

                 <br />
                 <strong>
                 &nbsp;&nbsp;
                 <br />
&nbsp;
                 <asp:Label ID="lblError" runat="server" CssClass="newStyle20" Text="lblError"></asp:Label>
                 </strong>

                 <br />

        </article>

        <nav class="auto-style2">
                
                <br />
                <br />
                <asp:LinkButton ID="LinkButton3" runat="server" CssClass="newStyle4" OnClick="LinkButton3_Click">Home</asp:LinkButton>
                <br />
                <br />
                <asp:LinkButton ID="LinkButton4" runat="server" CssClass="newStyle4" OnClick="LinkButton4_Click">Patients</asp:LinkButton>
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
                <asp:LinkButton ID="LinkButton9" runat="server" CssClass="newStyle21" OnClick="LinkButton9_Click">Drugs</asp:LinkButton>
                <br />
                <br />
            </nav>
        <footer class="auto-style3">
                <span class="newStyle22">Footer text here</span>
                </footer>
    </form>
</body>
</html>

