using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Category
/// </summary>
public class Category
{
    public int category_id { get; set; }
    public string category { get; set; }
    public string image { get; set; }
	public Category()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public Category(int category_id,string category,string image)
    {
        this.category_id = category_id;
        this.category = category;
        this.image = image;
    }
}