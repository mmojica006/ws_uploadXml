<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<style type="text/css">
    html{
        background-color:white;
    }
    body{
        background-color:#2196F3;
    }

</style>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="TESTING WEBSERVICE"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnLlamar" runat="server" OnClick="btnLlamar_Click" Text="llamar WS" />
    
    </div>
    </form>
</body>
</html>
