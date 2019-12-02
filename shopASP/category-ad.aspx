<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="category-ad.aspx.cs" Inherits="shopASP.category_ad" %>

<asp:Content ID="Content1" ContentPlaceHolderID="noidung" runat="server">
    <div class="card mb-3">
        <div class="card-header">
            <i class="fas fa-table"></i>
            QUẢN LÝ HÃNG ĐIỆN THOẠI
        </div>
        <asp:Button PostBackUrl="~/category-add-ad.aspx" Text="Thêm Hãng Điện Thoại" runat="server" Width="17%" class="btn btn-success" ID="btnThemCategory"/>
        <h4 style="margin-left: 3%; margin-top: 1%;color: forestgreen;">Danh Sách Hãng Điện Thoại</h4>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" class="table table-hover" GridLines="None">
                    <Columns>
                        <asp:BoundField DataField="category_id" HeaderText="Id" />
                        <asp:BoundField DataField="category_name" HeaderText="Tên Hãng" />
                        <asp:TemplateField HeaderText="Ảnh">
                            <ItemTemplate>
                                <asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/Web/images/"+Eval("image") %>' Width="100px" Height="60px"/>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Xóa">
                            <ItemTemplate>
                                <asp:Button ID="Delete" CommandName="delete" CommandArgument='<%# Bind("category_id") %>' Text="Delete" runat="server" OnCommand="Delete_Click"
                                    OnClientClick="return confirm('you sure ???')" class="btn btn-danger"/>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Sửa">
                            <ItemTemplate>
                                <asp:Button ID="Edit" CommandName="Edit" CommandArgument='<%# Bind("category_id") %>' Text="Edit" runat="server" OnCommand="Edit_Click" class="btn btn-primary"/>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
</asp:Content>
