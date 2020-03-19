<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Fifapub.Pages.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>    
    <link rel="stylesheet" href="/Content/Styles.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <img src="/Images/logo.png" alt="logo"/>
            <a href="<%=CreatePageLink("admin/Gallery") %>"><img src="/Images/Icon_user_cirlce.png" alt ="userProfile" id="userProfile"/></a>            
          <nav>
                <a href="<%=CreatePageLink("Home") %>" >Home</a>
                <a href="<%=CreatePageLink("Gallery") %>">Gallery</a>
                <a href="<%=CreatePageLink("Registration") %>>Registration</a>
                <a href="<%=CreatePageLink("News") %>">News</a>
                <a href="<%=CreatePageLink("Winners") %>">Winners</a>
            </nav>              
        </header>
        <div id="registrationGridContainer">
            <section id="Eventinfo">
                <h2>FIFAPUB 2.0</h2>
                in
                <h2>VORONEZH</h2>
                <p>
                    This entry is only approved for admins of the site
                </p>
            </section>
            <section id="registrationForm">                  
                <div id="errors"data-valmsg-summary="true">
                    <ul><li style="display:none"></li></ul>
                    <asp:ValidationSummary ID="ValidationSummary1" HeaderText="Please fix the following errors" runat="server"/> 
                </div> 
                <p>
                    Username
                </p>
                <input type="text" name="userName" class="textInput" data-val="true" data-val-required="Enter the user name"/>
                <p>
                    Password
                </p>
                <input type="password"  name="password" class="textInput" data-val="true" data-val-required="Enter the password"/>
                <button type="submit">Log in</button>               
            </section>        
        </div>
        
    </form>
</body>
</html>
