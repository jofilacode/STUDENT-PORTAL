<%@ Page Language="C#" AutoEventWireup="true" CodeFile="cbt.aspx.cs" Inherits="secure_account_home" %>

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
            padding:5px;
            margin:5px;
            border-radius:10px;
            font-weight:bold;
            font-size:12px;
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

         #cbtbox
        {
            padding:30px;
            border:3px solid #0094ff;
            width:80%;
            margin:0 auto;
            border-radius:10px;
            height:370px;
            overflow:scroll;
        }

         #btn_submit:hover{

             background-color:#186a3b !important;
         }

         #btn_start:hover{

             background-color:blue !important;
             color:#fff;
         }

         .options label
         {
           margin-left: 15px;
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
                          

                    <p style="text-align:center; font-size:15px;color: #212f3d;">CBT ONLINE</p>
                    <div id="msg" runat="server" class="msg"> </div>
                    <div class="paragraph-agileits-w3layouts">
                        
                       
                        <form runat="server">
                            <div id="startbox" runat="server">
  
                        <input type="text" id="course" runat="server" placeholder="Package - Course" class="txtbox" disabled style="border:1px solid #000;border-radius:6px;" />
         
           <asp:Button ID="btn_start" runat="server" Text="Start CBT" OnClick="btn_start_Click" CssClass="btn" style="margin-left:10px;font-size:13px;border:1px solid blue;" />
          </div>
        
     <div id="cbt_open" runat="server" style="display:none;"> 
                  <h3 id="course_title" runat="server" style="text-align:center;color:#000; font-size:15px; font-weight:bold; font-family:Tahoma !important; color: #2471a3 ; margin-top:20px;"> </h3>
          <asp:ScriptManager runat="server" ID="ScriptManager1" />
        <asp:Timer ID="Timer1" runat="server" OnTick="Timer1_Tick" Interval="1000">
        </asp:Timer>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
              
                <p style="text-align:center;">(<span style="font-weight:bold;">Mark :</span><span style="font-size:14px; color:green;font-weight:bold;"><span style="font-weight:bold;" id="mark" runat="server"> </span> Per Question</span>) - <span style="font-weight:bold;padding:10px;font-size:16px;">Time Left: </span><label id="timecount" runat="server" style="color:#d35400;font-size:20px;margin-top:10px;font-weight:bold;">30</label></p>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
            </Triggers>
        </asp:UpdatePanel>
         
             <hr />

           <asp:Repeater ID="cbt_display" runat="server"  >
               <ItemTemplate>
                    <div id="question" style="font-size:16px; margin-top:40px; margin-bottom:10px;color:#17202a;" > <%#Eval("question") %>   </div>
           <div>

               <asp:RadioButton ID="opt_a" runat="server" Text=' <%#Eval("option_a") %> ' CssClass="options" style="width:100%;color:#2c3e50; margin-left:20px;" GroupName="cbt"  />
                <asp:RadioButton ID="opt_b" runat="server" Text=' <%#Eval("option_b") %> ' CssClass="options" style="width:100%;color:#2c3e50; margin-left:20px; " GroupName="cbt"  />
                <asp:RadioButton ID="opt_c" runat="server" Text=' <%#Eval("option_c") %> ' CssClass="options" style="width:100%;color:#2c3e50; margin-left:20px; " GroupName="cbt"  />
                <asp:RadioButton ID="ans" runat="server" Text=' <%#Eval("answers") %> ' CssClass="options" style="width:100%;color:#2c3e50; margin-left:20px; display:none; " GroupName="cbt"  />
               
              
           </div>
               </ItemTemplate>
           </asp:Repeater>
          <asp:HiddenField ID="holdscore" runat="server" />
          


               
         





                  <hr />
           <asp:Button ID="btn_submit" runat="server" Text="Submit" style="margin-left:10px; font-size:14px;background-color:green; color:#fff;border:0;padding:3px;width:60px;border-radius:6px; cursor:pointer;"  OnClick="btn_submit_Click" />
          
          
        
            <div style="clear:both;"></div>
  
         </div>

         <div id="cbtresult" runat="server" style="display:none;" >
               <h3 style="text-align:center;color:#000; font-size:15px; font-weight:bold; font-family:Tahoma !important; color: #2471a3 ; margin:20px;">My CBT Result</h3>
          
         <div style="padding:20px; overflow:scroll;">
            <asp:GridView ID="cbtData" runat="server" EmptyDataText="No Record Available Yet">
              <HeaderStyle  BackColor="#191919" ForeColor="White" />
          </asp:GridView>
         </div>
                    
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
