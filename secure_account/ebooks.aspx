<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ebooks.aspx.cs" Inherits="secure_account_home" %>

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
                          

                    <p style="text-align:center; font-size:15px;color: #212f3d;">E-Books Mgt</p>
                    <div id="msg" runat="server" class="msg"> </div>
                    <div class="paragraph-agileits-w3layouts">
                        
                       <form runat="server">

                   <div id="bar1">
                  <h3 style="text-align:center;color:#000; font-size:15px; font-weight:bold; font-family:Tahoma !important; color: #2471a3 ; margin-top:20px;">Forms/Special Ebooks</h3>

                <asp:Repeater ID="Repeater2" runat="server">
                    <ItemTemplate>

             <div class="fbox">
            <span style="margin:10px;font-weight:bold; color: #212f3d;"><%#Eval("file_ebook_name") %></span>
            <p><img src="../images/ebook.jpg" alt="images" style="height:100px;width:100px;margin:10px;" /></p>        
            <p style="margin-top:8px;">
               
                <asp:LinkButton  ID="LinkButton1" css2Class="download" runat="server" PostBackUrl='<%#Eval("filename") %>' >download</asp:LinkButton>

            </p>
                </div>

                    </ItemTemplate>
                </asp:Repeater>

               

              


            </div>
 <hr />
            <div id="bar2">
                 <h3 style="text-align:center;color:#000; font-size:15px; font-weight:bold; font-family:Tahoma !important; color: #2471a3 ; margin-top:20px;">E-Books Available</h3>
                 <div id="Div1" class="msg" runat="server"></div>
                <div class="searchpanel">
                     
                <input type="text" id="searchbookname" runat="server" placeholder="Enter E-Book Name" class="txtbox" style="width:55%; float:left;" />

                    <asp:Button ID="Button22" runat="server" Text="Search" cssClass="btn" style="width:15%; float:left; margin:10px;  background-color:#2C3E50; color:#fff;" OnClick="search_file"  />
                      <asp:Button ID="Button1" runat="server" Text="All ebooks"  cssClass="btn" style="width:15%; float:left; margin:10px;  background-color:#2C3E50; color:#fff;" OnClick="all_file"  />
                </div>
                <div style="clear:both;"></div>
                <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                    <ItemTemplate>
                         <div class="ebox" style="border:1px solid green; padding:10px;width:99%;">
                 <p style="margin:10px; font-weight:bold;color:#212f3d;"><%#Eval("file_ebook_name")%></p>
                  <p><img src="../images/ebook.jpg" alt="images" style="height:100px;width:100px;margin:10px;" /></p>
                  <p>
                      <asp:LinkButton cssClass="btn" style="padding:10px;background-color:green;color:#fff;" ID="LinkButton2" runat="server"  CommandArgument='<%#Eval("filename") %>' CommandName="download" >download</asp:LinkButton>   
                  </p>
                </div>
                    </ItemTemplate>

                </asp:Repeater>
              

               


            </div>
                             
                              

                              
                        
                       
                        
                        
                    
                      </form>  
                    

                    </div>


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
