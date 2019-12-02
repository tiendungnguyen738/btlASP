<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="editColor.aspx.cs" Inherits="shopASP.editColor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="noidung" runat="server">
    <h4 style="margin-left: 31%;">Cập Nhật Màu Sản Phẩm</h4>
     <asp:Table ID="Table1" runat="server">
        <asp:TableRow>
            <asp:TableCell><label for="colorId">Mã Màu</label></asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="colorId" runat="server" Enabled="false"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>

         <asp:TableRow>
             <asp:TableCell><label for="colorId">Tên Màu</label></asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="colorName" runat="server" class="form-control"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <div style="margin-left: 33%;margin-top: 2%">
       <asp:Button id="edit" runat="server" Text="Edit" OnClick="edit_Click" class="btn btn-success" OnClientClick="return alert('Cập nhật thông tin thành công.')"/>
       <asp:Button Text="Danh Sách Màu" runat="server" PostBackUrl="~/color-ad.aspx" class="btn btn-primary"/>
    </div> 
</asp:Content>
