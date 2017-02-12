<%@ Page Title="" Language="C#" MasterPageFile="~/user/MasterPage.master" AutoEventWireup="true" CodeFile="frmpur.aspx.cs" Inherits="user_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
        <p>
            Purchase Documents</p>
        <p>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" Width="729px" DataKeyNames="doccod,docprc" OnRowEditing="GridView1_RowEditing" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="doctit" HeaderText="Title" />
                    <asp:BoundField DataField="docprc" HeaderText="Price" />
                    <asp:BoundField DataField="docdsc" HeaderText="Description" />
                    <asp:TemplateField>
    <ItemTemplate>
        <asp:LinkButton ID="lk1" runat ="server" CommandName="Edit"
            text="Purchase" />
    </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </p>
        <p>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="dspdocforsal" TypeName="nsdoc.clsdoc"></asp:ObjectDataSource>
        </p>

</asp:Content>

