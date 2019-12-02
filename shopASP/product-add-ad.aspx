<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="product-add-ad.aspx.cs" Inherits="shopASP.product_add_ad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="noidung" runat="server">
    <div class="card-header">
            <i class="fas fa-table"></i>
            QUẢN LÝ SẢN PHẨM
     </div>
    <h4 style="color:blue;margin-top: 1%; margin-left: 32%;">Thêm Sản Phẩm</h4>
    <asp:FormView ID="FormView1" runat="server" DataKeyNames="product_id" DataSourceID="SqlDataSource1" OnItemInserting="ItemInserting" DefaultMode="Insert" Width="100%">
        <EditItemTemplate>
            product_id:
            <asp:Label ID="product_idLabel1" runat="server" Text='<%# Eval("product_id") %>' />
            <br />
            category_id:
            <asp:TextBox ID="category_idTextBox" runat="server" Text='<%# Bind("category_id") %>' />
            <br />
            product_name:
            <asp:TextBox ID="product_nameTextBox" runat="server" Text='<%# Bind("product_name") %>' />
            <br />
            price:
            <asp:TextBox ID="priceTextBox" runat="server" Text='<%# Bind("price") %>' />
            <br />
            descriptions:
            <asp:TextBox ID="descriptionsTextBox" runat="server" Text='<%# Bind("descriptions") %>' />
            <br />
            image:
            <asp:TextBox ID="imageTextBox" runat="server" Text='<%# Bind("image") %>' />
            <br />
            <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
            &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </EditItemTemplate>
        <InsertItemTemplate>
            <div class="form-group row">
                <label for="product_nameTextBox" class="col-sm-2 col-form-label" style="margin-left:19%;">Hãng Điện Thoại</label>
                <div class="col-sm-5" style="margin-left: -4%;">
                     <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource2" DataTextField="category_name" DataValueField="category_id" SelectedValue='<%# Bind("category_id") %>' class="form-control">
                     </asp:DropDownList>
                     <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:shopConnectionString5 %>" SelectCommand="SELECT * FROM [category]"></asp:SqlDataSource>
                </div>
            </div>
             <div class="form-group row">
                    <label for="product_nameTextBox" class="col-sm-2 col-form-label" style="margin-left:20%;">Tên Điện Thoại</label>
                    <div class="col-sm-5" style="margin-left: -5%;">
                        <asp:TextBox ID="product_nameTextBox" runat="server" Text='<%# Bind("product_name") %>' class="form-control" placeholder="Nhập Tên Điện Thoại ..."/>
                    </div>
            </div>
            <div class="form-group row">
                    <label for="product_nameTextBox" class="col-sm-2 col-form-label" style="margin-left:27%;">Giá</label>
                    <div class="col-sm-5" style="margin-left: -12%;">
                        <asp:TextBox ID="priceTextBox" runat="server" Text='<%# Bind("price") %>' class="form-control" placeholder="Nhập Giá Tiền ..."/>
                    </div>
            </div>
            <div class="form-group row">
                    <label for="product_nameTextBox" class="col-sm-2 col-form-label" style="margin-left:25%;">Mô Tả</label>
                    <div class="col-sm-5" style="margin-left: -10%;">
                        <asp:TextBox ID="descriptionsTextBox" runat="server" Text='<%# Bind("descriptions") %>' class="form-control" placeholder="Nhập Mô Tả ..."/>
                    </div>
            </div>
            <div class="form-group row">
                    <label for="FileUpload1" class="col-sm-2 col-form-label" style="margin-left:26%;">Ảnh</label>
                    <div class="col-sm-5" style="margin-left: -11%;">
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </div>
            </div>
                <button type="button" class="btn btn-primary" style="margin-left: 33%;height: 40px;">
                         <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" OnClientClick="return alert('Thêm thông tin thành công.')"/>
                </button>&nbsp;
                <button type="button" class="btn btn-secondary" style="height: 40px;">
                         <asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </button>
            <div style="margin-top: -4%;margin-left: 46%;">
                <asp:Button PostBackUrl="~/product-ad.aspx" Text="Danh Sách Điện Thoại" runat="server" class="btn btn-success" Height=""/>
            </div>
                
        </InsertItemTemplate>
        <ItemTemplate>
            product_id:
            <asp:Label ID="product_idLabel" runat="server" Text='<%# Eval("product_id") %>' />
            <br />
            category_id:
            <asp:Label ID="category_idLabel" runat="server" Text='<%# Bind("category_id") %>' />
            <br />
            product_name:
            <asp:Label ID="product_nameLabel" runat="server" Text='<%# Bind("product_name") %>' />
            <br />
            price:
            <asp:Label ID="priceLabel" runat="server" Text='<%# Bind("price") %>' />
            <br />
            descriptions:
            <asp:Label ID="descriptionsLabel" runat="server" Text='<%# Bind("descriptions") %>' />
            <br />
            image:
            <asp:Label ID="imageLabel" runat="server" Text='<%# Bind("image") %>' />
            <br />
            <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
            &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
            &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
        </ItemTemplate>

    </asp:FormView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:shopConnectionString %>" DeleteCommand="DELETE FROM [product] WHERE [product_id] = @product_id" InsertCommand="INSERT INTO [product] ([category_id], [product_name], [price], [descriptions], [image]) VALUES (@category_id, @product_name, @price, @descriptions, @image)" SelectCommand="SELECT * FROM [product]" UpdateCommand="UPDATE [product] SET [category_id] = @category_id, [product_name] = @product_name, [price] = @price, [descriptions] = @descriptions, [image] = @image WHERE [product_id] = @product_id">
    <DeleteParameters>
        <asp:Parameter Name="product_id" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="category_id" Type="Int32" />
        <asp:Parameter Name="product_name" Type="String" />
        <asp:Parameter Name="price" Type="Int32" />
        <asp:Parameter Name="descriptions" Type="String" />
        <asp:Parameter Name="image" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="category_id" Type="Int32" />
        <asp:Parameter Name="product_name" Type="String" />
        <asp:Parameter Name="price" Type="Int32" />
        <asp:Parameter Name="descriptions" Type="String" />
        <asp:Parameter Name="image" Type="String" />
        <asp:Parameter Name="product_id" Type="Int32" />
    </UpdateParameters>
</asp:SqlDataSource>
</asp:Content>
