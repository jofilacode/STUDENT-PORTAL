<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html lang="en">
<head>
<title>Professional Computer Institute (PCI)</title>
<meta name="viewport" content="width=device-width, initial-scale=1">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="keywords" content="Online, computer, portal result, printout, sms portal" />
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
<!-- bootstrap-css -->
<link href="images/logo.jpg" rel="icon" />
<link href="css/bootstrap.css" rel="stylesheet" type="text/css" media="all" />
<!--// bootstrap-css -->
<!-- css -->
<link rel="stylesheet" href="css/style.css" type="text/css" media="all" />
<!--// css -->
<!-- font-awesome icons -->
<link href="css/font-awesome.css" rel="stylesheet"> 
<!-- //font-awesome icons -->
<!-- font -->
<link href="//fonts.googleapis.com/css?family=Roboto:100,100i,300,300i,400,400i,500,500i,700,700i,900,900i" rel="stylesheet">
<link href='//fonts.googleapis.com/css?family=Roboto+Condensed:400,700italic,700,400italic,300italic,300' rel='stylesheet' type='text/css'>
<!-- //font -->
<script src="js/jquery-1.11.1.min.js"></script>
<script src="js/bootstrap.js"></script>
<script src="js/SmoothScroll.min.js"></script>
<script type="text/javascript">
    jQuery(document).ready(function ($) {
        $(".scroll").click(function (event) {
            event.preventDefault();
            $('html,body').animate({ scrollTop: $(this.hash).offset().top }, 1000);
        });
    });
</script>
<link href='css/immersive-slider.css' rel='stylesheet' type='text/css'>
<!-- pricing -->
<link rel="stylesheet" href="css/jquery.flipster.css">
<!-- //pricing -->

    <style>
        .msg {
    display: none;
    padding: 7px;
    border-radius: 10px;
    text-align: center;
    margin: 5px;
    width: 99%;
    font-size: 15px;
    border: 1px solid #000;
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
	<!-- header -->
	<div class="header">
			<div class="container">
				<nav class="navbar navbar-default">
					<!-- Brand and toggle get grouped for better mobile display -->
					<div class="navbar-header">
					  <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
						<span class="sr-only">Toggle navigation</span>
						<span class="icon-bar"></span>
						<span class="icon-bar"></span>
						<span class="icon-bar"></span>
					  </button>
						<div class="w3layouts-logo">
							<h1><a href="home.aspx"> <img src="images/logo.jpg" alt="Logo" style="height:45px; width:45px;" /> PCI <span>Portal</span></a></h1>
						</div>
					</div>

					<!-- Collect the nav links, forms, and other content for toggling -->
					<div class="collapse navbar-collapse nav-wil" id="bs-example-navbar-collapse-1">
						<nav>
							<ul class="nav navbar-nav">
								<li class="active"><a href="home.aspx">Home</a></li>
								<li><a href="login.aspx" class="hvr-sweep-to-bottom">Login</a></li>
								<li><a href="register.aspx" class="hvr-sweep-to-bottom">register</a></li>
                                 <li><a href="staff_dash/auth/secure_login.aspx" class="hvr-sweep-to-bottom">Staff Login</a></li>
								<li><a href="contact.aspx" class="hvr-sweep-to-bottom">Contact Us</a></li>
								
							</ul>
						</nav>
					</div>
					<!-- /.navbar-collapse -->
				</nav>
			</div>
	</div>
	<!-- //header -->
	<!-- about-heading -->
	<div class="about-heading">
		<h2>Login <span>Hosting City</span></h2>
	</div>
	<!-- //about-heading -->
	<div class="registration">
		<div class="container">
			<div class="signin-form profile">
				<h3>Login</h3>
				<div class="login-form">
					<form runat="server">
                        <div id="msg" class="msg" runat="server"></div>
						<input type="text" id="username" runat="server" placeholder="Username" required="">
						<input type="password" id="password" runat="server" placeholder="Password" required="">
						<div class="tp">
                            <asp:Button ID="Button1" runat="server" Text="Login Now" OnClick="login_student" />
						</div>
					</form>
				</div>
				
				<p><a href="register.aspx"> Don't have an account?</a></p>
			</div>
		</div>
	</div>
	<!-- footer -->
	<div class="footer">
		
		<div class="copyright">
			<p>© 2024 PCI Portal. All rights reserved | Design:: <a style="color: #2e86c1; text-decoration:underline;" href="http://jofilatech.com.ng">JOFILATECH</a></p>
		</div>
	</div>
	<!-- //footer -->
	<script type="text/javascript" src="js/move-top.js"></script>
	<script type="text/javascript" src="js/easing.js"></script>
	<!-- here stars scrolling icon -->
	<script type="text/javascript">
	    $(document).ready(function () {
	        /*
				var defaults = {
				containerID: 'toTop', // fading element id
				containerHoverID: 'toTopHover', // fading element hover id
				scrollSpeed: 1200,
				easingType: 'linear' 
				};
			*/

	        $().UItoTop({ easingType: 'easeOutQuart' });

	    });
	</script>
	<!-- //here ends scrolling icon -->
</body>	
</html>