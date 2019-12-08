<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="shopASP.register" %>

<!DOCTYPE html>
<html lang="en">
<head>
<title>Register now !</title>
<meta name="viewport" content="width=device-width, initial-scale=1">
<meta charset="utf-8">
<meta name="keywords" content="Quick Register Form Responsive, Login form web template, Sign up Web Templates, Flat Web Templates, Login signup Responsive web template, Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design" />
<link href="/Web/css/font-awesome.min.css" rel="stylesheet" type="text/css" media="all">
<link href="/Web/css/style.css" rel="stylesheet" type="text/css" media="all"/>
<link href="//fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i,800,800i&amp;subset=cyrillic,cyrillic-ext,greek,greek-ext,latin-ext,vietnamese" rel="stylesheet">
</head>
<body>
<div class="signupform">
<h1>Quick Register Form</h1>
	<div class="container">
		
		<div class="agile_info">
			<div class="w3_info">
				<h2>Register Here</h2>
						<form runat="server" method="post">
						<div class="left margin">
							<label>Full Name</label>
							<div class="input-group">
								<span><i class="fa fa-user" aria-hidden="true"></i></span>
								<asp:TextBox ID="txtFullname" runat="server" placeholder="Enter Yourname" type="text"></asp:TextBox> 
							</div>
						</div>
						<div class="left">
							<label>Adress</label>
							<div class="input-group">
								<span><i class="fa fa-user" aria-hidden="true"></i></span>
								<asp:TextBox ID="txtAddress" runat="server" placeholder="Enter address"></asp:TextBox> 
							</div>
						</div>
                        <div class="left margin">
							<label>Gender</label>
							<div class="input-group">
								<span><i class="fa fa-user" aria-hidden="true"></i></span>
								<asp:TextBox ID="txtSex" runat="server" placeholder="Enter gender"></asp:TextBox> 
							</div>
						</div>
                        <div class="left">
							<label>IdCard</label>
							<div class="input-group">
								<span><i class="fa fa-user" aria-hidden="true"></i></span>
								<asp:TextBox ID="txtCardId" runat="server" placeholder="Enter idcard "></asp:TextBox>
							</div>
						</div>
						<div class="left margin">
							<label>Email Address</label>
							<div class="input-group">
								<span><i class="fa fa-envelope" aria-hidden="true"></i></span>
								<asp:TextBox ID="txtEmail" runat="server" placeholder="Enter Email"></asp:TextBox>
							</div>
						</div>
						<div class="left">
							<label>User Name</label>
							<div class="input-group">
								<span><i class="fa fa-user" aria-hidden="true"></i></span>
								 <asp:TextBox ID="txtUsername" runat="server" placeholder="Enter Username"></asp:TextBox> 
							</div>
						</div>
						<div class="left margin">
							<label>Password</label>
							<div class="input-group">
								<span><i class="fa fa-lock" aria-hidden="true"></i></span>
								<asp:TextBox ID="txtPassword" runat="server" placeholder="Enter Password" type="password"></asp:TextBox>
							</div>
						</div>
						<div class="left">
							<label>Confirm Password</label>
							<div class="input-group">
								<span><i class="fa fa-lock" aria-hidden="true"></i></span>
								<asp:TextBox ID="txtConfirm" runat="server" placeholder="Enter Confirm Password" type="password"></asp:TextBox>
							</div>
						</div>
						<div class="clear"></div>
							<asp:Label ID="errg" runat="server" Text="" Font-Italic="true" ForeColor="Red"></asp:Label>      
                            <asp:Button ID="btnThem" runat="server" Text="Register Now" class="btn btn-danger btn-block" OnClick="btnThem_Click"/>
					</form>
			</div>
			<div class="w3l_form">
				<div class="left_grid_info">
					<h3>Already Registered?</h3>
					<p> Nam eleifend velit eget dolor vestibulum ornare. Vestibulum est nulla, fermentum eget euismod et, tincidunt at dui. Nulla tellus nisl, semper id justo vel, rutrum finibus risus. Cras vel auctor odio.</p>
					<a href="/login.aspx" class="btn">Login <i class="fa fa-long-arrow-right" aria-hidden="true"></i></a>
				</div>
			</div>
			<div class="clear"></div>
			</div>
			
		</div>		
    <div class="footer">
        <p>&copy; 2018 Quick Register form. All Rights Reserved | Design by Khang ^^</p>
    </div>
	</div>
	</body>
</html>
