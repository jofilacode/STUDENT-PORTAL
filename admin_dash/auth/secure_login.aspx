<%@ Page Language="C#" AutoEventWireup="true" CodeFile="secure_login.aspx.cs" Inherits="auth_secure_login" %>

<!DOCTYPE HTML>
<html lang="zxx">

<head>
	<title>Professional Computer Institute (PCI)</title>
	<!-- Meta tag Keywords -->
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<meta charset="UTF-8" />
	<meta name="keywords" content="Online, computer, portal result, printout, sms portal" />
    <link href="../../images/logo.jpg" rel="icon" />
	<script>
		addEventListener("load", function () {
			setTimeout(hideURLbar, 0);
		}, false);

		function hideURLbar() {
			window.scrollTo(0, 1);
		}
	</script>
	<!-- Meta tag Keywords -->

	<!-- css files -->
	<link rel="stylesheet" href="css/style.css" type="text/css" media="all" />
	<!-- Style-CSS -->
	<link href="css/font-awesome.min.css" rel="stylesheet">
	<!-- Font-Awesome-Icons-CSS -->
	<!-- //css files -->

	<!-- web-fonts -->
	<link href="//fonts.googleapis.com/css?family=Source+Sans+Pro:200,200i,300,300i,400,400i,600,600i,700,700i,900,900i&amp;subset=cyrillic,cyrillic-ext,greek,greek-ext,latin-ext,vietnamese"
	 rel="stylesheet">
	<!-- //web-fonts -->
    <style>
        .msg
        {
            padding:8px;
            margin:5px;
            border-radius:10px;
            font-weight:bold;
            font-size:15px;
            text-align:center;
        }
    </style>

    <script>

        $(document).ready(function () {
            setTimeout(fade_out, 5000);

            function fade_out() {
                $(".msg").fadeOut(1000).empty();
            }

        });
    </script>
</head>

<body>
	<div class="main-bg">
		<!-- title -->
		<h1 style="font-weight:bold;"><imG src="../../images/logo.jpg" alt="lOGO" style="height:50px; width:50px;  padding-top:20px;" /> PCI PORTAL</h1>
		<!-- //title -->
		<!-- content -->
		<div class="sub-main-w3">
			<div class="bg-content-w3pvt">
				<div class="top-content-style">
					<img src="images/user.png" alt="" style="height:50px;width:50px;" />
				</div>
				<form method="post" runat="server" id="form1">

                    <div id="msg" runat="server" class="msg"> </div>
					<p class="legend">Admin Login</p>
					<div class="input">
						<input id="username" runat="server" type="text" placeholder="Username" />
						<span class="fa fa-user"></span>
					</div>
					<div class="input">
						<input id="password" runat="server" type="password" placeholder="Password"   />
						<span class="fa fa-unlock"></span>
					</div>

                   
                    <asp:Button ID="Button1" runat="server" Text="Login your account" style="padding:10px; font-weight:bold; border:0; border-radius:10px; background:  #3498db; color:#fff; width:95%; cursor:pointer;" OnClick="login_admin"  />
				</form>
				
			</div>
		</div>
		<!-- //content -->
		<!-- copyright -->
		<div class="copyright">
			<h2>&copy; PCI PORTAL
				
			</h2>
		</div>
		<!-- //copyright -->
	</div>
</body>

</html>
