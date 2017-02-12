<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmreg.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
    <h4>
        Registration</h4>
        <table class="nav-justified">
            <tr>
                <td style="width: 169px; height: 28px">Enter Name</td>
                <td style="height: 28px">
                    <asp:TextBox ID="txtnam" runat="server" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 169px; height: 28px">Enter Email</td>
                <td style="height: 28px">
                    <asp:TextBox ID="txteml" runat="server" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 169px; height: 28px">Select Security Question</td>
                <td style="height: 28px">
                    <asp:DropDownList ID="drpqst" runat="server">
                        <asp:ListItem>What is name of your first teacher?</asp:ListItem>
                        <asp:ListItem>What is the name of brand of your first car?</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="width: 169px; height: 28px">Enter Security Answer</td>
                <td style="height: 28px">
                    <asp:TextBox ID="txtans" runat="server" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 169px; height: 28px">Enter Password</td>
                <td style="height: 28px">
                    <asp:TextBox ID="txtpwd" runat="server" TextMode="Password" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 169px; height: 28px">Enter Confirm Password</td>
                <td style="height: 28px">
                    <asp:TextBox ID="txtconpwd" runat="server" TextMode="Password" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 169px">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="Cancel" />
                </td>
            </tr>
            <tr>
                <td style="width: 169px">&nbsp;</td>
                <td>
                    <asp:Label ID="Label1" runat="server" Font-Size="Medium" ForeColor="#FF3300"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</asp:Content>

