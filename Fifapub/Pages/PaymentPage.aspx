<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaymentPage.aspx.cs" Inherits="Fifapub.Pages.PaymentPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <link rel="stylesheet" href="/Content/Styles.css"/>
</head>
<body>
        <header>
            <img src="/Images/logo.png" alt="logo"/>
            <img src="/Images/Icon_user_cirlce.png" alt ="userProfile" id="userProfile"/>
            <nav>
                <a href="<%=CreatePageLink("Home") %>" >Home</a>
                <a href="<%=CreatePageLink("Gallery") %>">Gallery</a>
                <a href="<%=CreatePageLink("Registration") %>"class="selected">Registration</a>
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
                <form id="form1" runat="server" method="POST" action="https://money.yandex.ru/quickpay/confirm.xml">
                    <input type="hidden" name="receiver" value="4100111778907666"/> 
                    <input type="hidden" name="formcomment" value="Fifapub, a gaming community"/>
                    <input type="hidden" name="short-dest" value="Fifapub, a gaming community"/>
                    <input type="hidden" name="label" value="$order_id"/>
                    <input type="hidden" name="quickpay-form" value="donate"/>
                    <input type="hidden" name="targets" value="playerId"/>
                    <input type="hidden" name="sum" value="1500" data-type="number"/>
                    <input type="hidden" name="comment" value="To register to play the game"/>
                    <input type="hidden" name="need-fio" value="true"/>
                    <input type="hidden" name="need-email" value="true"/>
                    <input type="hidden" name="need-phone" value="true"/>
                    <input type="hidden" name="need-address" value="false"/>
                    <label><input type="radio" name="paymentType" value="AC"/>Банковской картой</label> 
                    <button type="submit" value="Перевести"/>
                </form>      
            </section>        
        </div>    
</body>
</html>
