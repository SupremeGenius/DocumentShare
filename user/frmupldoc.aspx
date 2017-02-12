<%@ Page Title="" Language="C#" MasterPageFile="~/user/MasterPage.master" AutoEventWireup="true" CodeFile="frmupldoc.aspx.cs" Inherits="user_Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
        <p>
            Upload New Document<asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        </p>
        <table class="nav-justified">
            <tr>
                <td style="width: 163px">Select List</td>
                <td style="width: 455px">
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource1" DataTextField="lstnam" DataValueField="lstcod">
                    </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkButton1" runat="server">Create List</asp:LinkButton>
                    <asp:ModalPopupExtender ID="LinkButton1_ModalPopupExtender" runat="server" DynamicServicePath="" Enabled="True" PopupControlID="Panel1" TargetControlID="LinkButton1">
                    </asp:ModalPopupExtender>
                </td>
            </tr>
            <tr>
                <td style="width: 163px">Document Title</td>
                <td style="width: 455px">
                    <asp:TextBox ID="TextBox1" runat="server" Width="400px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 163px">Document Description</td>
                <td style="width: 455px">
                    <asp:TextBox ID="TextBox2" runat="server" Height="178px" TextMode="MultiLine" Width="502px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 163px">For Sale</td>
                <td style="width: 455px">
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" Height="20px" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" RepeatDirection="Horizontal" Width="207px">
                        <asp:ListItem>Yes</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td style="width: 163px">
                    <asp:Label ID="Label1" runat="server" Text="Document Price" Visible="False"></asp:Label>
                </td>
                <td style="width: 455px">
                    <asp:TextBox ID="TextBox3" runat="server" Visible="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 163px">Browse File</td>
                <td style="width: 455px">
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
            </tr>
            <tr>
                <td style="width: 163px">&nbsp;</td>
                <td style="width: 455px">
                    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="Cancel" />
                &nbsp;&nbsp;&nbsp;
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="disp_rec" TypeName="nsdoc.clslst">
                        <SelectParameters>
                            <asp:SessionParameter Name="usrcod" SessionField="cod" Type="Int32" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </td>
            </tr>
            <tr>
                <td style="width: 163px">&nbsp;</td>
                <td style="width: 455px">
                    <asp:Panel ID="Panel1" runat="server" BackColor="#CCCCCC" BorderStyle="Solid" BorderWidth="5px" Height="192px">
                        <table class="nav-justified">
                            <tr>
                                <td style="width: 102px; height: 35px">
                                    <h1><strong>Lists</strong></h1>
                                </td>
                                <td style="height: 35px"></td>
                            </tr>
                            <tr>
                                <td style="width: 102px">List Title</td>
                                <td>
                                    <asp:TextBox ID="TextBox4" runat="server" Height="17px" Width="330px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 102px">&nbsp;</td>
                                <td>
                                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Submit" />
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Button ID="Button4" runat="server" Text="Cancel" />
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
        </table>

</asp:Content>

