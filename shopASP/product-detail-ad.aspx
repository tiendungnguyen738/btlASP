<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="product-detail-ad.aspx.cs" Inherits="shopASP.product_detail_ad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="noidung" runat="server">
    <div class="card mb-3">
        <div class="card-header">
            <i class="fas fa-table"></i>
            QUẢN LÝ CHI TIẾT SẢN PHẨM
            <br />
        </div>
        <%-----------------------------------------------------thêm chi tiết sản phẩm-------------------------------------------%>

        <hr />
        <h4 style="margin-left: 3%; margin-top: 1%;color: forestgreen;">Thêm Chi Tiết Sản Phẩm</h4>
        <div class="form-group row" style="margin-top: 0%;margin-left: 0%;">
            <label for="soluong" class="col-form-label" style="margin-left: 3%;">Số Lượng</label>
            <div style="margin-left: 1%;">
                <asp:TextBox placeholder="Nhập Số Lượng ..........." ID="soluong" runat="server" class="form-control" Width="102%"></asp:TextBox>
            </div>
            <label for="soluong" class="col-sm-2 col-form-label" style="margin-left: 3%;">Màu Sắc</label>
            <asp:DropDownList ID="dsMau" runat="server" class="form-control" Width="17%"></asp:DropDownList>
            <div>
                <asp:Button Text="Thêm Chi Tiết" runat="server" ID="btnThem" class="btn btn-success" Width="137%" OnClick="btnThem_Click"/>
            </div>
            <asp:HiddenField ID="product_id" runat="server" />
        </div>
        <hr style="margin-top: 1%;"/>

        <%-----------------------------------------------------danh sách chi tiết sản phẩm-------------------------------------------%>

        <h4 style="margin-left: 3%; margin-top: 1%;color: forestgreen;">Danh Sách Chi Tiết Sản Phẩm</h4>
                &nbsp;<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" GridLines="None" class="table table-hover">
                    <Columns>
                        <asp:BoundField DataField="product_name" HeaderText="Tên Điện Thoại" />
                        <asp:BoundField DataField="color_name" HeaderText="Màu" />
                        <asp:BoundField DataField="quantity" HeaderText="Số Lượng" />         
                        <asp:TemplateField HeaderText="Ảnh">
                            <ItemTemplate>
                                <asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/Web/images/"+Eval("image") %>' Width="130px" Height="90px"/>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:templatefield headertext="Delete" >
                            <itemtemplate>
                                <asp:button id="delete" CommandName="delete" CommandArgument='<%# Bind("product_detail_id") %>' text="delete" runat="server" OnCommand="delete_click"
                                   OnClientClick="return confirm('you sure ???')" class="btn btn-danger"/>
                            </itemtemplate>
                        </asp:templatefield>
                        <asp:templatefield headertext="Edit">
                            <itemtemplate>
                                <asp:button id="edit" CommandName="edit" CommandArgument='<%# Bind("product_detail_id") %>' text="edit" runat="server" OnCommand="edit_click" class="btn btn-warning"/>
                            </itemtemplate>
                        </asp:templatefield>
                    </Columns>
                </asp:GridView>
            </div>
</asp:Content>
