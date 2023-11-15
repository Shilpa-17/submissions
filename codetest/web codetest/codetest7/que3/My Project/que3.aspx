<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="que3.aspx.vb" Inherits="que3.que3" %>
<!-- Validator.aspx -->
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Validator</h1>
    <form action="Result.aspx" method="post">
        <label for="name">Name:</label>
        <input type="text" id="name" name="name" required><br><br>
        
        <label for="familyname">Family Name:</label>
        <input type="text" id="familyname" name="familyname" required><br><br>
        
        <label for="address">Address:</label>
        <input type="text" id="address" name="address" required><br><br>
        
        <label for="city">City:</label>
        <input type="text" id="city" name="city" required><br><br>
        
        <label for="zipcode">Zip Code:</label>
        <input type="text" id="zipcode" name="zipcode" required><br><br>
        
        <label for="phone">Phone:</label>
        <input type="text" id="phone" name="phone" required><br><br>
        
        <label for="email">E-mail Address:</label>
        <input type="email" id="email" name="email" required><br><br>
        
        <input type="submit" value="Check">
    </form>
        </div>
    </form>
</body>
</html>
