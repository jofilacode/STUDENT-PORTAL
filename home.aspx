<%@ Page Language="C#" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="home" %>

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
    jQuery(document).ready(function($) {
        $(".scroll").click(function(event){		
            event.preventDefault();
            $('html,body').animate({scrollTop:$(this.hash).offset().top},1000);
        });
    });
</script>
<link href='css/immersive-slider.css' rel='stylesheet' type='text/css'>
<!-- pricing -->
<link rel="stylesheet" href="css/jquery.flipster.css">
<!-- //pricing -->
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
	<!-- banner -->
	<div class="main" style="margin-top:70px;">
		<div class="page_container">
			<div id="immersive_slider">
				  <div class="slide" data-blurred="">
						<div class="col-md-6 image">
							<img src="images/3a.jpg" alt="Slider 1" />
						</div>
						<div class="col-md-6 content">
							<h3>Become a  <span>Professional</span></h3>
							<p>Start your tech career with us. Learn the basic, and advanced into various ICT fields of life: Software Developer, Data analyst, Graphics Designer ...etc </p>
						</div>
						<div class="clearfix"> </div>
				  </div>
				  <div class="slide" data-blurred="">
						<div class="col-md-6 image">
							<img src="images/1a.jpg" alt="Slider 1" />
						</div>
						<div class="col-md-6 content">
							<h3>Conducive Environment <span></span></h3>
							<p>Learn with the best tool, and smart computer systems. We make every moment counts.  </p>
						</div>
						<div class="clearfix"> </div>
				  </div>
				  <div class="slide" data-blurred="">
						<div class="col-md-6 image">
							<img src="images/2a.jpg" alt="Slider 1" />
						</div>
						<div class="col-md-6 content">
							<h3>Online CBT <span>Portal</span></h3>
							<p>We operate onsite and remote activities: Learn, practice and engage with your instructors online via e-library and Cbt. </p>
						</div>
						<div class="clearfix"> </div>
				  </div>
				  
				  <a href="#" class="is-prev">&laquo;</a>
				  <a href="#" class="is-next">&raquo;</a>
			</div>
		</div>
	</div>
	<script type="text/javascript">
	    $(document).ready( function() {
	        $("#immersive_slider").immersive_slider({
	            container: ".main"
	        });
	    });

	</script>
	<!-- //banner -->
	<div class="domain">
		<div class="container">
			<form class="search-form domain-search" action="#" method="post">
				<h3 style="text-align:center; margin:15px;"><span style="font-weight:bold;">About Us</span> - Welcome to PCI</h3>
                <div style="line-height:35px; text-align:justify;">
                    Welcome to<span style="font-weight:bold;"> Professional Computer Institute (PCI)</span>. This is an educational service programme for educating children from 2(two years) and above. 
                    The vision and mission of the school are hereby stated thus: To be the foremost group of schools for building independent future leaders for 
                    global development and the sustenance of society that is faithful, successful and distinct. To produce learners who is spiritually, socially, 
                    physically and academically sound. equiping students at various levels for excellence through an all embracing qualitative education by skilled 
                    and highly motivated workforce to satisfy every stakeholder. At Pro. Computer Institute, personal care is given to each child in accordance with 
                    parent communication and expectations. The Nursery has been created to offer a warm and secure environment for your infant. our caregivers work 
                    with the parent to set their child's schedule and to ensure consistency between home and school. Daily information sheets are given to parents 
                    upon pick- up each day to satisfy the needs of knowing what and how your little one did during the day. 
                </div>
				<div class="clearfix"> </div>
			</form>
		</div>
	</div>
	<!-- banner-bottom -->
	<div class="banner-bottom">
		<div class="container">
			<div class="w3-banner-bottom-heading">
				<h3>What <span>We Do?</span></h3>
			</div>
			<div class="agileits-banner-bottom">
				<div class="col-md-3 agileits-banner-bottom-grid">
					<div class="services-grid1">
						<div class="services-grid-right agile-services-grid-right">
							<div class="services-grid-right-grid hvr-radial-out blue-grid">
								<span class="glyphicon glyphicon-education" aria-hidden="true"></span>
							</div>
						</div>
						<div class="services-grid-left agile-services-grid-left">
							<h4>Online/Physical Training</h4>
							<p style="line-height:35px; color:#212f3d;">We conduct both online and physical training on various tech courses for kids and adults.</p>
						</div>
					</div>
				</div>
				<div class="col-md-3 agileits-banner-bottom-grid">
					<div class="services-grid1">
						<div class="services-grid-right agile-services-grid-right">
							<div class="services-grid-right-grid hvr-radial-out orange-grid">
								<span class="glyphicon glyphicon-book" aria-hidden="true"></span>
							</div>
						</div>
						<div class="services-grid-left agile-services-grid-left">
							<h4>Online Registration</h4>
							<p  style="line-height:35px; color:#212f3d;">We register national and international exams: Jamb, Waec, Neco, Scholarships, Promotional etc.  via our secured network system.</p>
						</div>
					</div>
				</div>
				<div class="col-md-3 agileits-banner-bottom-grid">
					<div class="services-grid1">
						<div class="services-grid-right agile-services-grid-right">
							<div class="services-grid-right-grid hvr-radial-out green-grid">
								<span class="glyphicon glyphicon-modal-window" aria-hidden="true"></span>
							</div>
						</div>
						<div class="services-grid-left agile-services-grid-left">
							<h4>Web Design / Software Programming</h4>
							<p  style="line-height:35px; color:#212f3d;">Learn web design and software engineering for an affordable price within few months and get free internship space.</p>
						</div>
					</div>
				</div>
				<div class="col-md-3 agileits-banner-bottom-grid">
					<div class="services-grid1">
						<div class="services-grid-right agile-services-grid-right">
							<div class="services-grid-right-grid hvr-radial-out red-grid">
								<span class="glyphicon glyphicon-stats" aria-hidden="true"></span>
							</div>
						</div>
						<div class="services-grid-left agile-services-grid-left">
							<h4>Media / Non Media Advertisement</h4>
							<p  style="line-height:35px; color:#212f3d;">We have all it takes to advertise your products and services via our media network. reach out to us today.</p>
						</div>
					</div>
				</div>
				<div class="clearfix"> </div>
			</div>
		</div>
	</div>
	<!-- //banner-bottom -->

	<!-- choose -->
	<div class="choose jarallax">
		<div class="w3-agile-testimonial">
			<div class="container">
				<div class="w3-agileits-choose">
					<div class="col-md-6 choose-grid">
						<div class="w3-banner-bottom-heading choose-heading">
							<h3 style="text-align:center;font-size:24px;">Why Choose<span> Us?</span></h3>
						</div>
						<div class="top-choose-info">
                            <h3 style="color:green;font-size:16px; text-align:center;">We have outstanding and unique approach. </h3>
                            <hr />
							<div class="choose-info-top">
								<div class="choose-left-grid col-sm-6">
									<div class="choose-info-grid ">
										<ul>
											<li><i class="fa fa-bell" aria-hidden="true"></i></li>
											<li>We keep to time</li>
										</ul>
									</div>
								</div>
								<div class="choose-right-grid col-sm-6">
									<div class="choose-info-grid ">
										<ul>
											<li><i class="fa fa-cog" aria-hidden="true"></i></li>
											<li>Organized Class</li>
										</ul>
									</div>
								</div>
								<div class="clearfix"> </div>
							</div>
							<div class="choose-info-top">
								<div class="choose-left-grid col-sm-6">
									<div class="choose-info-grid ">
										<ul>
											<li><i class="fa fa-comments" aria-hidden="true"></i></li>
											<li>Good Communication</li>
										</ul>
									</div>
								</div>
								<div class="choose-right-grid col-sm-6">
									<div class="choose-info-grid ">
										<ul>
											<li><i class="fa fa-user" aria-hidden="true"></i></li>
											<li>Student Portal</li>
										</ul>
									</div>
								</div>
								<div class="clearfix"> </div>
							</div>
							<div class="choose-info-top">
								<div class="choose-left-grid col-sm-6">
									<div class="choose-info-grid ">
										<ul>
											<li><i class="fa fa-money" aria-hidden="true"></i></li>
											<li>Easy Payment</li>
										</ul>
									</div>
								</div>
								<div class="choose-right-grid col-sm-6">
									<div class="choose-info-grid ">
										<ul>
											<li><i class="fa fa-thumbs-o-up" aria-hidden="true"></i></li>
											<li>Excellent Feedback</li>
										</ul>
									</div>
								</div>
								<div class="clearfix"> </div>
							</div>

						</div>
					</div>
					<div class="col-md-6 choose-grid">
						<div class="w3-banner-bottom-heading choose-heading">
							<h3 style="text-align:center;font-size:24px;">Meet The<span> Founder</span></h3>
						</div>
						<div class="top-choose-info testimonial-info">
							<div class="wthree-testimonial-grid">
									<div class="slider">
											<div class="callbacks_container">
												<ul class="rslides" id="slider3">
													
													<li>
														<div class="testimonial-top">
															<i style="font-weight:bold;color:green;">Engr. Kadiri Hammed</i>
															<p style="color: #212f3d;"> Mr. Kadiri Hammed is the Proprietor of Professional Computer Institute (PCI), an academy platform for
                                                                 learning computer basics and other professional computer course. He is a man with passion for I.T (Information technology) 
                                                                which is evolving so quick around us and as well as a tutor skilled in web Development,Software Programming, teaching and
                                                                 impacting professional knowledge into students. Over the years, he has been creating and managing cordial relationship 
                                                                between his staff, students and parents to enable fast attainment of his set goals and objectives.  </p>
															
														</div>
													</li>
												</ul>
											</div>
											<script>
											    // You can also use "$(window).load(function() {"
											    $(function () {
											        // Slideshow 4
											        $("#slider3").responsiveSlides({
											            auto: true,
											            pager:true,
											            nav:false,
											            speed: 500,
											            namespace: "callbacks",
											            before: function () {
											                $('.events').append("<li>before event fired.</li>");
											            },
											            after: function () {
											                $('.events').append("<li>after event fired.</li>");
											            }
											        });
											
											    });
											 </script>
											<!--banner Slider starts Here-->
									</div>
							</div>

						</div>
					</div>
					<div class="clearfix"> </div>
				</div>
			</div>
		</div>
	</div>
	<!-- //choose -->
	<!-- footer -->
	<div class="footer">
		
		<div class="copyright">
			<p>© 2024 PCI Portal. All rights reserved | Design:: <a style="color: #2e86c1; text-decoration:underline;" href="http://jofilatech.com.ng">JOFILATECH</a></p>
		</div>
	</div>
	<!-- //footer -->
	<script src="js/jarallax.js"></script>
	<script type="text/javascript">
	    /* init Jarallax */
	    $('.jarallax').jarallax({
	        speed: 0.5,
	        imgWidth: 1366,
	        imgHeight: 768
	    })
	</script>
	<script src="js/responsiveslides.min.js"></script>
	<script type="text/javascript" src="js/move-top.js"></script>
	<script type="text/javascript" src="js/easing.js"></script>
	<!-- here stars scrolling icon -->
	<script type="text/javascript">
	    $(document).ready(function() {
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
	<!-- pricing -->
	<script src="js/jquery.flipster.js"></script>
	<script>
	<!--
		
    $(function(){ $(".flipster").flipster({ style: 'carousel', start: 0 }); });

    -->
	</script>
	<!-- //pricing -->
	<!-- slider -->
	<script type="text/javascript" src="js/jquery.immersive-slider.js"></script>
	<!-- //slider -->
</body>	
</html>
