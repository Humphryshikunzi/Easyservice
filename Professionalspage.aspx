<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" Async="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 150px;
        }
    </style>
</head>
<body>
<form id="form1" runat="server">
    <!-- <div>
        <h4>Shiks Students Data</h4>
        <asp:ListBox runat="server" ID="NamesListBox1" Height="800" DataTextField="Name" DataValueField="Name"/>
    </div>-->
   
    <table>
        <tr>
            <td class="auto-style1">Names</td>
            <td>Registration Numbers</td>
            <td>National Ids</td>
            <td>Remaining Fee Balances</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:ListBox runat="server" ID="NamesListBox" Height="800" DataTextField="Name" DataValueField="Name"/>
            </td>
            <td class="auto-style1">
                <asp:ListBox runat="server" ID="RegNumbersListBox" Height="800" DataTextField="RegistrationNumber" DataValueField="RegistrationNumber"/>
            </td>
            <td class="auto-style1">
                <asp:ListBox runat="server" ID="NationalIdListBox" Height="800" DataTextField="NationalIdentification" DataValueField="NationalIdentification"/>
            </td>
            <td class="auto-style1">
                <asp:ListBox runat="server" ID="RemainFeeBalListBox" Height="800" DataTextField="Remainingfeebalance" DataValueField="Remainingfeebalance"/>
            </td>
        </tr>
     
    </table>

</form>
</body>
</html>
