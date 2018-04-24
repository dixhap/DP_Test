<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Connection.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>
                Name:
            </td>
            <td>
               <asp:TextBox ID="TextName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Email:
            </td>
            <td>
               <asp:TextBox ID="TextEmail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Btn_Submit" runat="server" Text="Click" OnClick="Btn_Submit_Click" />

            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblmesssage" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">

        </asp:GridView>
    </div>
    </form>
</body>
</html>
