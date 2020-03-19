<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Fifapub.Pages.HomePage" %>

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
        <article class="body">
            <img src="/Images/homeImage.jpg"/>
            <section class="news">
                <h3 class="category">NEWS</h3>
                <h3 class="seeMore"><a href="<%=CreatePageLink("News") %>">See More</a></h3>
                <div class="gridContainer">
                    <asp:Repeater ItemType="Fifapub.Models.New" ID="Repeater3" runat="server" SelectMethod="GetNews">
                        <ItemTemplate>                            
                            <div>
                                <img src="<%# MapURL(Item.Image) %>"/>
                                <div>
                                    <h5><%#Item.Title %></h5>
                                    <p>
                                        <%#Item.Info %>
                                    </p>
                                    <a href="News.aspx/#item<%#Item.NewsID%>">Read More</a>
                                </div>
                             </div> 
                        </ItemTemplate>
                    </asp:Repeater>                                       
                </div>
            </section>
            <section class="news">
                <h3 class="category">Gallery</h3>
                <h3 class="seeMore"><a href="<%=CreatePageLink("Gallery") %>">See More </a></h3>
                <div class="gridContainer">
                    <asp:Repeater ItemType="Fifapub.Models.Gallery" ID="Repeater1" runat="server" SelectMethod="GetGallery">
                        <ItemTemplate>                            
                            <div>
                                <img src="<%# MapURL(Item.image) %>" class="galleryPics"/>                        
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </section>
            <section class="news">
                <h3 class="category">Past Winners</h3>
                <h3 class="seeMore"><a href="<%=CreatePageLink("Winners") %>">See More </a></h3>
                <div class="gridContainer">
                    <asp:Repeater ItemType="Fifapub.Models.Winner" ID="Repeater2" runat="server" SelectMethod="GetWinner">
                        <ItemTemplate>                            
                            <div>
                                <img src="<%#MapURL(Item.Image) %>" class="winnerPics"/>                        
                                <h5 class="name">
                                    <%# Item.Name %>
                                </h5>                    
                            </div>        
                        </ItemTemplate>
                    </asp:Repeater>                    
                </div>
            </section>
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
