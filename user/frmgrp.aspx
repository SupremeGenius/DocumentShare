<%@ Page Title="" Language="C#" MasterPageFile="~/user/MasterPage.master" AutoEventWireup="true" CodeFile="frmgrp.aspx.cs" Inherits="user_Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

        <p>
            Groups<asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton1" runat="server">Create New Group</asp:LinkButton>
            <asp:ModalPopupExtender ID="LinkButton1_ModalPopupExtender" runat="server" DynamicServicePath="" Enabled="True" PopupControlID="Panel1" TargetControlID="LinkButton1">
            </asp:ModalPopupExtender>
            &nbsp;</p>
        <p>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" Width="758px">
                <Columns>
                    <asp:TemplateField HeaderText="Group Title">
                        <ItemTemplate>
            <a href="frmgrpdet.aspx?gcod=<%#Eval("grpcod") %>">
                <%#Eval("grpnam") %>
            </a>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="grpcrtdat" DataFormatString="{0:d}" HeaderText="Created Date" SortExpression="grpcrtdat" />
                    <asp:BoundField DataField="grpdsc" HeaderText="Description" SortExpression="grpdsc" />
                </Columns>
            </asp:GridView>
        </p>
        <p>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="dspmygrp" TypeName="nsdoc.clsgrp">
                <SelectParameters>
                    <asp:SessionParameter Name="usrcod" SessionField="cod" Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </p>
        <asp:Panel ID="Panel1" runat="server" BackColor="#CCCCCC" BorderStyle="Solid" BorderWidth="5px" Height="220px" Width="483px">
            <table class="nav-justified" style="height: 206px">
                <tr>
                    <td style="width: 127px">Create New Group</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 127px">Group Title</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Width="335px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 127px">Group Description</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Height="110px" TextMode="MultiLine" Width="344px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 127px">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button2" runat="server" Text="Cancel" />
                    </td>
                </tr>
            </table>
        </asp:Panel>

</asp:Content>

