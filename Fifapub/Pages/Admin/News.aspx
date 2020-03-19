<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="Fifapub.Pages.Admin.WebForm1" %>

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
                <a href="<%=CreatePageLink("admin/Gallery") %>">Gallery</a>
                <a href="<%=CreatePageLink("admin/news") %>" class="selected">News</a>
                <a href="<%=CreatePageLink("admin/Winner") %>">Winners</a>
            </nav>              
        </header>
        <div>
            <h3>News</h3><br />
            <div id="errors"data-valmsg-summary="true">
                         <ul><li style="display:none"></li></ul>
                         <asp:ValidationSummary ID="ValidationSummary1" HeaderText="Please fix the following errors" runat="server"/> 
            </div> 
            <label>Header</label>
            <input type="text" name="title" data-val="true" data-val-required="Enter the header"/><br />
            <br />
            <label>Info</label>
            <textarea id="TextArea1" cols="100" rows="10" name="info" data-val="true" data-val-required="Enter the info"></textarea><br />
            <br />
            <label>Upload File</label>
            <input id="File1" type="file" accept="image/*" name="image" runat="server" data-val="true" data-val-required="upload the image"/><br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Only Doc files are allowed"
            ControlToValidate="File1" ValidationExpression="^(([a-zA-Z]:)|(\\{2}\w+)\$?)(\\(\w[\w].*))+(.jpg|.JPG|.gif|.GIF|.png|.PNG|.bmp|.BMP)$" ForeColor="Red">
            </asp:RegularExpressionValidator>
            <br />            
            <button type="submit">Submit</button>
        </div>
    </form>
</body>
</html>
