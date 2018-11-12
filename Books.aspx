<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Books.aspx.cs" Inherits="Books" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" align="center" BackColor="White" AllowPaging="True" PageSize="5" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" AutoGenerateColumns="False" DataSourceID="SqlDataSourceBooks" DataKeyNames="BookID">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField Visible="false" DataField="BookID" HeaderText="BookID" SortExpression="BookID" InsertVisible="False" ReadOnly="True" />
            <asp:ImageField DataImageUrlField="CoverImage" HeaderText="CoverImage" ControlStyle-Width="100" ControlStyle-Height="150"></asp:ImageField>
            <asp:HyperLinkField DataNavigateUrlFields="BookID" DataNavigateUrlFormatString="BookInfo.aspx?bookID={0}" DataTextField="Title" HeaderText="Title" />
            <asp:BoundField DataField="Author" HeaderText="Author" SortExpression="Author" />
            <asp:BoundField DataField="Publisher" HeaderText="Publisher" SortExpression="Publisher" />
            <asp:BoundField DataField="PageNumber" HeaderText="PageNumber" SortExpression="PageNumber" />
        </Columns>
        <FooterStyle BackColor="#CCCC99" />
        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#F7F7DE" />
        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FBFBF2" />
        <SortedAscendingHeaderStyle BackColor="#848384" />
        <SortedDescendingCellStyle BackColor="#EAEAD3" />
        <SortedDescendingHeaderStyle BackColor="#575357" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSourceBooks" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionStringBooks %>" ProviderName="<%$ ConnectionStrings:ConnectionStringBooks.ProviderName %>" SelectCommand="SELECT * FROM [Books] ORDER BY BookID DESC "></asp:SqlDataSource>
    <br />
</asp:Content>
