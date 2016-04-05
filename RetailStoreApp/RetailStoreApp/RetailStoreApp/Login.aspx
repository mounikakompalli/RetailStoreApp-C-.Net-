<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RetailStoreApp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
    <link href="bootstrap/css/bootstrap.css" rel="stylesheet" />
    <script src="bootstrap/js/bootstrap.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2 align="center">Retail Store</h2>
        Please select the place you are operating from..
        <table >
           <tr> <td>State</td><td>
               <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true">
                   <asp:ListItem>Select State...</asp:ListItem>
                   <asp:ListItem>Virginia</asp:ListItem>
                   <asp:ListItem>California</asp:ListItem>
                   <asp:ListItem>Texas</asp:ListItem>
                   <asp:ListItem>Florida</asp:ListItem>
                   <asp:ListItem>Missouri</asp:ListItem>
               </asp:DropDownList></td></tr>
               <tr> <td>Region</td><td>
                   <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"></asp:DropDownList></td></tr>
               <tr> <td>Zone</td><td>
                   <asp:DropDownList ID="DropDownList3" runat="server"></asp:DropDownList></td></tr>
               <tr> <td>Retail-Store</td><td>
                   <asp:DropDownList ID="DropDownList4" runat="server"></asp:DropDownList></td></tr>
            </table>
        <h4 align="center">Log In?</h4>
        <table align="center">
            <tr><td>Login as:</td><td>
                <asp:DropDownList ID="DropDownList5" runat="server">
                    <asp:ListItem>Select User..</asp:ListItem>
                    <asp:ListItem>Admin</asp:ListItem>
                    <asp:ListItem>Salesman</asp:ListItem>
                    <asp:ListItem>Customer</asp:ListItem>
                </asp:DropDownList></td></tr>
            <tr><td>User Id</td><td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td></tr>
                <tr><td>Password</td><td>
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox></td></tr>
                <tr><td></td><td>
                    <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" /></td></tr>
            </table>
         <h4 align="center">Sign Up?</h4>
        <table align="center">
        <tr><td class="auto-style1">First Name</td><td class="auto-style1">
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td></tr>
          <tr><td class="auto-style1">Last Name</td><td class="auto-style1">
              <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td></tr>
          <tr><td>User Id</td><td>
              <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td></tr>
          <tr><td>Password</td><td>
              <asp:TextBox ID="TextBox6" runat="server" TextMode="Password"></asp:TextBox></td></tr>
                <tr><td>Re-enter Password</td><td>
                    <asp:TextBox ID="TextBox7" runat="server" TextMode="Password"></asp:TextBox></td></tr>
                <tr><td></td><td>
                    <asp:Button ID="Button2" runat="server" Text="Sign Up" OnClick="Button2_Click" /></td></tr>
            
            </table>
    
    </div>
    </form>
</body>
</html>
