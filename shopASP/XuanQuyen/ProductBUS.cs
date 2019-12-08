using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
/// <summary>
/// Summary description for ProductBUS
/// </summary>
public class ProductBUS
{
    SqlConnection conn;
	public ProductBUS()
	{
        //Tao chuoi ket noi sql
        string sql = @"Data Source=DESKTOP-GCLEMNC\SQLEXPRESS;Initial Catalog=shop;Integrated Security=True";
        conn = new SqlConnection(sql);
	}
    public List<Product> getListProduct(Product_Detail similar,int orderby,int color)
    {
        //Tao danh sach
        List<Product> ds = new List<Product>();
       
        //Cau lenh truy van
        string conds = MakeConnection.createCondition(similar);
        string sqlSelect = "SELECT * FROM dbo.product left join dbo.category on category.category_id = product.category_id ";
        if (color == 1) {
            sqlSelect += "left join dbo.product_detail on product.product_id=product_detail.product_id ";
 
        }
        if (conds != "") {
            sqlSelect += "WHERE " + conds;
        }
        
        sqlSelect += " ORDER BY ";
       
        switch (orderby) 
        {
            case 1: sqlSelect += "product.product_id ASC "; break;
            case 2: sqlSelect += "product.price ASC "; break;
            case 3: sqlSelect += "product.price DESC "; break;
            case 4: sqlSelect += "product.product_id DESC "; break;
        }
        //sqlSelect += " LIMIT 3 ";
        //Mo cong ket noi
        conn.Open();
        //Thuc thi cau lenh
        SqlCommand cmd = new SqlCommand(sqlSelect, conn);
        //Doc du lieu tren table trong sql
        SqlDataReader rd = cmd.ExecuteReader();
        while (rd.Read())
        {
            Product p = new Product();
            p.product_id = (int)rd["product_id"];
            p.product_name = (string)rd["product_name"];
            p.category_id = (int)rd["category_id"];
			p.descriptions = (string)rd["descriptions"];
            p.image = (string)rd["image"];
            p.price = (int)rd["price"];
           

            ds.Add(p);
        }
        //Dong bo quan ly ket noi
        conn.Close();
        return ds;
    }
    public List<Category> getListCategory()
    {
        //Tao danh sach
        List<Category> ds = new List<Category>();
        //Cau lenh truy van
        
        string sqlSelect = "SELECT * FROM dbo.category";

        sqlSelect += " ORDER BY category.category_id ASC ";
        //Mo cong ket noi
        conn.Open();
        //Thuc thi cau lenh
        SqlCommand cmd = new SqlCommand(sqlSelect, conn);
        //Doc du lieu tren table trong sql
        SqlDataReader rd = cmd.ExecuteReader();
        while (rd.Read())
        {
            Category c = new Category();
            c.category_id = (int)rd["category_id"];
            c.category = (string)rd["category_name"];
            
            ds.Add(c);
        }
        //Dong bo quan ly ket noi
        conn.Close();
        return ds;
    }
    public Product getProduct(int product_id)
    {
        //Tao doi tuong
        Product p=null;
        //Cau lenh truy van
        string sqlSelect = "SELECT * FROM dbo.product left join product_detail on product.product_id=product_detail.product_id left join category on category.category_id = product.category_id ";
        sqlSelect += "WHERE product.product_id = " + product_id + "";
        //Mo cong ket noi
        conn.Open();
        //Thuc thi cau lenh
        SqlCommand cmd = new SqlCommand(sqlSelect, conn);
        //Doc du lieu tren table trong sql
        SqlDataReader rd = cmd.ExecuteReader();
        if (rd.Read())
        {
            p = new Product();
            p.product_id = (int)rd["product_id"];
            p.product_name = (string)rd["product_name"];
			p.descriptions = (string)rd["descriptions"];
            p.category_id = (int)rd["category_id"];
            p.image = (string)rd["image"];
            p.price = (int)rd["price"];

        }
        //Dong bo quan ly ket noi
        conn.Close();
        return p;
    }
}