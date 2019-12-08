<%@ Page Title="" Language="C#" MasterPageFile="~/HomeXQ/MasterPage.master" AutoEventWireup="true" CodeFile="XlAddOrder.aspx.cs" Inherits="Home_XlAddOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="tieude" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="noidung" Runat="Server">
    <form id="form1" runat="server">
       <div>

            <%
                
                Response.Redirect("/HomeXQ/product.aspx");
                //hienthitest();
                 %>
       </div>
    </form>
</asp:Content>

