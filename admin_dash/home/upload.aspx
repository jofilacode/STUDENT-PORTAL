<%@ Page Language="C#" AutoEventWireup="true" CodeFile="upload.aspx.cs" Inherits="secure_account_home" %>

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
                          

                    <p style="text-align:center; font-size:15px;color: #212f3d;">Upload</p>
                    <div id="msg" runat="server" class="msg"> </div>
                    <div class="paragraph-agileits-w3layouts">
                        
                       <form runat="server">
            <div id="Div1" runat="server" class="msg"></div>
    <asp:DropDownList ID="package" runat="server" CssClass="txtbox2">
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

          <asp:DropDownList ID="uploadtype" runat="server" CssClass="txtbox2">
              <asp:ListItem>Type of Document</asp:ListItem>
              <asp:ListItem>Assignment</asp:ListItem>
              <asp:ListItem>Course</asp:ListItem>
               <asp:ListItem>Quick Note</asp:ListItem>
               <asp:ListItem>Others</asp:ListItem>
        </asp:DropDownList>
           <input type="text" id="description" runat="server" placeholder="Short description" class="txtbox" />
    <asp:FileUpload ID="FileUpload1" runat="server" class="browse" />
          <asp:Button ID="Button2" runat="server" Text="upload" OnClick="UploadDoc" />
          <input type="hidden" id="filename" runat="server" />
          <input type="hidden" id="filepath" runat="server" />
           <input type="hidden" id="filesize" runat="server" />
          <asp:Button ID="Button1" runat="server" Text="Submit" class="btn_form"  OnClick="saveupload"  />

        
     
        <hr />
            <h3 style="text-align:center;color:#000; font-size:15px; font-weight:bold; font-family:Tahoma !important; color: #2471a3 ;">View Uploads</h3>
                          <div style="padding:20px; overflow:scroll;">
           <table border="1">
                  <tr>
                       <td class="thead">Delete</td>
                      <td class="thead">ID</td>
                      <td class="thead">Package</td>
                      <td class="thead">Type</td>
                      <td class="thead">Description</td>
                      <td class="thead">Size</td>
                      <td class="thead">Date</td>
                      <td class="thead">Download</td>
                  </tr>
               <asp:Repeater ID="uploadData" runat="server" OnItemCommand="uploadData_ItemCommand" >
               <ItemTemplate>
                  <tr>
                      <td><asp:LinkButton ID="LinkButton1" CommandName="Delete" OnClientClick="javascript:if(!confirm('Delete this information? this will delete permanently'))return false;" CommandArgument='<%#Eval("id") %>' runat="server" style="background-color:#c0392b ;color:#fff; border:0; border-radius:5px;padding:5px; cursor:pointer;width:60px;">Delete</asp:LinkButton></td>
                      <td><%# Eval("id") %></td>
                      <td><%# Eval("package") %></td>
                      <td><%# Eval("type") %></td>
                      <td><%# Eval("description") %></td>
                      <td><%# Eval("file_size") %></td>
                      <td><%# Eval("entry_date") %></td>
                      <td><a href='<%# Eval("path") %>' style="text-decoration:underline; color:blue;">Download</a></td>
                  </tr>
                </ItemTemplate>

              </asp:Repeater>
              </table>
              
</div>
          <hr />
           <h3 style="text-align:center;color:#141111;">Student Submission</h3>
            <table border="1">
                  <tr>
                       <td class="thead">Delete</td>
                      <td class="thead">ID</td>
                      <td class="thead">Student Name</td>
                      <td class="thead">Tutor</td>
                      <td class="thead">Type</td>
                      <td class="thead">Description</td>
                      <td class="thead">Size</td>
                      <td class="thead">Date</td>
                      <td class="thead">Download</td>
                  </tr>
               <asp:Repeater ID="submissionData" runat="server"  OnItemCommand="submissionData_ItemCommand" >
               <ItemTemplate>
                  <tr>
                      <td><asp:LinkButton ID="LinkButton1" CommandName="Delete" OnClientClick="javascript:if(!confirm('Delete this information? this will delete permanently'))return false;" CommandArgument='<%#Eval("id") %>' runat="server" style="background-color:#c0392b ;color:#fff; border:0; border-radius:5px;padding:5px; cursor:pointer;width:60px;">Delete</asp:LinkButton></td>
                      <td><%# Eval("id") %></td>
                      <td><%# Eval("student_name") %></td>
                      <td><%# Eval("tutor") %></td>
                      <td><%# Eval("type") %></td>
                      <td><%# Eval("description") %></td>
                      <td><%# Eval("file_size") %></td>
                      <td><%# Eval("entry_date") %></td>
                      <td><a  href='../../secure_account/<%# Eval("path") %>' style="text-decoration:underline; color:blue;">Download</a></td>
                  </tr>
                </ItemTemplate>

              </asp:Repeater>
              </table>

                
                             
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
