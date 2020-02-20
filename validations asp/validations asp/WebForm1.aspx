<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="WebForm1.aspx.cs" Inherits="validations_asp.WebForm1" %>

<asp:Content ID="asp" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <asp:Label ID="Label1" runat="server" Text="email id"></asp:Label>
        <br/>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="email must crrct formate" ControlToValidate="TextBox1" ForeColor="#3333FF" ValidationGroup="f" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">enter email id</asp:RegularExpressionValidator>
        <br />
        <asp:Label ID="Label2" runat="server" Text="password"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="enter password" ControlToValidate="TextBox2" ForeColor="Blue" ValidationGroup="f"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label3" runat="server" Text="match password"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
     <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="enter the same password" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ForeColor="Blue" ValidationGroup="f"></asp:CompareValidator>
        <br />
        <asp:Label ID="Label4" runat="server" Text="phnnumber"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
       <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="enter the phnno" ControlToValidate="TextBox4" ForeColor="Blue" MaximumValue="1000" MinimumValue="1" Type="Integer" ValidationGroup="f"></asp:RangeValidator>

        <br />
        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Blue" ValidationGroup="f" />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" ValidationGroup="f" />
        <br />

        </div>
</asp:Content>