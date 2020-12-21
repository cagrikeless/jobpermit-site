<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="jobpermit_site.login" %>

<!DOCTYPE html>
<html>

<head>
    <title>OPTiiM | Web Application</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="keywords" content=" Master  Login Form Widget Tab Form,Login Forms,Sign up Forms,Registration Forms,News letter Forms,Elements" />
    <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
    <link href="web/css/style.css" rel="stylesheet" type="text/css" media="all" />
    <link href="//fonts.googleapis.com/css?family=Cormorant+SC:300,400,500,600,700" rel="stylesheet">
    <link href="//fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i,800,800i" rel="stylesheet">
</head>

<body>
    <div class="padding-all">
        <div class="header">
            <h1>OpTiiM Job Permit Login</h1>
        </div>

        <div class="design-w3l">
            <div class="mail-form-agile">
                <form action="#" method="post" runat="server">
                    <asp:TextBox runat="server" ID="txt_UsernameorEmail" placeholder="Username or Email..." required=""></asp:TextBox>
                    <asp:TextBox runat="server" ID="txt_Password" placeholder="********" required="" TextMode="Password" CssClass="padding"></asp:TextBox>
                    <asp:Button runat="server" ID="btn_Submit" Text="Login" OnClick="btn_Submit_Click" />
                </form>
            </div>
            <div class="clear"></div>
        </div>
        <div class="footer">
            <p>Copyright 2020 OPTiiM. All rights reserved.</p>
        </div>
    </div>
</body>
</html>
