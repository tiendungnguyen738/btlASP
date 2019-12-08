using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Color
/// </summary>
public class Color
{
    public int color_id { get; set; }
    public string color { get; set; }
	public Color()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public Color(int color_id,string color)
    {
        this.color_id = color_id;
        this.color = color;
    }
}