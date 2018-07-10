<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rename_user.aspx.cs" Inherits="Dz1_zad1.Rename_user" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="style.css" rel="stylesheet" />
    <link href='https://fonts.googleapis.com/css?family=Open+Sans:400,300,300italic,400italic,600,600italic,700,700italic' rel='stylesheet' type='text/css'>
    <title></title>
</head>
<body class="body_form">
<form class="form1" id="form1" runat="server" >
    <div class="div_rename">
        <div class="div_img">
            <img src="images/Logo1.png"/>
        </div>
        <asp:Label CssClass="Label_form" ID="Label2" runat="server" Text="Логин: "></asp:Label>
            
        <asp:TextBox CssClass="input_form" ID="TextBox1_Log" runat="server"></asp:TextBox>
            
        <asp:Label CssClass="Label_form" ID="Label3" runat="server" Text="Пароль: "></asp:Label>
            
        <asp:TextBox CssClass="input_form" ID="TextBox2_Pasvord" runat="server"></asp:TextBox>
           
        <asp:Label CssClass="Label_form" ID="lable4" runat="server" Text="Уровень доступа:"></asp:Label>
            
        <asp:DropDownList CssClass="Uroven_form" ID="DropDownList11" runat="server" BackColor="#052530" ForeColor="White">
            <asp:ListItem Text="Пользователь" Value="1" Selected="true" />
            <asp:ListItem Text="Редактор" Value="2"  />
            <asp:ListItem Text="Администратор" Value="3"  />
            <asp:ListItem Text="СуперПользователь" Value="4" />
        </asp:DropDownList>
        <br/>
        <asp:Button CssClass="button_add" ID="Button11" runat="server" Text="Сохранить" OnClick="Button11_OnClick" />
        <asp:HyperLink CssClass="link_button" ID="HyperLink11" runat="server">Перейти к таблице</asp:HyperLink>
        <br/>
    </div>
</form>
</body>
</html>
