<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="challengeEpicSpiesElectionTracker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style2 {
            font-size: small;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 495px; width: 478px">
    
        <asp:Image ID="logoImage" runat="server" Height="150px" ImageUrl="epic-spies-logo.jpg" Width="100px" />
        <br />
        <h1 class="auto-style1">Asset Performance Tracker</h1>
        <br />
        <span class="auto-style1">Codename of Asset:
        <asp:TextBox ID="assetTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Number of Elections rigged:
        <asp:TextBox ID="electionsTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <dl>
            <dt>Number of acts of Subterfuge performed:&nbsp;
        <asp:TextBox ID="subterfugeTextBox" runat="server"></asp:TextBox></dt>
            <dd style="height: 20px"><span class="auto-style2">(i.e. ballot tampering, voter fraud, hacking, spreading false information, etc.)</span></p>
            </dd>
        </dl>
        <br />
        </span>
        <asp:Button ID="updateButton" runat="server" BackColor="#FFCCFF" BorderColor="#FF0066" BorderStyle="Ridge" BorderWidth="3px" ForeColor="#0033CC" OnClick="updateButton_Click" Text="UPDATE" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
