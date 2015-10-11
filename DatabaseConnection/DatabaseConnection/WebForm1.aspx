<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DatabaseConnection.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:gridview ID="Gridview1" runat="server" CellPadding="4" ForeColor="#333333" 
            GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:gridview>
    <br />
    Name:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
    Email:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
    Salary:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
    Dept:<asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />
    <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" /><br />
       <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>
    
    </form>
</body>
</html>

