using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Form
{
    public partial class CRUD : System.Web.UI.Page
    {
        CrudDataContext DbContext = new CrudDataContext();

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void GetData()
        {
            GridView1.DataSource = DbContext.Products;
            GridView1.DataBind();
        }

        protected void Create_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = DbContext.Products;
            GridView1.DataBind();
        }

        protected void Insert_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.ProductName = "Dress";
            p.Price = 20;
            p.Count = 12;
            DbContext.Products.InsertOnSubmit(p);
            DbContext.SubmitChanges();

            GetData();
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            Product q = DbContext.Products.Where(x => x.ProductID == 5).FirstOrDefault();
            q.ProductName = "RobDress";
            q.Price = 220;
            q.Count = 112;

            DbContext.SubmitChanges();

            GetData();
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            Product p = DbContext.Products.Where(x => x.ProductID == 6).FirstOrDefault();
            DbContext.Products.DeleteOnSubmit(p);
            DbContext.SubmitChanges(); 

            GetData();
        }
    }
}