<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Table.aspx.cs" Inherits="Dz1_zad1.Table" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="style.css" rel="stylesheet" />
    <link href='https://fonts.googleapis.com/css?family=Open+Sans:400,300,300italic,400italic,600,600italic,700,700italic' rel='stylesheet' type='text/css'>
    <title></title>
</head>
<body class="body_table">
    <form class="form_table" id="form1" runat="server">
        <div class="div_table">
            <asp:Table ID="Table1" runat="server">
                <asp:TableRow CssClass="row_glob">
                    <asp:TableCell runat="server">Id</asp:TableCell>
                    <asp:TableCell runat="server">Логин</asp:TableCell>
                    <asp:TableCell runat="server">Пароль</asp:TableCell>
                    <asp:TableCell runat="server">Уровень доступа</asp:TableCell>
                    <asp:TableCell runat="server">Редактировать</asp:TableCell>
                    <asp:TableCell runat="server">Удалить</asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
        <asp:HyperLink CssClass="link_table" ID="HyperLink2" runat="server">Перейти к форме</asp:HyperLink>
    </form>
</body>
</html>
