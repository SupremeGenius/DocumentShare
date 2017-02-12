<%@ Page Title="" Language="C#" MasterPageFile="~/user/MasterPage.master" AutoEventWireup="true" CodeFile="frmshr.aspx.cs" Inherits="user_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
        <h3>&nbsp;</h3>
        <table class="nav-justified">
            <tr>
                <td class="modal-sm" colspan="2" style="height: 32px">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="modal-sm" style="width: 171px">Share With</td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" Height="21px" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" RepeatDirection="Horizontal" Width="285px">
                        <asp:ListItem Value="U">User</asp:ListItem>
                        <asp:ListItem Value="G">Group</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="modal-sm" style="width: 171px">
                    <asp:Label ID="Label2" runat="server" Text="Enter Email" Visible="False"></asp:Label>
                    <asp:Label ID="Label3" runat="server" Text="Select Group" Visible="False"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource1" DataTextField="grpnam" DataValueField="grpcod" Visible="False">
                    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Share" Visible="False" Width="92px" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label4" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="GridView1" runat="server" Width="629px" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2" DataKeyNames="shrcod" Height="122px" OnRowDeleting="GridView1_RowDeleting">
                        <Columns>
                            <asp:BoundField DataField="shrdat" DataFormatString="{0:d}" HeaderText="Shared On" />
                            <asp:BoundField DataField="name" HeaderText="Shared With" />
                            <asp:TemplateField>
                                <ItemTemplate>
                <asp:LinkButton ID="lk1" runat ="server" CommandName="Delete"
                    text="Remove Sharing" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="modal-sm" style="width: 171px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="modal-sm" style="width: 171px">&nbsp;</td>
                <td>
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="dspmygrp" TypeName="nsdoc.clsgrp">
                        <SelectParameters>
                            <asp:SessionParameter Name="usrcod" SessionField="cod" Type="Int32" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                    <br />
                    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="docshrwit" TypeName="nsdoc.clsdoc">
                        <SelectParameters>
                            <asp:QueryStringParameter Name="doccod" QueryStringField="dcod" Type="Int32" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </td>
            </tr>
        </table>
   <!--</form> -->
</asp:Content>

