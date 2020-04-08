<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Patients.aspx.cs" Inherits="Patients" %>

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
            top: 93%;
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
            Patients
        </strong>
        </header>
        <article class="auto-style9"> 
             <table>
        <tr>
            <td class="auto-style5">
                <br />
                <br />
                <asp:Label ID="lblPatientID" runat="server" Text="Patient ID:" Width="200px" CssClass="newStyle6"></asp:Label>
                <asp:TextBox ID="txtPatientID" runat="server" OnTextChanged="txtPatientID_TextChanged1" CssClass="newStyle1" Width="174px"></asp:TextBox>
                <br />
                <asp:Label ID="lblFirstName" runat="server" Text="First Name:" Width="200px" CssClass="newStyle7"></asp:Label>
                <asp:TextBox ID="txtFirstName" runat="server" OnTextChanged="txtFirstName_TextChanged" CssClass="newStyle1" Width="174px"></asp:TextBox>
                <br />
                <asp:Label ID="lblLastName" runat="server" Text="Last Name:" Width="200px" CssClass="newStyle8"></asp:Label>
                <asp:TextBox ID="txtLastName" runat="server" CssClass="newStyle1" Width="174px"></asp:TextBox>
                <br />
                <asp:Label ID="lblAddressLn" runat="server" Text="Address Line :" Width="200px" CssClass="newStyle9"></asp:Label>
                <asp:TextBox ID="txtAddressLn" runat="server" CssClass="newStyle1" Width="173px"></asp:TextBox>
                <br />
                <asp:Label ID="lblGender" runat="server" Text="Gender:" Width="200px" CssClass="newStyle10"></asp:Label>
                <asp:DropDownList ID="ddlGender" runat="server" AutoPostBack="True" CssClass="newStyle27">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:DropDownList>
                <br />
                <asp:Label ID="lblAge" runat="server" Text="Age:" Width="200px" CssClass="newStyle20"></asp:Label>
                <asp:TextBox ID="txtAge" runat="server" Width="128px" CssClass="newStyle27"></asp:TextBox>
                <br />
                <asp:Label ID="lblContactNo" runat="server" Text="Contact No:" Width="200px" CssClass="newStyle19"></asp:Label>
                <asp:TextBox ID="txtContactNo" runat="server" Width="174px" CssClass="newStyle27"></asp:TextBox>
                <br />
                <asp:Label ID="lblDateAdded" runat="server" Text="Date Added:" Width="149px" CssClass="newStyle18"></asp:Label>

                <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtDateAdded" runat="server" Width="173px" CssClass="newStyle27"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
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
                <asp:LinkButton ID="LinkButton7" runat="server" CssClass="newStyle4" OnClick="LinkButton7_Click">Payments</asp:LinkButton>
                <br />
                <br />
                <asp:LinkButton ID="LinkButton8" runat="server" CssClass="newStyle4" OnClick="LinkButton8_Click">Consultants</asp:LinkButton>
                <br />
                <br /> 
                <asp:LinkButton ID="LinkButton9" runat="server" CssClass="newStyle24" OnClick="LinkButton9_Click">Drugs</asp:LinkButton>
            </nav>
        <footer class="auto-style3">
                <span class="newStyle26">Footer text here</span>
       </footer>
            </form>
</body>
</html>
