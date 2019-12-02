<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="editProductDetail.aspx.cs" Inherits="shopASP.editProductDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="noidung" runat="server">
    <h4 style="color:blue;margin-top: 1%; margin-left: 32%;">Cập Nhật Số Lượng Và Màu Điện Thoại</h4>
    <asp:Table ID="Table1" runat="server" Width="317px">
        <asp:TableRow>
            <asp:TableCell>
                <label for="product_name" class="col-form-label" style="margin-left: -5%">Tên Điện Thoại</label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="product_name" runat="server" Text="Label" class="form-control"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:HiddenField ID="product_detail_id" runat="server" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <label for="dsmau" class="col-form-label" style="margin-left: -5%">Màu</label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="dsmau" runat="server" class="form-control"></asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>
         <asp:TableRow>
            <asp:TableCell>
                <label for="soluong" class="col-form-label" style="margin-left: -5%">Số Lượng</label>
            </asp:TableCell>
            <asp:TableCell>
                <input id="soluong" type="text" runat="server" class="form-control"/>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <div style="margin-left:39%;margin-top: 1%;">
        <asp:Button id="edit" runat="server" Text="Edit" OnClick="edit_Click" class="btn btn-primary" OnClientClick="return alert('Cập nhật thông tin thành công.')"/>
    </div>
    <div style="margin-left: 43%;margin-top: -4%;">
          <asp:Button Text="Chi Tiết Điện Thoại" runat="server" ID="quayvetrangchitiet" class="btn btn-success"/>  
    </div>
</asp:Content>
