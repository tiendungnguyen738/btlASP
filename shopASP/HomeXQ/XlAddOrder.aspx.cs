using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Home_XlAddOrder : System.Web.UI.Page
{
    SqlConnection conn;
    protected void Page_Load(object sender, EventArgs e)
    {
        string connection = @"Data Source=DESKTOP-GCLEMNC\SQLEXPRESS;Initial Catalog=shop;Integrated Security=True";
        conn = new SqlConnection(connection);

        string name = Request.Form["name"];
        string address = Request.Form["address"];
        string phone = Request.Form["phone"];

        DateTime order_date = DateTime.Now;
        string note = Request.Form["note"];


        conn.Open();

        string sql = "insert into orders values(@name, @phone, @address, @status, @orders_date, @note)";
        SqlCommand cmd = new SqlCommand(sql, conn);

        cmd.Parameters.AddWithValue("name", name);

        cmd.Parameters.AddWithValue("phone", phone);
        cmd.Parameters.AddWithValue("address", address);
        cmd.Parameters.AddWithValue("status", 0);
        cmd.Parameters.AddWithValue("orders_date", order_date.ToString());
        cmd.Parameters.AddWithValue("note", note);

        SqlDataReader dr = cmd.ExecuteReader();
        conn.Close();
        //Tao danh sach
        List<Order_detail> ds = new List<Order_detail>();
        //Cau lenh truy van

        string sql1 = "select * from orders order by orders_id DESC";
        conn.Open();
        //Thuc thi cau lenh

        SqlCommand cmd1 = new SqlCommand(sql1, conn);
        //Doc du lieu tren table trong sql
        SqlDataReader rd = cmd1.ExecuteReader();
       
        while (rd.Read())
        {
            Order_detail c = new Order_detail();
            c.orders_id = (int)rd["orders_id"];
            
            ds.Add(c);
        }
        conn.Close();
        int orders_id = 0;
        for (int i = 0; i < ds.Count(); i++)
        {
            Order_detail o = ds[i];
            orders_id = o.orders_id;
            if (orders_id > 0)
            {
                if (Session["giohang"] != null)
                {
                    List<Product_Detail> listCart = Session["giohang"] as List<Product_Detail>;

                    for (int j = 0; j < listCart.Count(); j++)
                    {
                        Product_Detail pd = listCart[j];
                        string sql2 = "insert into orders_detail values(@orders_id, @product_detail_id, @quantity, @price)";
                        conn.Open();
                        SqlCommand cmd2 = new SqlCommand(sql2, conn);

                        cmd2.Parameters.AddWithValue("orders_id", orders_id);

                        cmd2.Parameters.AddWithValue("product_detail_id", pd.product_detail_id);
                        cmd2.Parameters.AddWithValue("quantity", pd.quantity);
                        cmd2.Parameters.AddWithValue("price", pd.price);

                        SqlDataReader ex = cmd2.ExecuteReader();                      
                        conn.Close();
                    }
                }
                else { 
                    
                }
                
            }
            break;
        }
        if (Session["giohang"] != null)
        {
            List<Product_Detail> listCart = Session["giohang"] as List<Product_Detail>;

            for (int j = 0; j < listCart.Count(); j++)
            {
                Product_Detail pdd = listCart[j];
                string sqlUpdate = "Update product_detail set product_detail.quantity = product_detail.quantity-@quantity where product_detail.product_detail_id=@id";
                conn.Open();
                SqlCommand cmdU = new SqlCommand(sqlUpdate, conn);
                
                cmdU.Parameters.AddWithValue("id", pdd.product_detail_id);
                cmdU.Parameters.AddWithValue("quantity", pdd.quantity);
                cmdU.Parameters.AddWithValue("price", pdd.price);
                SqlDataReader ex1 = cmdU.ExecuteReader();
                conn.Close();
            }
        }

    }
}