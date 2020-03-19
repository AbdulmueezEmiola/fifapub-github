<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="Fifapub.Pages.News" %>

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
                <a href="<%=CreatePageLink("Home") %>" class="selected">Home</a>
                <a href="<%=CreatePageLink("Gallery") %>">Gallery</a>
                <a href="<%=CreatePageLink("Registration") %>">Registration</a>
                <a href="<%=CreatePageLink("News") %>">News</a>
                <a href="<%=CreatePageLink("Winners") %>">Winners</a>
            </nav>              
        </header>
        <article>
            <asp:Repeater ID="Repeater1" runat="server" SelectMethod="GetNews" ItemType="Fifapub.Models.New">
                <ItemTemplate>
                    <section class="newsSection" id="<%# Item.NewsID %>">
                        <h5><%#:Item.Title %></h5>
                        <h6><%#: Item.Date %></h6>
                        <img<%#: MapURL(Item.Image) %>/>                
                        <p>
                            <%#: Item.Info %>
                        </p>                
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
