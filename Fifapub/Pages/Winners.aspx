<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Winners.aspx.cs" Inherits="Fifapub.Pages.Winners" %>

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
                <a href="<%=CreatePageLink("Registration") %>">Registration</a>
                <a href="<%=CreatePageLink("News") %>">News</a>
                <a href="<%=CreatePageLink("Winners") %>" class="selected">Winners</a>
            </nav>              
        </header>
        <article>
            <asp:Repeater ID="Repeater1" ItemType="Fifapub.Models.Event" runat="server" SelectMethod="GetEvent">
                <ItemTemplate>
                    <section class ="winners">
                        <h2 class="winnersGrid1"><%#:Item.EventName%></h2>
                        <img src="<%# MapURL(getFifaWinnerImage(Item.EventId)) %>" class="winnersGrid2"/>
                        <p class="winnersGrid3"><%# getFifaWinnerName(Item.EventId) %></p>
                        <p class="winnersGrid4">FIFAPUB</p>
                        <img src="<%# MapURL(getPUBGWinnerImage(Item.EventId)) %>" class="winnersGrid5"/>
                        <p class="winnersGrid6"><%# getPUBGWinnerName(Item.EventId) %></p>
                        <p class="winnersGrid7">PUBG</p>
                    </section>
                </ItemTemplate>
            </asp:Repeater>
        </article>
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
    </form>
</body>
</html>
