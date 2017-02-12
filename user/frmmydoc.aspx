<%@ Page Title="" Language="C#" MasterPageFile="~/user/MasterPage.master" AutoEventWireup="true" CodeFile="frmmydoc.aspx.cs" Inherits="user_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

        <p>
            My Documents</p>
        <table class="nav-justified">
            <tr>
                <td style="width: 202px">
                    <asp:DataList ID="DataList1" runat="server" DataSourceID="ObjectDataSource1" DataKeyField="lstcod" Height="118px" OnEditCommand="DataList1_EditCommand" Width="205px">
                    <ItemTemplate>
   <asp:LinkButton ID="lk1" runat ="server" CommandName="Edit" Text=<%#Eval("lstnam") %> >
   </asp:LinkButton>(<%#Eval("nod") %>)
                    </ItemTemplate>
                    </asp:DataList>
                </td>
                <td>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="735px" Height="132px">
                        <Columns>
                            <asp:TemplateField HeaderText="Title">
                    <ItemTemplate>
        <a href="frmdocdet.aspx?dcod=<%#Eval("doccod") %>"><%#Eval("doctit") %></a>
                    </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="docupldat" DataFormatString="{0:d}" HeaderText="Uploaded Date" />
                            <asp:BoundField DataField="docdsc" HeaderText="Description" >
                            <ItemStyle Width="400px" />
                            </asp:BoundField>
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td style="width: 202px">
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="dsplstcnt" TypeName="nsdoc.clslst">
                        <SelectParameters>
                            <asp:SessionParameter Name="usrcod" SessionField="cod" Type="Int32" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </td>
                <td>
                    <h3>Shared Documents</h3>
                    
                        <asp:GridView ID="GridView2" runat="server" Width="718px" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2">
                            <Columns>
                              <asp:TemplateField HeaderText="Title">
                    <ItemTemplate>
        <a href="frmdocdet.aspx?dcod=<%#Eval("doccod") %>"><%#Eval("doctit") %></a>
                    </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="docupldat" DataFormatString="{0:d}" HeaderText="Uploaded Date" />
                            <asp:BoundField DataField="docdsc" HeaderText="Description" >
                            <ItemStyle Width="400px" />
                            </asp:BoundField>
                            </Columns>
                        </asp:GridView>
                    
                    <br />
                    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="dspmyshrdoc" TypeName="nsdoc.clsdoc">
                        <SelectParameters>
                            <asp:SessionParameter Name="usrcod" SessionField="cod" Type="Int32" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                    
                </td>
            </tr>
        </table>

</asp:Content>

