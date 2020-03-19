<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gallery.aspx.cs" Inherits="Fifapub.Pages.Gallery1" %>

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
                <a href="<%=CreatePageLink("Gallery") %>" class="selected">Gallery</a>
                <a href="<%=CreatePageLink("Registration") %>">Registration</a>
                <a href="<%=CreatePageLink("News") %>">News</a>
                <a href="<%=CreatePageLink("Winners") %>">Winners</a>
            </nav>              
        </header>
        <article>
            <ul>
                <asp:Repeater ItemType="Fifapub.Models.Event" ID="Repeater3" runat="server" SelectMethod="GetEvent">
                        <ItemTemplate>                            
                            <li>
                                <%# Item.EventName %>
                                <span class="dateGallery"><%# Item.date %></span>                                 
                                <div>   
                                    <asp:HiddenField runat="server" ID="ItemId" Value="<%# Item.EventId %>"/>
                                    <asp:Repeater ItemType="Fifapub.Models.Gallery" ID="Repeater4" runat="server" SelectMethod="GetGallery">
                                        <ItemTemplate>                            
                                            <img src="<%# MapURL(Item.image) %>"/>                        
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </div>
                            </li>
                        </ItemTemplate>
                    </asp:Repeater>                
            </ul>
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
