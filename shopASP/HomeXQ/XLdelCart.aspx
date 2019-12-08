<%@ Page Title="" Language="C#" MasterPageFile="~/HomeXQ/MasterPage.master" AutoEventWireup="true" CodeFile="XLdelCart.aspx.cs" Inherits="Home_XLdelCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="tieude" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="noidung" Runat="Server">
    <%Response.Write("Hello : " + Request.QueryString["id"].ToString()); %>
    <input id='command' runat="server" name="command111" type="Text" value='1' hidden="" />";
</asp:Content>

