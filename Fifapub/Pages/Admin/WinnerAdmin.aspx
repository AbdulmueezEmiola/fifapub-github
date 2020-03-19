<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WinnerAdmin.aspx.cs" Inherits="Fifapub.Pages.Admin.WinnerAdmin1" %>

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
                <a href="<%=CreatePageLink("admin/news") %>">News</a>
                <a href="<%=CreatePageLink("admin/Winner") %>" class="selected">Winners</a>
            </nav>              
        </header>
        <div>
            <div id="errors" data-valmsg-summary="true">
                         <ul><li style=" display:none"></li></ul>
                         <asp:ValidationSummary ID="ValidationSummary1" HeaderText="Please fix the following errors" runat="server"/> 
            </div> 
            <h3>Winner</h3>
            <br />
            <label>Name</label>
            <input type="text" name="name" data-val="true" data-val-required="Enter the name"/>
            <br />
            <br />
            <label>Select Category</label><br />
            <asp:RadioButton name="fifa" ID="fifa" GroupName="category" runat="server" Text="fifa" />
            <asp:RadioButton name="pubg" id="pubg" GroupName="category" runat="server" Text="pubg" />
            <br />
            <asp:CustomValidator ID="checkBoxValidator" runat="server" ErrorMessage="Pick either FIFA or PUBG"
                        OnServerValidate="RadioButtonServerCheck" ForeColor="Red" EnableClientScript="true" ClientValidationFunction="CheckBoxClientFunction">
                    </asp:CustomValidator>
            <br />
            <label>Upload image</label><br />
            <input type="file" accept="image/*" name="image" id="image" runat="server" data-val="true" data-val-required="Upload the image"/><br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Only image files are allowed"
            ControlToValidate="image" ValidationExpression="^(([a-zA-Z]:)|(\\{2}\w+)\$?)(\\(\w[\w].*))+(.jpg|.JPG|.gif|.GIF|.png|.PNG|.bmp|.BMP)$" ForeColor="Red">
            </asp:RegularExpressionValidator>
            <br />
            <button type="submit">Submit</button>
        </div>
    </form>
</body>
</html>
