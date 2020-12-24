using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using BLL;
public partial class insert : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        BeiJiBLL b = new BeiJiBLL();
        班级 bb = new 班级();
        bb.班级号 = this.TextBox1.Text;
        bb.班级名称 = this.TextBox2.Text;
        bb.学院编号 = this.TextBox3.Text;
        bb.班级人数 = int.Parse(this.TextBox4.Text);
        if (b.Add(bb) > 0)
        {
            Response.Write("<script>alert('成功');location.href='list.aspx';</script>");
        }

    }
}