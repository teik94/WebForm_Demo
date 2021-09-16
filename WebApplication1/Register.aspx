<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication1.Register" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Register Form</h2>
    <div class="container mt-2">
        <div class="form-group row">
            <asp:Label CssClass="col-md-1" ID="lblUsername" runat="server" Text="Username"></asp:Label>
            <asp:TextBox CssClass="col-md-4 form-control" ID="txtUsername" runat="server"></asp:TextBox>
        </div>
        <div class="form-group row">
            <asp:Label CssClass="col-md-1" ID="lblPassword" runat="server" Text="Password"></asp:Label>
            <asp:TextBox CssClass="col-md-4 form-control" ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
        </div>
        <div class="form-group row">
            <asp:Label CssClass="col-md-1" ID="lblEmail" runat="server" Text="Email"></asp:Label>
            <asp:TextBox CssClass="col-md-4 form-control" ID="txtEmail" runat="server"></asp:TextBox>
        </div>
        <div class="form-group row">
            <asp:Label CssClass="col-md-1" ID="lblAddress" runat="server" Text="Address"></asp:Label>
            <asp:TextBox CssClass="col-md-4 form-control" ID="txtAddress" runat="server"></asp:TextBox>
        </div>
        <div class="form-group row">
            <asp:Button ID="btnSubmit" OnClick="btnSubmit_Click" runat="server" Text="Submit" />
        </div>
        <% if (IsSucess)
            { %>
        <span style="color: green"><%: Message %></span>
        <% } %>
        <% else
        { %>
        <span style="color: red"><%: Message %></span>
        <% } %>
    </div>

    <asp:Button  ID="btnCheck" UseSubmitBehavior="false" OnClick="btnCheck_Click" runat="server" Text="Check" />

    <% foreach (var item in Get())
        { %>
    <div>
        <span style="color: green"><%: item.UserName %></span>
        <span style="color: green"><%: item.Password %></span>
        <span style="color: green"><%: item.Email %></span>
        <span style="color: green"><%: item.Address %></span>
    </div>
    
    <%} %>
</asp:Content>
