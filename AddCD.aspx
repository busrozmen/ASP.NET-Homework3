<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddCD.aspx.cs" Inherits="AddCD" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div align="center">
        <h1>Add New CD</h1>

        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Title</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Artist</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Year</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Duration</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="Button1" runat="server" Text="Save" OnClick="SaveButton_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button3" runat="server" Text="Reset" OnClick="ResetButton_Click" />

                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="LabelFail" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
    </div>
    <br />
</asp:Content>
