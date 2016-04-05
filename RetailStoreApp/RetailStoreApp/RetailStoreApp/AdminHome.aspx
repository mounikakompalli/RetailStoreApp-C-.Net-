<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="RetailStoreApp.AdminHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="bootstrap/css/bootstrap.css" rel="stylesheet" />
    <script src="bootstrap/js/bootstrap.js"></script>
    <style>.mylist{
    display:inline;
}</style>
      <link rel="stylesheet" href="//code.jquery.com/ui/1.11.4/themes/smoothness/jquery-ui.css">
  <script src="//code.jquery.com/jquery-1.10.2.js"></script>
  <script src="//code.jquery.com/ui/1.11.4/jquery-ui.js"></script>
     <script>
  $(function() {
     
      $(".datepicker").datepicker({ maxDate: new Date() });
  });
  </script>
</head>
<body>
    <form id="form1" runat="server">
        <div >
            <h2 align="center">Admin Home</h2>
                <h3 align="center">Employee Details</h3>
            <h4 align="center">Add New Employee</h4>
            <table align="center">
                <tr><td>Employee Id</td><td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td></tr>
                <tr><td>SSN</td><td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td></tr>
                    <tr><td>Name</td><td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td></tr>
                    <tr><td>Sex</td><td>
                        <asp:RadioButtonList ID="RadioButtonList1" CssClass="mylist" runat="server" AutoPostBack="True" >
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:RadioButtonList></td></tr>
                    <tr><td>Job Title</td><td>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td></tr>
                    <tr><td>Employment begin date</td><td>
                        <asp:TextBox ID="TextBox5" runat="server" CssClass="datepicker"></asp:TextBox></td></tr>
                    <tr><td>Current Salary</td><td>
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td></tr>
                                <tr><td></td><td>
                                    <asp:Button ID="Button3" runat="server" Text="Add" OnClick="Button3_Click" /></td></tr>
            </table>
            <h4 align="center">Remove Existing Employee</h4>
            <table align="center"> 
                <tr><td>Employee Id</td><td>
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></td></tr>
                 
                 <tr><td></td><td>
                     <asp:Button ID="Button1" runat="server" Text="Remove" OnClick="Button1_Click" /></td></tr>

            </table>
            <h3 align="center">Merchandise</h3>
            <h4 align="center">Add New Item</h4>
            <table align="center">
                <tr><td>Item ID</td><td>
                    <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox></td></tr>
                <tr><td>Description</td><td>
                    <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox></td></tr>
                                <tr><td>Price</td><td>
                                    <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox></td></tr>
                                <tr><td></td><td>
                                    <asp:Button ID="Button2" runat="server" Text="Add" OnClick="Button2_Click" /></td></tr>
                <tr><td>
                    <asp:Label ID="Label1" runat="server" Text="Added Successfully"></asp:Label></td></tr>

            </table>
             <h4 align="center">Remove Item</h4>
            <table align="center"> <tr><td>Item ID</td><td>
                <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox></td></tr>
                <tr><td></td><td>
                    <asp:Button ID="Button4" runat="server" Text="Remove" OnClick="Button4_Click" /></td></tr>
                <tr><td></td><td>
                    <asp:Label ID="Label2" runat="server" Text="Removed Successully"></asp:Label></td></tr>
            </table>
            <h3 align="center">Store transfers </h3>
            <table align="center"><tr><td>Item ID</td><td>
                <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox></td></tr>
                <tr><td>Quantity</td><td>
                    <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
                    </td></tr>
                <tr><td>From Store</td><td>
                    <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList></td></tr>
                <tr><td>To Store</td><td>
                    <asp:DropDownList ID="DropDownList3" runat="server"></asp:DropDownList></td></tr>
                <tr><td></td><td>
                    <asp:Button ID="Button5" runat="server" Text="Transfer" /></td></tr>

            </table>


               
        </div>
        <div>
            <h3 align="center">View Employees</h3>
            <p align="center"><asp:GridView ID="GridView1" runat="server" CssClass="table table-hover"></asp:GridView></p>
            <h3 align="center">View Merchandise</h3>
              <p align="center">
                  <asp:GridView ID="GridView2" runat="server" CssClass="table table-hover"></asp:GridView>
              </p>


            </div>
    </form>
</body>
</html>
