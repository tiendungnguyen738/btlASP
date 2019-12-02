<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="category-add-ad.aspx.cs" Inherits="shopASP.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="noidung" runat="server">
    <h3 style="margin-left: 31%;">Thêm Hãng Điện Thoại</h3>
         <asp:FormView runat="server" DataKeyNames="category_id" DataSourceID="SqlDataSource2" OnItemInserting="ItemInserting" Width="100%" ID="formview1" DefaultMode="Insert">
             <EditItemTemplate>
                 category_id:
                 <asp:Label ID="category_idLabel1" runat="server" Text='<%# Eval("category_id") %>' />
                 <br />
                 Tên Hãng
                 <asp:TextBox ID="category_nameTextBox" runat="server" Text='<%# Bind("category_name") %>' />
                 <br />
                 Ảnh
                 <asp:TextBox ID="imageTextBox" runat="server" Text='<%# Bind("image") %>' />
                 <br />
                 <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                 &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
             </EditItemTemplate>
             <InsertItemTemplate>
                 <div class="form-group row">
                    <label for="category_nameTextBox" class="col-sm-2 col-form-label" style="margin-left:4%;">Tên Hãng</label>
                    <div class="col-sm-5" style="margin-left: -8%;">
                        <asp:TextBox ID="category_nameTextBox" runat="server" Text='<%# Bind("category_name") %>' class="form-control" placeholder="Nhập Tên Hãng ..."/>
                    </div>
                </div>
                 <div class="form-group row">
                     <label for="FileUpload1" class="col-sm-2 col-form-label" style="margin-left: 7%;">Ảnh</label>
                     <div class="col-sm-5" style="margin-left: -17%;">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:FileUpload ID="FileUpload1" runat="server"/>
                     </div>
                 </div>
                 <button type="button" class="btn btn-primary" style="margin-left: 13%;">
                     <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" OnClientClick="return alert('Thêm thông tin thành công.')"/>
                 </button>&nbsp;
                 <button type="button" class="btn btn-secondary">
                     <asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                 </button>
                     <asp:Button PostBackUrl="~/category-ad.aspx" Text="Danh Sách Hãng Điện Thoại" runat="server" class="btn btn-primary"/>
             </InsertItemTemplate>
             <ItemTemplate>
                 category_id:
                 <asp:Label ID="category_idLabel" runat="server" Text='<%# Eval("category_id") %>' />
                 <br />
                 Tên Hãng:
                 <asp:Label ID="category_nameLabel" runat="server" Text='<%# Bind("category_name") %>' />
                 <br />
                 Ảnh :
                 <asp:Label ID="imageLabel" runat="server" Text='<%# Bind("image") %>' />
                 <br />
                 <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
                 &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
                 &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
             </ItemTemplate>

         </asp:FormView>
        
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:shopConnectionString %>" DeleteCommand="DELETE FROM [category] WHERE [category_id] = @original_category_id AND (([category_name] = @original_category_name) OR ([category_name] IS NULL AND @original_category_name IS NULL)) AND (([image] = @original_image) OR ([image] IS NULL AND @original_image IS NULL))" InsertCommand="INSERT INTO [category] ([category_name], [image]) VALUES (@category_name, @image)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [category]" UpdateCommand="UPDATE [category] SET [category_name] = @category_name, [image] = @image WHERE [category_id] = @original_category_id AND (([category_name] = @original_category_name) OR ([category_name] IS NULL AND @original_category_name IS NULL)) AND (([image] = @original_image) OR ([image] IS NULL AND @original_image IS NULL))">
        <DeleteParameters>
            <asp:Parameter Name="original_category_id" Type="Int32" />
            <asp:Parameter Name="original_category_name" Type="String" />
            <asp:Parameter Name="original_image" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="category_name" Type="String" />
            <asp:Parameter Name="image" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="category_name" Type="String" />
            <asp:Parameter Name="image" Type="String" />
            <asp:Parameter Name="original_category_id" Type="Int32" />
            <asp:Parameter Name="original_category_name" Type="String" />
            <asp:Parameter Name="original_image" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
    
</asp:Content>
