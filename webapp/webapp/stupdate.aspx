<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="stupdate.aspx.cs" Inherits="webapp.stupdate" %>

<asp:Content runat="server" id="Doj" ContentPlaceHolderID="MainContent">
    <div class="jumbotron">
        <asp:Label ID="Label1" runat="server" Text="enter old date"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="enter the name"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
</asp:Content>