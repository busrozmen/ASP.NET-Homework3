<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CDs.aspx.cs" Inherits="CDs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:GridView ID="GridView1" align="center" runat="server" AutoGenerateColumns="False" BackColor="White" AllowPaging="True" PageSize="5" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="CDID" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField Visible="false" DataField="CDID" HeaderText="CDID" InsertVisible="False" ReadOnly="True" SortExpression="CDID" />
            <asp:HyperLinkField DataNavigateUrlFields="CDID" DataNavigateUrlFormatString="CDInfo.aspx?cdID={0}" DataTextField="Title" HeaderText="Title" />
            <asp:BoundField DataField="Artist" HeaderText="Artist" SortExpression="Artist" />
            <asp:BoundField DataField="Year" HeaderText="Year" SortExpression="Year" />
            <asp:BoundField DataField="Duration" HeaderText="Duration" SortExpression="Duration" />
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
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionStringBooks %>" ProviderName="<%$ ConnectionStrings:ConnectionStringBooks.ProviderName %>" SelectCommand="SELECT * FROM [CDs] ORDER BY CDID DESC"></asp:SqlDataSource>
    <br />
    <br />
</asp:Content>
