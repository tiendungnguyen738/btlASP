using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for User
/// </summary>
public class User
{
    public int employee_id { get; set; }
    public string full_name { get; set; }
    public string address { get; set; }
    public int sex { get; set; }
    public string idccard { get; set; }
    public int role_id { get; set; }
    public string email { get; set; }
    public string username { get; set; }
    public string password { get; set; }
    public string phone { get; set; }
    public User()
    {
    }
    public User(string fullnam, string addr,int gender,string id2,int role,string email,string username1, string pass,string phon)
    {
        full_name = fullnam;
        address = addr;
        sex = gender;
        idccard = id2;
        role_id = role;
        this.email = email;
        username = username1;
        password = pass;
        phone = phon;
    }
}