using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Models;
public partial class Update : System.Web.UI.Page
{
    BeiJiBLL b = new BeiJiBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            string id = Request.QueryString["id"];

            班级 a = b.GetOne(id);
            TextBox1.Text = a.班级号;
            TextBox2.Text = a.班级名称;
            TextBox3.Text = a.学院编号;
            TextBox4.Text = a.班级人数.ToString();


        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        班级 a = new 班级();
        a.班级号 = this.TextBox1.Text;
        a.班级名称 = this.TextBox2.Text;
        a.学院编号 = this.TextBox3.Text;
        a.班级人数 = int.Parse(this.TextBox4.Text);
        if (b.Update(a) > 0)
        {
            Response.Write("<script>alert('成功');location.href='list.aspx';</script>");
        }
    }
}