using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Product_detailBus
/// </summary>
public class Product_detailBus
{
    SqlConnection conn;
    public Product_detailBus()
	{
		//Tao chuoi ket noi sql
        string sql = @"Data Source=DESKTOP-GCLEMNC\SQLEXPRESS;Initial Catalog=shop;Integrated Security=True";
        conn = new SqlConnection(sql);
	}
    //public Product getProduct_detail(int product_id)
    //{
    //    Product pd = null;
    //    //Cau lenh truy van
    //    string sqlSelect = "SELECT * FROM product where product_id = '" + product_id + "'";
    //    //string sqlSelect = "SELECT * FROM dbo.product_detail where product_detail.product_id = '" + product_id + "'";
    //    //Mo cong ket noi
    //    conn.Open();
    //    //Thuc thi cau lenh
    //    SqlCommand cmd = new SqlCommand(sqlSelect, conn);
    //    //Doc du lieu tren table trong sql
    //    SqlDataReader rd = cmd.ExecuteReader();
    //    //doi tuong
    //    if(rd.Read())
    //    {
    //        pd = new Product();
    //   //     pd.product_detail_id = (int)rd["product_detail_id"];
    //        pd.product_id = (int)rd["product_id"];
    //  //      pd.size_id = (int)rd["size_id"];
    //  //      pd.color_id = (int)rd["color_id"];
    //   //     pd.quantity = (int)rd["quantity"];
    //        pd.product_name = (string)rd["product_name"];
    //        pd.price = (int)rd["price"];
    //        pd.image = (string)rd["image"];
    //    }
    //    //Dong bo quan ly ket noi
    //    conn.Close();
    //    return pd;
    //}

    public Product getProduct_detail(int product_id)
    {
        Product pd = null;
        //Cau lenh truy van
        string sqlSelect = "SELECT * FROM product where product_id = '" + product_id + "'";
        //string sqlSelect = "SELECT * FROM dbo.product_detail where product_detail.product_id = '" + product_id + "'";
        //Mo cong ket noi
        conn.Open();
        //Thuc thi cau lenh
        SqlCommand cmd = new SqlCommand(sqlSelect, conn);
        //Doc du lieu tren table trong sql
        SqlDataReader rd = cmd.ExecuteReader();
        //doi tuong
        if (rd.Read())
        {
            pd = new Product();
            //     pd.product_detail_id = (int)rd["product_detail_id"];
            pd.product_id = (int)rd["product_id"];
            //      pd.size_id = (int)rd["size_id"];
            //      pd.color_id = (int)rd["color_id"];
            //     pd.quantity = (int)rd["quantity"];
            pd.product_name = (string)rd["product_name"];
            pd.price = (int)rd["price"];
            pd.image = (string)rd["image"];
        }
        //Dong bo quan ly ket noi
        conn.Close();
        return pd;
    }


    public Product_Detail getCart(int product_id, int color_id)
    {
        Product_Detail pd = null;
        //Cau lenh truy van
        string sqlSelect = "SELECT * FROM dbo.product_detail left join product on product_detail.product_id = product.product_id where product_detail.product_id = '" + product_id + "'and color_id = '"+color_id+"'";
        //string sqlSelect = "SELECT * FROM dbo.product_detail where product_detail.product_id = '" + product_id + "'";
        //Mo cong ket noi
        conn.Open();
        //Thuc thi cau lenh
        SqlCommand cmd = new SqlCommand(sqlSelect, conn);
        //Doc du lieu tren table trong sql
        SqlDataReader rd = cmd.ExecuteReader();
        //doi tuong
        if (rd.Read())
        {
            pd = new Product_Detail();
            pd.product_detail_id = (int)rd["product_detail_id"];
            pd.product_id = (int)rd["product_id"];
           // pd.size_id = (int)rd["size_id"];
            pd.color_id = (int)rd["color_id"];
            pd.quantity = (int)rd["quantity"];
            pd.product_name = (string)rd["product_name"];
            pd.price = (int)rd["price"];
            pd.image = (string)rd["image"];
        }
        //Dong bo quan ly ket noi
        conn.Close();
        return pd;
    }
    public Product_Detail getProduct_detailByID(int id)
    {
        Product_Detail pd = null;
        //Cau lenh truy van
        string sqlSelect = "SELECT * FROM dbo.product_detail where product_detail.product_detail_id = '" + id + "'";
        //string sqlSelect = "SELECT * FROM dbo.product_detail where product_detail.product_id = '" + product_id + "'";
        //Mo cong ket noi
        conn.Open();
        //Thuc thi cau lenh
        SqlCommand cmd = new SqlCommand(sqlSelect, conn);
        //Doc du lieu tren table trong sql
        SqlDataReader rd = cmd.ExecuteReader();
        //doi tuong
        if (rd.Read())
        {
            pd = new Product_Detail();          
            pd.quantity = (int)rd["quantity"];
            
        }
        //Dong bo quan ly ket noi
        conn.Close();
        return pd;
    }

    
}