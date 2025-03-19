<%@ Page Language="C#" AutoEventWireup="true" CodeFile="create_cbt.aspx.cs" Inherits="secure_account_home" %>

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
                        <i class="fas fa-pen-square"></i>
                        Create Account
                    </a>
                </li>
                <li>
                    <a href="addcourse.aspx">
                        <i class="fas fa-book"></i>
                        Add/ViewCourse
                    </a>
                </li>

                 <li>
                    <a href="addtutor.aspx">
                        <i class="fas fa-user"></i>
                        Add/View Tutors
                    </a>
                </li>
                 <li>
                    <a href="pin.aspx">
                        <i class="fas fa-pencil-alt"></i>
                        Generate Pin
                    </a>
                </li>

                 <li>
                    <a href="startlecture.aspx">
                        <i class="fas fa-user-plus"></i>
                        Lecture
                    </a>
                </li>

                 <li>
                    <a href="editrecord.aspx">
                        <i class="fas fa-user-plus"></i>
                        Edit record
                    </a>
                </li>

                 <li>
                    <a href="editpayment.aspx">
                        <i class="fas fa-money-bill-alt"></i>
                        Payment
                    </a>
                </li>

                 <li>
                    <a href="editcourse.aspx">
                        <i class="fas fa-bars"></i>
                        Edit Course
                    </a>
                </li>

                 <li>
                    <a href="edittutor.aspx">
                        <i class="fas fa-user-circle"></i>
                        Edit Tutor
                    </a>
                </li>

                 <li>
                    <a href="upload.aspx">
                        <i class="fas fa-upload"></i>
                        Upload View
                    </a>
                </li>

                 <li>
                    <a href="postresult.aspx">
                        <i class="fas fa-chart-line"></i>
                        Post result
                    </a>
                </li>
                 <li>
                    <a href="viewresult.aspx">
                        <i class="fas fa-eye"></i>
                        View Result
                    </a>
                </li>

                 <li>
                    <a href="viewrecord.aspx">
                        <i class="fas fa-book"></i>
                        View record
                    </a>
                </li>

                
                  <li>
                    <a href="create_library.aspx">
                        <i class="fas fa-book"></i>
                        E-Library
                    </a>
                </li>

                  <li>
                    <a href="create_cbt.aspx">
                        <i class="fas fa-desktop"></i>
                        CBT Data
                    </a>
                </li>

                  <li>
                    <a href="viewrequest.aspx">
                        <i class="fas fa-comment"></i>
                        View Request
                    </a>
                </li>

                

      
                <li>
                    <a href="../auth/secure_login.aspx">
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
                    <div style="font-weight:bold; color:#2471a3;text-align:center;">Welcome Admin!</div>
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
                          

                    <h3 style="text-align:center;color:#000; font-size:15px; font-weight:bold; font-family:Tahoma !important; color: #2471a3 ;">CBT Settings</h3>
                    <div id="msg" runat="server" class="msg"> </div>
                    <div class="paragraph-agileits-w3layouts">
                    <form runat="server">

                        <div style="padding:10px;border-radius:5px;">
                            
                            <asp:DropDownList ID="course2" runat="server" CssClass="txtbox2" style="width:200px;background-color:#fff;border:0;border:1px solid #212f3d; border-radius:10px; width:200px;" OnSelectedIndexChanged="course2_SelectedIndexChanged" AutoPostBack="true">
             

                           </asp:DropDownList>

                            <asp:DropDownList ID="cbt_control" runat="server" CssClass="txtbox2" style="background-color:#fff;border:0;border:1px solid #212f3d; border-radius:10px; width:200px;">
              <asp:ListItem>Select Cbt Control</asp:ListItem>
              <asp:ListItem>Enable</asp:ListItem>
              <asp:ListItem>Disable</asp:ListItem>
               

        </asp:DropDownList>

         <input type="text" id="cbt_mark" runat="server" placeholder="Mark/Que"  class="txtbox" style="width:100px;border:1px solid #212f3d;color:#000;; border-radius:7px;" />
         <input type="text" id="cbt_time" runat="server" placeholder="Time"  class="txtbox" style="width:100px;border:1px solid #212f3d; color: #000; border-radius:7px;" />
                            
                            
                      <asp:Button ID="updatebtn" runat="server" Text="Update" class="btn_form" style="background-color:#16a085;padding:5px;" OnClick="updatebtn_Click" />

                        </div>








                       <hr />
                        <h3 style="text-align:center;color:#000; font-size:15px; font-weight:bold; font-family:Tahoma !important; color: #2471a3 ;">CBT Add/View Questions</h3>
            <asp:DropDownList ID="course" runat="server" CssClass="txtbox2">
              <asp:ListItem>Package</asp:ListItem>
              <asp:ListItem>Certificate</asp:ListItem>
              <asp:ListItem>Diploma</asp:ListItem>
               <asp:ListItem>Jamb</asp:ListItem>
               <asp:ListItem>Primary 1</asp:ListItem>
              <asp:ListItem>Primary 2</asp:ListItem>
              <asp:ListItem>Primary 3</asp:ListItem>
              <asp:ListItem>Primary 4</asp:ListItem>
              <asp:ListItem>Primary 5</asp:ListItem>
              <asp:ListItem>Jhs 1</asp:ListItem>
              <asp:ListItem>Jhs 2</asp:ListItem>
              <asp:ListItem>Jhs 3</asp:ListItem>
              <asp:ListItem>Sss 1</asp:ListItem>
              <asp:ListItem>Sss 2</asp:ListItem>
              <asp:ListItem>Sss 3</asp:ListItem>

        </asp:DropDownList>
      <input type="text" id="question" runat="server" placeholder="Question" class="txtbox" />
      <input type="text" id="option_a" runat="server" placeholder="Option A" class="txtbox" /> 
      <input type="text" id="option_b" runat="server" placeholder="Option B" class="txtbox" />
      <input type="text" id="option_c" runat="server" placeholder="Option C" class="txtbox" />
      <input type="text" id="answer" runat="server" placeholder="Answer" class="txtbox" />
          <asp:Button ID="Button1" runat="server" Text="Submit" class="btn_form" OnClick="save_cbt"  />
    <hr />
              <h3 style="text-align:center;color:#000; font-size:15px; font-weight:bold; font-family:Tahoma !important; color: #2471a3 ; margin-top:20px; margin-bottom:20px;">View CBT Data</h3>
           
          <asp:GridView ID="cbtData" runat="server" EmptyDataText="No Record Available Yet" OnRowCommand="cbtData_RowCommand">
              <HeaderStyle  BackColor="#191919" ForeColor="White" />
               <Columns>
                    <asp:TemplateField ShowHeader="False" >
                      <ItemTemplate>
                            <asp:Button ID="mydelbtn" CssClass="delbtn" runat="server" CausesValidation="false" CommandName="deletequestion" style="background-color:red;color:#fff;cursor:pointer;border-radius:5px;"
                             Text="Delete" CommandArgument='<%# Eval("cbt_id") %>' />
                      </ItemTemplate>
                    </asp:TemplateField>
                    </Columns>
          </asp:GridView>

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
