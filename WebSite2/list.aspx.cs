using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using BLL;
public partial class list : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            GridBind();
        }
    }
    public void GridBind()
    {
        BeiJiBLL bLL = new BeiJiBLL();
        List<班级> list = bLL.GetAll();
        this.GridView1.DataSource = list;
        this.GridView1.DataBind();
    }


    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string id = this.GridView1.DataKeys[e.RowIndex].Value.ToString();
        BeiJiBLL b = new BeiJiBLL();
        if (b.Delete(id) > 0)
        {

            Response.Write("<script>alert('cg');location.href='list.aspx';</script>");
        }
    }
}