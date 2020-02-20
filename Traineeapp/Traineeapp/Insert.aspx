<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Insert.aspx.cs" Inherits="Traineeapp.WebForm1" %>

<asp:Content ID="myclass" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbtron">
        <asp:Label ID="Label1" runat="server" Text="tid"></asp:Label>
        <br />
        
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="must need id" ControlToValidate="TextBox1" ValidationGroup="vg"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label2" runat="server" Text="tname"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter the name" ControlToValidate="TextBox2" ValidationGroup="vg"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label3" runat="server" Text="location"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter the location" ControlToValidate="TextBox3" ValidationGroup="vg"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label4" runat="server" Text="techdomain"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Enter the domain" ControlToValidate="TextBox4" ValidationGroup="vg"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label5" runat="server" Text="date"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <hr/>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox5" ValidationGroup="vg"></asp:RequiredFieldValidator>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" ValidationGroup="vg" />
    </div>
</asp:Content>