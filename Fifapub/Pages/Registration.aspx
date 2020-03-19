<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Fifapub.Pages.Gallery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link rel="stylesheet" href="/Content/Styles.css"/>
    <%: System.Web.Optimization.Scripts.Render("~/bundles/validation") %>
    
</head>
<body>
        <header>
            <img src="/Images/logo.png" alt="logo"/>
            <a href="<%=CreatePageLink("admin/Gallery") %>"><img src="/Images/Icon_user_cirlce.png" alt ="userProfile" id="userProfile"/></a>            
            <nav>
                <a href="<%=CreatePageLink("Home") %>" >Home</a>
                <a href="<%=CreatePageLink("Gallery") %>">Gallery</a>
                <a href="<%=CreatePageLink("Registration") %>" class="selected">Registration</a>
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
                    NOTE: Multiple registration can lead to disqualification of 
                    Participant and if the participant wants to pull out, feel free to 
                    contact our emai;
                </p>
            </section>
            <section id="registrationForm">                  
                <form id="form1" runat="server" >
                     <div id="errors"data-valmsg-summary="true">
                         <ul><li style="display:none"></li></ul>
                         <asp:ValidationSummary ID="ValidationSummary1" HeaderText="Please fix the following errors" runat="server"/> 
                     </div> 
                    <p>Name</p> 
                    <input type="text" name="name" class="textInput" data-val="true" data-val-required="Enter your name"/>
                    <p>Email</p>
                    <input type="email" name="email" class="textInput" data-val="true" data-val-required="Enter your email"/>
                    <p>Telephone(whatsapp)</p>
                    <input type="tel" name="telephone" class="textInput" id="telephone"  data-val="true" data-val-required="Enter your telephone"/>
                    <p>City</p>
                    <input type="text"  name="city" class="textInput" data-val="true" data-val-required="Enter your city"/>
                    <p >Select Competition</p>
                    <input  type="checkbox" name="pubg" id="pubg" value="true" runat="server"/> <label for="pubgCheckBox">PUBG</label><br />
                    <input type="checkbox" name="fifa" id="fifa" value="true" runat="server"/> <label for="fifaCheckBox">FIFA</label><br /> 
                    <asp:CustomValidator ID="checkBoxValidator" runat="server" ErrorMessage="Pick either FIFA or PUBG"
                        OnServerValidate="CheckBoxServerCheck" ForeColor="Red" EnableClientScript="true" ClientValidationFunction="CheckBoxClientFunction">
                    </asp:CustomValidator>
                    <button type="submit">Let's go peeps</button>
                </form>
            </section>        
        </div>
        <footer>
            <nav>
                <a href="about.aspx">ABOUT</a>
                <a href="contact.aspx">CONTACT</a>                
                <a href="https://www.instagram.com/fifapubrussia/"><img src="/Images/Instagram.png"/></a>     
                <img src="/Images/Facebook.png"/>
                <img src="/Images/Youtube.png"/>
                <img src="/Images/Twitter.png" />
            </nav>            
        </footer>
</body>
</html>
<script type="text/javascript">
        <!--
    function CheckBoxClientFunction(source, args) {
        var fifaCheckBox = document.getElementById('pubg');
        var pubgCheckBox = document.getElementById('fifa');
        if (!fifaCheckBox.checked && !pubgCheckBox.checked) {           
            args.IsValid = false;
        } else {
            args.IsValid = true;
        }
    }
</script>
    