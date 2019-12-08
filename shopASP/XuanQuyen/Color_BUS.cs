using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Color_BUS
/// </summary>
public class Color_BUS
{
    SqlConnection conn;
	public Color_BUS()
	{
		//Tao chuoi ket noi sql
        string sql = @"Data Source=DESKTOP-GCLEMNC\SQLEXPRESS;Initial Catalog=shop;Integrated Security=True";
        conn = new SqlConnection(sql);
	}
     
    public List<Color> getListColor(int product_id)
    {
        //Tao danh sach
        List<Color> ds = new List<Color>();
        //Cau lenh truy van
        string sqlSelect = "SELECT * FROM dbo.color left join product_detail on color.color_id=product_detail.color_id left join product on product_detail.product_id = product.product_id where product_detail.product_id = '"+product_id+"'";
        //Mo cong ket noi
        conn.Open();
        //Thuc thi cau lenh
        SqlCommand cmd = new SqlCommand(sqlSelect, conn);
        //Doc du lieu tren table trong sql
        SqlDataReader rd = cmd.ExecuteReader();
        while (rd.Read())
        {
            Color p = new Color();
            p.color_id = (int)rd["color_id"];
            p.color = (string)rd["color_name"];
            
            ds.Add(p);
        }
        //Dong bo quan ly ket noi
        conn.Close();
        return ds;

        }
        public Color GetColor(int id)
        {

            Color c = null;
            //Cau lenh truy van
            string sqlSelect = "SELECT * FROM dbo.color left join product_detail on color.color_id=product_detail.color_id left join product on product_detail.product_id = product.product_id where product_detail.product_detail_id = '" + id + "'";
            //Mo cong ket noi
            conn.Open();
            //Thuc thi cau lenh
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            //Doc du lieu tren table trong sql
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                c = new Color();
                c.color_id = (int)rd["color_id"];
                c.color = (string)rd["color_name"];


                //Dong bo quan ly ket noi
            }
            conn.Close();
            return c;
        }

    }