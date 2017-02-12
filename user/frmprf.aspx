<%@ Page Title="" Language="C#" MasterPageFile="~/user/MasterPage.master" AutoEventWireup="true" CodeFile="frmprf.aspx.cs" Inherits="user_Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
        <table class="nav-justified">
            <tr>
                <td style="width: 137px">
                    <h3>My Profile</h3>
                </td>
                <td>
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                </td>
            </tr>
            <tr>
                <td style="width: 137px">Select Location</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Chandigarh</asp:ListItem>
                        <asp:ListItem>Noida</asp:ListItem>
                        <asp:ListItem>Gurgaon</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="width: 137px">Date of Birth</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:CalendarExtender ID="TextBox1_CalendarExtender" runat="server" Enabled="True" TargetControlID="TextBox1">
                    </asp:CalendarExtender>
                </td>
            </tr>
            <tr>
                <td style="width: 137px">Gender</td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="22px" RepeatDirection="Horizontal" Width="211px">
                        <asp:ListItem Value="M">Male</asp:ListItem>
                        <asp:ListItem Value="F">Female</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td style="width: 137px">About Me</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Height="230px" TextMode="MultiLine" Width="490px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 137px">Profile Picture</td>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
            </tr>
            <tr>
                <td style="width: 137px">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="Cancel" />
                </td>
            </tr>
        </table>
  
</asp:Content>

