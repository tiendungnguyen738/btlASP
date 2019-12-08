<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="shopASP.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta charset="ISO-8859-1" />
<title>Wellcome Login !</title>

<style type="text/css">
body {
	margin: 0;
	padding: 0;
	background: url(Home/Style/images/computer.jpg);
	background-size: cover;
	background-repeat: no-repeat;
	font-family: sans-serif;
}

.loginbox {
	width: 320px;
	height: 420px;
	background: #650be8;
	color: #fff;
	top: 50%;
	left: 50%;
	position: absolute;
	transform: translate(-50%, -50%);
	box-sizing: border-box;
	padding: 70px 30px;
    border-radius: 15px 15px 15px 15px;
}

.avata {
	width: 100px;
	height: 100px;
	border-radius: 50%;
	position: absolute;
	top: -50px;
	left: calc(50% - 50px);
}

h1 {
	margin: 0;
	padding: 0 0 20px;
	text-align: center;
	font-size: 22px;
}

.loginbox p {
	margin: 0;
	padding: 0;
	font-weight: bold;
}

.loginbox input {
	width: 100%;
	margin-bottom: 20px;
}

.loginbox input[type="text"], input[type="password"] {
	border: none;
	border-bottom: 1px solid #fff;
	background: transparent;
	outline: none;
	height: 40px;
	color: #fff;
	font-size: 16px;
}

.loginbox input[type="submit"] {
	border: none;
	outline: none;
	height: 40px;
	background: #fb2525;
	color: #fff;
	font-size: 18px;
	border-radius: 20px;
}

.loginbox input[type="submit"]:hover {
	cursor: pointer;
	background: #ffc107;
	color: #000;
}

.loginbox a {
	text-decoration: none;
	font-size: 12px;
	line-height: 20px;
	color: darkgray;
}

.loginbox a:hover {
	color: #ffc107;
}

</style>
</head>
<body>
	<div class="loginbox">
		<img src="Home/Style/images/login.png" alt="avata" class="avata"/>
		<h1>Login Here</h1>
		<form id="form1" method="post" runat="server">
			<p>Username</p>
            <asp:TextBox ID="txtusername" runat="server" placeholder="Enter Username"></asp:TextBox>
			<p>Password</p>
            <asp:TextBox ID="txtpassword" runat="server" placeholder="Enter Password" type="password"></asp:TextBox>
            <br />
            <asp:Label ID="errg" runat="server" Text="" ForeColor="Red" Font-Italic="true"></asp:Label>
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"/>
            <a href="#">Lost your password?</a>
            <br /> 
            <a href="web/register.aspx">Don't have an acount</a>
		</form>
	</div>
</body>
</html>

