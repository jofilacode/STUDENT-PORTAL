<%@ Page Language="C#" AutoEventWireup="true" CodeFile="lecture.aspx.cs" Inherits="secure_account_home" %>

<!DOCTYPE html>
<html lang="en">

<head>
   <title>Professional Computer Institute (PCI)</title>

    <!-- Meta Tags -->
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta charset="utf-8">
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
    <!-- //Meta Tags -->

    <!-- Style-sheets -->
    <!-- Bootstrap Css -->
    <link href="css/bootstrap.css" rel="stylesheet" type="text/css" media="all" />
    <!-- Bootstrap Css -->
    <!-- Common Css -->
    <link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
    <!--// Common Css -->
    <!-- Nav Css -->
    <link rel="stylesheet" href="css/style4.css">
    <!--// Nav Css -->
    <!-- Fontawesome Css -->
    <link href="css/fontawesome-all.css" rel="stylesheet">
    <!--// Fontawesome Css -->
    <!--// Style-sheets -->

    <!--web-fonts-->
    <link href="//fonts.googleapis.com/css?family=Poiret+One" rel="stylesheet">
    <link href="//fonts.googleapis.com/css?family=Open+Sans:300,400,600,700" rel="stylesheet">
    <!--//web-fonts-->

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

         .txtbox
        {
            width:100%;
            margin:10px;
            padding:5px;
        }
        .txtbox2
        {
             width:100%;
            padding:10px;
            margin:10px;
        }

        .btn_form
        {
            background-color: #239b56;
            color:#fff;
            padding:8px;
            cursor:pointer;
            margin:10px;
            width:150px;
            border:0;
            border-radius:7px;
        }
        .btn_form:hover{
            background-color: #186a3b;
        }

        table
        {
            width:100%;
            text-align:center;
            font-size:12px;
            text-align:center;
            color: #1c2833;
        }

        table th
       {
         padding:10px;
       }

        table th>td
       {
         padding:10px;
        
       }

         .info
        {
            font-weight:bold;
            color: #2874a6 ;
            padding-left:5px;
        }
        .details
        {
            background-color:#f4f6f6;
            color:#000;
            padding:7px;
            padding-left:20px;
        }
    </style>

</head>

