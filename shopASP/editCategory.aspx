<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="editCategory.aspx.cs" Inherits="shopASP.editCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="noidung" runat="server">
    <h3 style="margin-left: 31%;">Cập Nhật Thông Tin Hãng</h3>
    <asp:Table ID="Table1" runat="server">
        <asp:TableRow>
            <asp:TableCell><label for="categoryId">Id</label></asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="categoryId" runat="server" Enabled="false" ></asp:Label>
            </asp:TableCell>
        </asp:TableRow>

         <asp:TableRow>
            <asp:TableCell><label for="categoryName">Password</label></asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="categoryName" runat="server" class="form-control"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

         <asp:TableRow>
            <asp:TableCell><label for="image">Ảnh</label></asp:TableCell>
            <asp:TableCell>
                <asp:Image ID="image" runat="server" Width="100px" Height="50px"/>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell><label for="FileUpload1">Ảnh</label></asp:TableCell>
            <asp:TableCell>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <div style="margin-left: 33%;margin-top: 2%">
        <asp:Button id="edit" runat="server" Text="Edit" OnClick="edit_Click" class="btn btn-success" OnClientClick="return alert('Cập nhật thông tin thành công.')"/>
        <asp:Button Text="Danh Sách Hãng" ID="bntds" runat="server" PostBackUrl="~/category-ad.aspx" class="btn btn-primary"/>
    </div>   
</asp:Content>
