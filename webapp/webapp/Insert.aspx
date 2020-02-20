<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Insert.aspx.cs" Inherits="webapp.Insert" %>

<asp:Content id="cid" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <asp:Label ID="Label1" runat="server" Text="student id"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="course"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" Text="start date"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <hr/>
        <asp:Button ID="Button1" OnClick="Button1_Click" runat="server" Text="Insert" />
    </div>
</asp:Content>
