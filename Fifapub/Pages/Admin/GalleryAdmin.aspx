<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GalleryAdmin.aspx.cs" Inherits="Fifapub.Pages.Admin.GalleryAdmin1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link rel="stylesheet" href="~/Content/Styles.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <img src="/Images/logo.png" alt="logo"/>
            <a href="<%=CreatePageLink("admin/Gallery") %>"><img src="/Images/Icon_user_cirlce.png" alt ="userProfile" id="userProfile"/></a>            
            <nav>                
                <a href="<%=CreatePageLink("admin/Gallery") %>" class="selected">Gallery</a>
                <a href="<%=CreatePageLink("admin/news") %>">News</a>
                <a href="<%=CreatePageLink("admin/Winner") %>">Winners</a>
            </nav>              
        </header>
        <div>            
            <h3>Gallery</h3>
            <br />
            <asp:FileUpload ID="FileUpload1" runat="server" multiple="multiple"/>
            <br />            
            <br />
            <button type="submit">Upload</button>
        </div>
    </form>
</body>
</html>
