<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="product-ad.aspx.cs" Inherits="shopASP.product_ad" %>

<asp:Content ID="Content1" ContentPlaceHolderID="noidung" runat="server">
    <div class="card mb-3">
        <div class="card-header">
            <i class="fas fa-table"></i>
            QUẢN LÝ SẢN PHẨM
        </div>

         <%--------------------------------------------tìm kiếm điện thoại----------------------%>
        <hr />
        <h4 style="margin-left: 3%; margin-top: 1%;color: forestgreen;">Tìm Kiếm Sản Phẩm</h4>
        <div class="form-group row" style="margin-left: 3%;background-color: #1f23a736; width: 53%;">
            <label for="tensanpham" class="col-form-label" style="margin-left: 3%;">Tên Sản Phẩm</label>
            <div style="margin-left: 1%;">
                <asp:TextBox placeholder="Nhập Tên Sản Phẩm ..........." ID="tensanpham" runat="server" class="form-control" Width="169%"></asp:TextBox>
            </div>
            <div style="margin-left: 30%">
               <asp:Button Text="Tìm Kiếm" runat="server" ID="btnTim" class="btn btn-success" Width="137%" OnClick="btnTim_Click"/>
            </div>
        </div>
        <hr style="margin-top: 1%;"/>

        <%-------------------------------------------danh sách điện thoại-------------------------------------------------------%>

        <asp:Button PostBackUrl="~/product-add-ad.aspx" Text="Thêm Điện Thoại" runat="server" class="btn btn-success" Width="20%"/>
        <h4 style="margin-left: 3%; margin-top: 1%;color: forestgreen;">Danh Sách Sản Phẩm</h4>
         <div style="color: red; margin-left: 37%;margin-top: -3%; font-size: 24px;font-weight: bolder">
                    <asp:Label ID="thongbao" runat="server"></asp:Label>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" GridLines="None" class="table table-hover">
                    <Columns>
                        <asp:BoundField DataField="product_id" HeaderText="ID" />
                        <asp:BoundField DataField="category_name" HeaderText="Tên Hãng" />
                        <asp:BoundField DataField="product_name" HeaderText="Tên Điện Thoại" />
                        <asp:BoundField DataField="price" HeaderText="Giá Điện Thoại" />
                        <asp:BoundField DataField="descriptions" HeaderText="Mô Tả" /> 
                        <asp:TemplateField HeaderText="Ảnh">
                            <ItemTemplate>
                                <asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/Web/images/"+Eval("image") %>' Width="70px" Height="90px" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:HyperLinkField DataNavigateUrlFields="product_id" 
                            DataNavigateUrlFormatString="~/product-detail-ad.aspx?product_id={0}" 
                            HeaderText="Xem Chi Tiết" Text="Xem"/>
                        <asp:TemplateField HeaderText="Xóa">
                            <ItemTemplate>
                                <asp:Button ID="Delete" CommandName="delete" CommandArgument='<%# Bind("product_id") %>' Text="Delete" runat="server" OnCommand="Delete_Click"
                                    OnClientClick="return confirm('you sure ???')" class="btn btn-danger"/>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Sửa">
                            <ItemTemplate>
                                <asp:Button ID="Edit" CommandName="Edit" CommandArgument='<%# Bind("product_id") %>' Text="Edit" runat="server" OnCommand="Edit_Click" class="btn btn-warning"/>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
               
                
        <div class="card-body">
            <div class="table-responsive">
                
            </div>
        </div>
    </div>
</asp:Content>
