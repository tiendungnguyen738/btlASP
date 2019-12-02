<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="editProduct.aspx.cs" Inherits="shopASP.editProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="noidung" runat="server">
    <div class="card-header" style="margin-bottom: 28px;">
            <i class="fas fa-table"></i>
            QUẢN LÝ SẢN PHẨM
     </div>
    <h4 style="color:blue;margin-bottom: -3%; margin-left: 32%;">Cập Nhật Thông Tin Điện Thoại</h4>
     <asp:Table ID="Table1" runat="server">
        <asp:TableRow>
            <asp:TableCell>
                <label for="productId" class="col-form-label" style="margin-left: -5%">Mã Điện Thoại</label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="productId" runat="server" Enabled="false" class="form-control"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>

         <asp:TableRow>
            <asp:TableCell>
                <label for="tendienthoai" class="col-form-label" style="margin-left: -7%;">Tên Điện Thoại</label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="tendienthoai" runat="server" class="form-control" Width="348px"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

         <asp:TableRow>
            <asp:TableCell>
                <label for="giadienthoai" class="col-form-label" style="margin-left: -5%;">Giá Điện Thoại</label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="giadienthoai" runat="server" class="form-control" Width="348px"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

         <asp:TableRow>
            <asp:TableCell>
                <label for="dsHangDienThoai" class="col-form-label" style="margin-left: -16%;">Hãng Điện Thoại</label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="dsHangDienThoai" runat="server" class="form-control" Width="348px"></asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>

         <asp:TableRow>
            <asp:TableCell>
                <label for="mota" class="col-form-label" style="margin-left: -22%;">Mô Tả Điện Thoại</label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="mota" runat="server" class="form-control" Width="348px"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
         <asp:TableRow>
             <asp:TableCell>
                 <label for="FileUpload1" class="col-sm-2 col-form-label" style="margin-left:26%;">Ảnh</label>
             </asp:TableCell>
            <asp:TableCell>
                <div class="col-sm-5" style="margin-left: -11%;">
                     <asp:FileUpload ID="FileUpload1" runat="server" />
                </div>
            </asp:TableCell>  
         </asp:TableRow>
         
    </asp:Table>
    <div style="margin-left: 41%;margin-top: 2%;">
        <asp:Button id="edit" runat="server" Text="Edit" OnClick="edit_Click" class="btn btn-primary" Width="93px" OnClientClick="return alert('Cập nhật thông tin thành công.')"/>
    </div>
    <div style="margin-left: 48%;margin-top: -4%;">
        <asp:Button Text="Danh Sách Điện Thoại" runat="server" PostBackUrl="~/product-ad.aspx" class="btn btn-success"/>
    </div>
    
</asp:Content>
