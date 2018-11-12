<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BookInfo.aspx.cs" Inherits="BookInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <br />
    <asp:Label ID="label1" runat="server" Text="" Font-Bold="True"></asp:Label>
    <br />
    <br />
    <asp:DetailsView ID="DetailsView1" runat="server" align="center" AutoGenerateRows="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="BookID" DataSourceID="SqlDataSource1" GridLines="Vertical" ForeColor="Black">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <Fields>
            <asp:BoundField DataField="BookID" HeaderText="BookID" InsertVisible="False" ReadOnly="True" SortExpression="BookID" />
            <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
            <asp:BoundField DataField="Author" HeaderText="Author" SortExpression="Author" />
            <asp:BoundField DataField="Publisher" HeaderText="Publisher" SortExpression="Publisher" />
            <asp:BoundField DataField="PageNumber" HeaderText="PageNumber" SortExpression="PageNumber" />
            <asp:ImageField DataImageUrlField="CoverImage" HeaderText="CoverImage" ControlStyle-Width="100" ControlStyle-Height="150">
                <ControlStyle Height="150px" Width="100px"></ControlStyle>
            </asp:ImageField>
        </Fields>
        <FooterStyle BackColor="#CCCC99" />
        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#F7F7DE" />
    </asp:DetailsView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionStringBooks %>" ProviderName="<%$ ConnectionStrings:ConnectionStringBooks.ProviderName %>" SelectCommand="SELECT * FROM [Books] WHERE ([BookID] = @BookID)">
        <SelectParameters>
            <asp:QueryStringParameter Name="BookID" QueryStringField="bookID" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
</asp:Content>
