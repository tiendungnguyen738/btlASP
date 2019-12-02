<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="color-ad.aspx.cs" Inherits="shopASP.color_ad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="noidung" runat="server">
    <div class="card mb-3">
        <div class="card-header">
            <i class="fas fa-table"></i>
            QUẢN LÝ MÀU SẢN PHẨM
            <br />
        </div>

        <hr />
        <h4 style="margin-left: 3%; margin-top: 1%;color: forestgreen;">Thêm Màu Sắc</h4>
        <div class="form-group row">
             <label for="tenmau" class="col-sm-2 col-form-label" style="margin-left: 3%;">Tên Màu</label>
             <div class="col-sm-5" style="margin-left: -10%;">
                <asp:TextBox placeholder="Nhập tên màu ..........." ID="tenmau" runat="server" class="form-control"></asp:TextBox>
             </div>
            <asp:Button Text="Thêm Màu" runat="server" Width="11%" class="btn btn-success" ID="btnThemMau" OnClick="btnThemMau_Click"/>
        </div>
        <hr style="margin-top: 1%;"/>


        <h4 style="margin-left: 3%; margin-top: 1%;color: forestgreen;">Danh Sách Màu Sản Phẩm</h4>
                &nbsp;<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" GridLines="None" class="table table-hover">
                    <Columns>
                        <asp:BoundField DataField="color_id" HeaderText="Màu Sản Phẩm" />
                        <asp:BoundField DataField="color_name" HeaderText="Tên Màu" />
                        <asp:templatefield headertext="Delete" >
                            <itemtemplate>
                                <asp:button id="delete" commandname="delete" commandargument='<%# Bind("color_id") %>' text="delete" runat="server" oncommand="delete_click"
                                   onclientclick="return confirm('you sure ???')" class="btn btn-danger"/>
                            </itemtemplate>
                        </asp:templatefield>
                        <asp:templatefield headertext="Edit">
                            <itemtemplate>
                                <asp:button id="edit" CommandName="edit" CommandArgument='<%# Bind("color_id") %>' text="edit" runat="server" OnCommand="edit_click" class="btn btn-warning"/>
                            </itemtemplate>
                        </asp:templatefield>
                    </Columns>
                </asp:GridView>
            </div>
</asp:Content>
