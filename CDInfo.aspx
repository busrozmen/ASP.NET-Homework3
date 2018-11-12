<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CDInfo.aspx.cs" Inherits="CDInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <br />
    <asp:Label ID="label1" runat="server" Text="" Font-Bold="True"></asp:Label>
    <br />
    <br />
    <asp:DetailsView ID="DetailsView1" runat="server" align="center" AutoGenerateRows="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="CDID" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <Fields>
            <asp:BoundField DataField="CDID" HeaderText="CDID" InsertVisible="False" ReadOnly="True" SortExpression="CDID" />
            <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
            <asp:BoundField DataField="Artist" HeaderText="Artist" SortExpression="Artist" />
            <asp:BoundField DataField="Year" HeaderText="Year" SortExpression="Year" />
            <asp:BoundField DataField="Duration" HeaderText="Duration" SortExpression="Duration" />
        </Fields>
        <FooterStyle BackColor="#CCCC99" />
        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#F7F7DE" />
    </asp:DetailsView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionStringBooks %>" ProviderName="<%$ ConnectionStrings:ConnectionStringBooks.ProviderName %>" SelectCommand="SELECT * FROM [CDs] WHERE ([CDID] = @CDID)">
        <SelectParameters>
            <asp:QueryStringParameter Name="CDID" QueryStringField="cdID" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
    <br />
</asp:Content>
