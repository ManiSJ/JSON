using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridView
{
    public class Grid
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string Mobile { get; set; }
    }

    public partial class pagecycle : System.Web.UI.Page
    {

        protected void Page_PreInit(object sender, EventArgs e)
        {

        }
        protected void Page_Init(object sender, EventArgs e)
        {

        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {

        }
        protected override void OnPreLoad(EventArgs e)
        {

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            // EmployeeDataContext context = new EmployeeDataContext();
            if (!IsPostBack)
            {
              /* IQueryable<Grid> ret = from t in context.Employees
                                       join d in context.EmployeeDetails on t.EmpID equals d.EmpID
                                       orderby t.EmpID
                                       select new Grid
                                       {
                                           EmpID = t.EmpID,
                                           EmpName = t.EmpName,
                                           Mobile = d.Mobile
                                       };
                Session["reulr"] = ret;  */
            }
            GridView1.DataSource = Session["reulr"];
            GridView1.DataBind(); 

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {

        }
        protected override void OnPreRender(EventArgs e)
        {

        }
        protected override void OnSaveStateComplete(EventArgs e)
        {

        }
        protected void Page_UnLoad(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GridView1.Rows[GridView1.SelectedIndex].BackColor == Color.Red)
            {
                GridView1.Rows[GridView1.SelectedIndex].BackColor = Color.White;
            }
            else
            {
                GridView1.Rows[GridView1.SelectedIndex].BackColor = Color.Red;
            }
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }

        protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
        {

        }

        protected void GridView1_Sorted(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void GridView1_PageIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_DataBinding(object sender, EventArgs e)
        {

        }

        protected void GridView1_DataBound(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = ClientScript.GetPostBackClientHyperlink(this.GridView1, "Select$" + e.Row.RowIndex);
            }
        }

        protected void GridView1_RowCreated(object sender, GridViewRowEventArgs e)
        {

        }
    }
}