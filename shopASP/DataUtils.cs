using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace shopASP
{
    public class DataUtils
    {
        SqlConnection con;
        public DataUtils()
        {
            string ketnoi = @"Data Source=DESKTOP-GCLEMNC\SQLEXPRESS;Initial Catalog=shop;Integrated Security=True";
            con = new SqlConnection(ketnoi);
        }

        //--------------------------truy vấn hãng điện thoại------------------------------------------------------------
        public DataTable dscategories()
        {
            DataTable table = new DataTable("category");
            table.Columns.Add("category_id", typeof(int));
            table.Columns.Add("category_name", typeof(string));
            table.Columns.Add("image", typeof(string));

            string ds = "select * from category";
            con.Open();
            SqlCommand cmd = new SqlCommand(ds, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DataRow row = table.NewRow();
                row[0] = (int)dr["category_id"];
                row[1] = (string)dr["category_name"];
                row[2] = (string)dr["image"];
                table.Rows.Add(row);
            }
            con.Close();
            return table;
        }
        public void xoaCategory(int categoryId)
        {
            string xoaCategory = "delete from category where category_id = @categoryId";
            con.Open();
            SqlCommand cmd = new SqlCommand(xoaCategory, con);
            cmd.Parameters.AddWithValue("categoryId", categoryId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public category layCategory(int categoryId)
        {
            category category = new category();
            string ds = "select * from category where category_id = @categoryId";
            con.Open();
            SqlCommand cmd = new SqlCommand(ds, con);
            cmd.Parameters.AddWithValue("categoryId", categoryId);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                
                category.category_id = (int)dr["category_id"];
                category.category_name = (string)dr["category_name"];
                category.image = (string)dr["image"];
            }
            con.Close();
            return category;
        }
        public void suaCategory(category danhmuc)
        {
            string sqlSua = "update category set category_name = @categoryName,image=@image where category_id=@category_id";
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlSua, con);
            cmd.Parameters.AddWithValue("categoryName", danhmuc.category_name);
            cmd.Parameters.AddWithValue("category_id", danhmuc.category_id);
            cmd.Parameters.AddWithValue("image", danhmuc.image);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        //-----------------------------------------------truy vấn điện thoại----------------------------------
        public List<thong_tin_dienthoai> laydsdt()
        {
            List<thong_tin_dienthoai> products = new List<thong_tin_dienthoai>();
            string sqlDsdt = "select product.product_id, product.product_name, product.price,product.descriptions, product.image,category.category_name,product.category_id from product inner join category on product.category_id = category.category_id";
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlDsdt, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                thong_tin_dienthoai product = new thong_tin_dienthoai();
                product.product_id = (int)dr["product_id"];
                product.product_name = (string)dr["product_name"];
                product.category_name = (string)dr["category_name"];
                product.price = (int)dr["price"];
                product.descriptions = (string)dr["descriptions"];
                product.image = (string)dr["image"];
                product.category_id = (int)dr["category_id"];
                products.Add(product);
            }
            con.Close();
            return products;
        }

        public void xoaDienThoai(int id)
        {
            string xoaDienThoai = "delete from product where product_id = @productId";
            con.Open();
            SqlCommand cmd = new SqlCommand(xoaDienThoai, con);
            cmd.Parameters.AddWithValue("productId", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public product layProduct(int productId)
        {
            product product = new product();
            string ds = "select * from product where product_id = @productId";
            con.Open();
            SqlCommand cmd = new SqlCommand(ds, con);
            cmd.Parameters.AddWithValue("productId", productId);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                product.product_id = (int)dr["product_id"];
                product.product_name = (string)dr["product_name"];
                product.image = (string)dr["image"];
                product.descriptions = (string)dr["descriptions"];
                product.price = (int)dr["price"];
                product.category_id = (int)dr["category_id"];
            }
            con.Close();
            return product;
        }

        public void suaProduct(product product)
        {
            string sqlSua = "update product set product_name = @productName,image=@image,price=@price,descriptions=@descriptions,category_id=@category_id where product_id=@product_id";
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlSua, con);
            cmd.Parameters.AddWithValue("productName", product.product_name);
            cmd.Parameters.AddWithValue("product_id", product.product_id);
            cmd.Parameters.AddWithValue("price", product.price);
            cmd.Parameters.AddWithValue("descriptions", product.descriptions);
            cmd.Parameters.AddWithValue("category_id", product.category_id);
            cmd.Parameters.AddWithValue("image", product.image);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public List<thong_tin_dienthoai> getListProductSearch(string tendienthoai)
        {
            List<thong_tin_dienthoai> products = new List<thong_tin_dienthoai>();
            string sqlSearch1= "select product.product_id, product.product_name, product.price,product.descriptions, product.image,category.category_name,product.category_id " +
                               "from product inner join category on product.category_id = category.category_id " +
                               "where product.product_name like '%"+@tendienthoai+"%'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlSearch1, con);
            cmd.Parameters.AddWithValue("tendienthoai", tendienthoai);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                thong_tin_dienthoai product = new thong_tin_dienthoai();
                product.product_id = (int)dr["product_id"];
                product.product_name = (string)dr["product_name"];
                product.category_id = (int)dr["category_id"];
                product.price = (int)dr["price"];
                product.descriptions = (string)dr["descriptions"];
                product.image = (string)dr["image"];
                product.category_name = (string)dr["category_name"];
                products.Add(product);
            }
            con.Close();
            return products;
        }

        //------------------------------------------------truy vấn màu sản phẩm--------------------------------------
        public List<color> GetColors()
        {
            List<color> colors = new List<color>();
            string sqlDscl = "select *from color";
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlDscl, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                color color = new color();
                color.color_id = (int)dr["color_id"];
                color.color_name = (string)dr["color_name"];
                colors.Add(color);
            }
            con.Close();
            return colors;
        }

        public void xoaColor(int colorId)
        {
            string xoaColor = "delete from color where color_id = @colorId";
            con.Open();
            SqlCommand cmd = new SqlCommand(xoaColor, con);
            cmd.Parameters.AddWithValue("colorId", colorId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public color layColor(int colorId)
        {
            color color = new color();
            string ds = "select * from color where color_id = @colorId";
            con.Open();
            SqlCommand cmd = new SqlCommand(ds, con);
            cmd.Parameters.AddWithValue("colorId", colorId);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                color.color_id = (int)dr["color_id"];
                color.color_name = (string)dr["color_name"];
            }
            con.Close();
            return color;
        }
        public void suaColor(color color)
        {
            string sqlSua = "update color set color_name = @color where color_id=@color_id";
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlSua, con);
            cmd.Parameters.AddWithValue("color", color.color_name);
            cmd.Parameters.AddWithValue("color_id", color.color_id);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void themColor(color color)
        {
            string themColor = "insert into color values(@tenmau)";
            con.Open();
            SqlCommand cmd = new SqlCommand(themColor, con);
            cmd.Parameters.AddWithValue("tenmau", color.color_name);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //-----------------------------------------truy vấn chi tiết điện thoại --------------------------------
        public List<product_detail_hienthi> danhSachDienThoaiTheoMa(int product_id)
        {
            List<product_detail_hienthi> product_Details = new List<product_detail_hienthi>();
            string dsdttheoma = "select product.product_id,product.product_name,color.color_name,product_detail.quantity, product.image,product_detail.product_detail_id from product_detail inner join product on product_detail.product_id = product.product_id inner join color on product_detail.color_id = color.color_id where product_detail.product_id =@product_id";
            con.Open();
            SqlCommand sqlCommand = new SqlCommand(dsdttheoma, con);
            sqlCommand.Parameters.AddWithValue("product_id", product_id);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            while (dr.Read())
            {
                product_detail_hienthi product_Detail_Hienthi = new product_detail_hienthi();
                product_Detail_Hienthi.product_detail_id = (int)dr["product_detail_id"];
                product_Detail_Hienthi.color_name = (string)dr["color_name"];
                product_Detail_Hienthi.image = (string)dr["image"];
                product_Detail_Hienthi.product_name = (string)dr["product_name"];
                product_Detail_Hienthi.quantity = (int)dr["quantity"];
                product_Detail_Hienthi.product_id = (int)dr["product_id"];
                product_Details.Add(product_Detail_Hienthi);
            }
            con.Close();
            return product_Details;
        }
        public void xoaProductDetail(int product_detail_id)
        {
            string xoaProductDetail = "delete from product_detail where product_detail_id = @product_detail_id";
            con.Open();
            SqlCommand cmd = new SqlCommand(xoaProductDetail, con);
            cmd.Parameters.AddWithValue("product_detail_id", product_detail_id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public product_detail_hienthi layProductDetail(int productDetailId)
        {
            product_detail_hienthi product_detail_hienthi = new product_detail_hienthi();
            string ds = "select product_detail.quantity,color.color_name,product.product_name,color.color_id,product_detail.product_detail_id,product_detail.product_id from product_detail inner join product on product_detail.product_id = product.product_id inner join color on product_detail.color_id = color.color_id where product_detail.product_detail_id = @product_detail_id";
            con.Open();
            SqlCommand cmd = new SqlCommand(ds, con);
            cmd.Parameters.AddWithValue("product_detail_id", productDetailId);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                product_detail_hienthi.product_detail_id = (int)dr["product_detail_id"];
                product_detail_hienthi.product_name = (string)dr["product_name"];
                product_detail_hienthi.color_name = (string)dr["color_name"];
                product_detail_hienthi.quantity = (int)dr["quantity"];
                product_detail_hienthi.color_id = (int)dr["color_id"];
                product_detail_hienthi.product_id = (int)dr["product_id"];
            }
            con.Close();
            return product_detail_hienthi;
        }
        public void suaSoLuongVaMau(product_detail_hienthi product_Detail_Hienthi)
        {
            string sqlSua = "update product_detail set color_id=@color_id,quantity=@quantity where product_detail_id=@product_detail_id";
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlSua, con);
            cmd.Parameters.AddWithValue("color_id", product_Detail_Hienthi.color_id);
            cmd.Parameters.AddWithValue("quantity", product_Detail_Hienthi.quantity);
            cmd.Parameters.AddWithValue("product_detail_id", product_Detail_Hienthi.product_detail_id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void themChiTietDienThoai(product_detail product_detail)
        {
            string themChiTietDienThoai = "insert into product_detail values(@product_id,@color_id,@quantity)";
            con.Open();
            SqlCommand cmd = new SqlCommand(themChiTietDienThoai, con);
            cmd.Parameters.AddWithValue("product_id", product_detail.product_id);
            cmd.Parameters.AddWithValue("color_id", product_detail.color_id);
            cmd.Parameters.AddWithValue("quantity", product_detail.quantity);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}