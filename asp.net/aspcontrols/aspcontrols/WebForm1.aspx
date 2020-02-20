<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="WebForm1.aspx.cs" Inherits="aspcontrols.WebForm1" %>

<asp:Content ID="my" ContentPlaceHolderID="MainContent" runat="server">
    <div id="jumbotron" style="text-align: left; color: #CC00CC">
        <asp:Label ID="Label1" runat="server" Text="enter name"></asp:Label>
        <br />
        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="enter dob"></asp:Label>
        <br />
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Gender"></asp:Label>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" BorderColor="#66CCFF" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
            <asp:ListItem>male</asp:ListItem>
            <asp:ListItem>female</asp:ListItem>

        </asp:RadioButtonList>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Hobbies"></asp:Label>
        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>dancing</asp:ListItem>
            <asp:ListItem>singing</asp:ListItem>
            <asp:ListItem>reading</asp:ListItem>
        </asp:CheckBoxList>
        
        <br />
        <asp:Label ID="Label5" runat="server" Text="Education"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br/>
        <br />
        <asp:Button ID="Btn1" runat="server" Text="Button" OnClick="Btn1_Click" BorderColor="Fuchsia" />


    </div>
    <div class="jumbtron">
        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
    </div>
</asp:Content>