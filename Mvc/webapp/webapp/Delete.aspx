<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="webapp.Delete" %>

<asp:Content ID="delete" ContentPlaceHolderID="MainContent" runat="server">
    <div class="devil">
        <asp:Label ID="Label1" runat="server" Text="enter id"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
</asp:Content>