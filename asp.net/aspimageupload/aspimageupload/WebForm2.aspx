<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="WebForm2.aspx.cs" Inherits="aspimageupload.WebForm2" %>

<asp:Content ID="Content1"  ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <br />
        <asp:Button ID="Button2_click" runat="server" Text="Button" OnClick="Button2_click" />


        <br />
        <br />
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="2">
        <ItemTemplate>
            <asp:Image ID="Image1"
                Imageurl='<%# Eval("name","~/images/{0}") %>'
                width="350px" height="350px" runat="server" />
            <br />
            <%#Eval("name") %>
        </ItemTemplate>
            </asp:DataList>
    </div>
</asp:Content>