<body>
    <div class="wrapper">
        <!-- Sidebar Holder -->
        <nav id="sidebar">
            <div class="sidebar-header">
                <h1 style="font-weight:bold;font-size:20px;"><imG src="../../images/logo.jpg" alt="lOGO" style="height:50px; width:50px;" /> PCI PORTAL</h1>
                <span style="font-size:20px; font-weight:normal; ">PCI Portal</span>
            </div>
            <div class="profile-bg"></div>
            <ul class="list-unstyled components">
                <li>
                    <a href="home.aspx">
                        <i class="fas fa-user"></i>
                        My Profile
                    </a>
                </li>
                <li>
                    <a href="course.aspx">
                        <i class="fas fa-pen-square"></i>
                        Course Mgt
                    </a>
                </li>

                 <li>
                    <a href="lecture.aspx">
                        <i class="fas fa-users"></i>
                        Lecture Mgt
                    </a>
                </li>
                 <li>
                    <a href="ebooks.aspx">
                        <i class="fas fa-book"></i>
                        E-Books Mgt
                    </a>
                </li>

              
                 <li>
                    <a href="cbt.aspx">
                        <i class="fas fa-pencil-alt"></i>
                        CBT Mgt
                    </a>
                </li>

                 <li>
                    <a href="student_upload.aspx">
                        <i class="fas fa-upload"></i>
                        Uploads Data
                    </a>
                </li>

                 <li>
                    <a href="download.aspx">
                        <i class="fas fa-download"></i>
                        Download Data
                    </a>
                </li>

                 <li>
                    <a href="result.aspx">
                        <i class="fas fa-chart-line"></i>
                        My Result
                    </a>
                </li>

                 <li>
                    <a href="complain.aspx">
                        <i class="fas fa-comment"></i>
                        Complain
                    </a>
                </li>

      
                <li>
                    <a href="../login.aspx">
                        <i class="fas fa-lock"></i>
                        Logout
                    </a>
                </li>

               

            </ul>
        </nav>

        <!-- Page Content Holder -->
        <div id="content">
            <!-- top-bar -->
            <nav class="navbar navbar-default mb-xl-5 mb-4">
                <div class="container-fluid">

                    <div class="navbar-header">
                        <button type="button" id="sidebarCollapse" class="btn btn-info navbar-btn">
                            <i class="fas fa-bars"></i>
                        </button>
                    </div>
                    <!-- Search-from -->
                    <div style="font-weight:bold; color:#2471a3;text-align:center;">Student Portal</div>
                    <!--// Search-from -->
                   
                </div>
            </nav>
            <!--// top-bar -->

            <!-- Error Page Content -->
            <div class="blank-page-content">

                <!-- Error Page Info -->
                
              
                    <div class="paragraph-agileits-w3layouts">
                        
                      <div class="outer-w3-agile mt-3">
                         

                  <div class="outer-w3-agile mt-3">
                          

                    <p style="text-align:center; font-size:15px;color: #212f3d;">Onine Lecture</p>
                    <div id="msg" runat="server" class="msg"> </div>
                    <p class="paragraph-agileits-w3layouts">
                        
                       
                         <form runat="server">
  <div class="probox">
        <p class="info">Tutor</p>
        <p class="details" id="tutorname" runat="server">Mr Bake Kane</p>
         </div>
            <div class="probox">
        <p class="info">Topic</p>
        <p class="details" id="topic" runat="server">Introduction to Computer</p>
         </div>

         <div class="probox">
        <p class="info">Details</p>
        <p class="details" id="details" runat="server" style="text-align:justify; line-height:35px;">This course will introduce you to the field of computer science and the fundamentals of computer programming. Introduction to Computer Science I is specifically designed for students with no prior programming experience, and taking this course does not require a background in Computer Science. This course will touch upon a variety of fundamental topics within the field of Computer Science and will use Java, a high-level, portable, and well-constructed computer programming language developed by Sun Microsystems (now Oracle), to demonstrate those principles. We will begin with an overview of the course topics as well as a brief history of software development. We will cover basic object-oriented programming terminology and concepts such as objects, classes, inheritance, and polymorphism, as well as the fundamentals of Java, its primitive data types, relational operators, control statements, exception handling, and file input /output. By the end of the course, you should have a strong understanding of the fundamentals of Computer Science and the Java programming language. This course will lay the groundwork for a strong education in Computer Science and a successful career devoted to implementing the principles you will learn as you progress through the CS discipline.</p>
         </div>

          </form>
                
                             
                              

                              
                        
                       
                        
                        
                    
                        
                    

                    </p>


                   </div>


                          
                </div>

               </div>

  
                
          

                </div>
               


        </div>
    </div>


    <!-- Required common Js -->
    <script src='js/jquery-2.2.3.min.js'></script>
    <!-- //Required common Js -->

    <!-- Sidebar-nav Js -->
    <script>
        $(document).ready(function () {
            $('#sidebarCollapse').on('click', function () {
                $('#sidebar').toggleClass('active');
            });
        });
    </script>
    <!--// Sidebar-nav Js -->

    <!-- dropdown nav -->
    <script>
        $(document).ready(function () {
            $(".dropdown").hover(
                function () {
                    $('.dropdown-menu', this).stop(true, true).slideDown("fast");
                    $(this).toggleClass('open');
                },
                function () {
                    $('.dropdown-menu', this).stop(true, true).slideUp("fast");
                    $(this).toggleClass('open');
                }
            );
        });
    </script>
    <!-- //dropdown nav -->

    <!-- Js for bootstrap working-->
    <script src="js/bootstrap.min.js"></script>
    <!-- //Js for bootstrap working -->
</body>

</html>
