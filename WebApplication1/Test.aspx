<%@ Page Async="True" Title="Test" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="WebApplication1.Test" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group">
        <asp:Label ID="lblUserName" runat="server" Text="UserName"></asp:Label> <asp:TextBox ID="txtUserName" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label> <asp:TextBox ID="txtPassword" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Button CssClass="btn btn-primary" ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        <asp:Button CssClass="btn btn-primary" ID="Button1" runat="server" Text="Login2" OnClick="btnLogin2_Click" />
    </div>

    <% if(IsSucess) { %>
   <span style="color: green"><%: Message %></span>
    <% } %>
    <% else { %>
    <span style="color: red"><%: Message %></span>
    <% } %>
    

</asp:Content>




