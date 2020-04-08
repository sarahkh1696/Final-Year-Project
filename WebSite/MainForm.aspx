<%@ Page Title="" Language="C#" MasterPageFile="~/QTPharmacyMasterPage.master" AutoEventWireup="true" CodeFile="MainForm.aspx.cs" Inherits="MainForm" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="height: 38px; width: 1200px;">
        <tr>
            <td style="height: 30px; width: 1036px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            </td>
        </tr>
    </table>
    <div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="imgbtnPatients" runat="server" Height="152px" ImageUrl="~/Pictures/patient.png" OnClick="imgbtnPatients_Click" Width="162px" />
&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="imgbtnDrugs" runat="server" Height="152px" ImageUrl="~/Pictures/drug.png" OnClick="imgbtnDrugs_Click" Width="162px" />
    &nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="imgbtnConsultants" runat="server" Height="152px" ImageUrl="~/Pictures/consultnts.png" OnClick="imgbtnConsultants_Click" Width="162px" />
    &nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="imgbtnOrders" runat="server" Height="152px" ImageUrl="~/Pictures/orders.png" OnClick="imgbtnOrders_Click" Width="162px" />
    &nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="imgbtnPayments" runat="server" Height="152px" ImageUrl="~/Pictures/payments.png" OnClick="imgbtnPayments_Click" Width="162px" />
    </div class="dropdown">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
  <div id="myDropdown" class="dropdown-content">
    <a href="#">Add Patient</a>
    <a href="#">Add Drug</a>
    <a href="#">Add Consultant</a>

  </div>
     <nav class="auto-style2">
                <span class="newStyle2">
                <br />
                </span>
                <span class="newStyle6">
                <br />
                </span>
                <asp:LinkButton ID="LinkButton3" runat="server" CssClass="newStyle13" OnClick="LinkButton3_Click">Log In</asp:LinkButton>
                <span class="newStyle6">
                <br />
                <br />
                </span>
                <asp:LinkButton ID="LinkButton4" runat="server" CssClass="newStyle12" OnClick="LinkButton4_Click">Sign Up</asp:LinkButton>
                <span class="newStyle6">
                <br />
                <br />
                </span>
                <asp:LinkButton ID="LinkButton5" runat="server" CssClass="newStyle11" OnClick="LinkButton5_Click">Re-Set Password</asp:LinkButton>
                <br />
                <br />
         </nav>
    &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <br />
    <br />
    <br />

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
    <br />
</asp:Content>