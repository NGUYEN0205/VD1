<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dangnhap.aspx.cs" Inherits="VD1.dangnhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input id="tendn" type="text" name="tendk" size="30" methor="post" value="" required/>
            <input id="mk" type="password" name="mk" size="30" methor="post" value="" required/><br />
            <input type="submit" id="btn" methor ="post" value="Dang ky"/><br />
        </div>
    </form>
    <script>
        function Btn2_Click() {
            Response.Redirect("dangnhap2.aspx");
        }
    </script>
</body>
</html>
