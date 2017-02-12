<%@ Page Title="" Language="C#" MasterPageFile="~/user/MasterPage.master" AutoEventWireup="true" CodeFile="frmgrpdet.aspx.cs" Inherits="user_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
        <table class="nav-justified">
            <tr>
                <td style="width: 374px">
                    <asp:DataList ID="DataList1" runat="server" DataSourceID="ObjectDataSource1" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" Width="505px">
                        <ItemTemplate>
               <h2><%#Eval("grpnam") %></h2>
                <h5>Created On:<%#Eval("grpcrtdat","{0:d}") %></h5>
  <h5>Created By:<%#getnam(Convert.ToInt32(Eval("grpownusrcod"))) %></h5>
    <p><%#Eval("grpdsc") %></p>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                <td>
                    <asp:Panel ID="Panel1" runat="server">
                        <table class="nav-justified">
                            <tr>
                                <td colspan="2" style="height: 35px">Add Group Members</td>
                            </tr>
                            <tr>
                                <td style="width: 96px">Enter Email</td>
                                <td>
                                    <asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="259px"></asp:TextBox>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="448px" DataKeyNames="usrcod,sts" OnRowDataBound="GridView1_RowDataBound" OnRowEditing="GridView1_RowEditing">
                                        <Columns>
                                            <asp:TemplateField HeaderText="Search Results">
                                                <ItemTemplate>
                                                    <table class="nav-justified">
                                                        <tr>
                                                            <td rowspan="3" style="width: 135px">
                                                        <img src="../prfpic/<%#Eval("usrcod") %><%#Eval("prfpic") %>"
                                                            height="90px" width="90px" />
                                                            </td>
                                                            <td>
                                                                <b><%#Eval("usrnam") %></b>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <%#Eval("prfdsc") %>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                     <asp:LinkButton ID="lk1" runat ="server" CommandName="Edit"
                                                         text="Join Group" />
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>
                                    <br />
                                    </td>
                            </tr>
                        </table>
                    </asp:Panel>
                    <asp:DataList ID="DataList2" runat="server" DataSourceID="ObjectDataSource2" RepeatColumns="2" RepeatDirection="Horizontal" Width="450px" DataKeyField="grpmemcod" OnEditCommand="DataList2_EditCommand">
                    <ItemTemplate>
         <table class="nav-justified">
                                                        <tr>
                                                            <td rowspan="3" style="width: 135px">
                                                        <img src="../prfpic/<%#Eval("usrcod") %><%#Eval("prfpic") %>"
                                                            height="90px" width="90px" />
                                                            </td>
                                                            <td>
                                                                <b><%#Eval("usrnam") %></b>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <%#Eval("prfdsc") %>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                     <asp:LinkButton ID="lk1" runat ="server" CommandName="Edit"
                                                         text="Unjoin Group" />
                                                            </td>
                                                        </tr>
                                                    </table>

                    </ItemTemplate>
                    </asp:DataList>
                    <br />
                    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="dspgrpmem" TypeName="nsdoc.clsgrpmem">
                        <SelectParameters>
                            <asp:QueryStringParameter Name="grpcod" QueryStringField="gcod" Type="Int32" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </td>
            </tr>
            <tr>
                <td colspan="2">Posts<br />
                    <table class="nav-justified">
                        <tr>
                            <td colspan="2">
                                <asp:TextBox ID="TextBox2" runat="server" Height="81px" style="margin-right: 402" TextMode="MultiLine" Width="688px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 89px">&nbsp;</td>
                            <td>
                                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Post" Width="153px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:GridView ID="GridView2" runat="server" DataSourceID="ObjectDataSource3" Width="769px">
                                </asp:GridView>
                                <br />
                                <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="dispst" TypeName="nsdoc.clspst">
                                    <SelectParameters>
                                        <asp:QueryStringParameter Name="grpcod" QueryStringField="gcod" Type="Int32" />
                                    </SelectParameters>
                                </asp:ObjectDataSource>
                            </td>
                        </tr>
                    </table>
                    <br />
                    <br />
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="find_rec" TypeName="nsdoc.clsgrp">
                        <SelectParameters>
                            <asp:QueryStringParameter Name="grpcod" QueryStringField="gcod" Type="Int32" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </td>
            </tr>
        </table>

</asp:Content>

