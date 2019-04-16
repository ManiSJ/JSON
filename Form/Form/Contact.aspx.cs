using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Form
{
    public partial class Contact : System.Web.UI.Page
    {
        SqlConnection sqlconn = new SqlConnection(@"Data Source=DESKTOP-E0MRPDM\SQLEXPRESS;Initial Catalog=ASPCRUD;Integrated Security=True;");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btnDelete.Enabled = false;
                GridFill();
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            hfContactID.Value = "";
            txtname.Text = "";
            txtmobile.Text = "";
            txtaddress.Text = "";
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            lblSuccessMessage.Text = lblErrorMessage.Text = "";
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (sqlconn.State == ConnectionState.Closed)
                sqlconn.Open();
            SqlCommand sqlcmd = new SqlCommand("ContactCreateorUpdate",sqlconn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@ContactID", hfContactID.Value == "" ? 0 : Convert.ToInt32(hfContactID.Value));
            sqlcmd.Parameters.AddWithValue("@Name", txtname.Text.Trim());
            sqlcmd.Parameters.AddWithValue("@Mobile", txtmobile.Text.Trim());
            sqlcmd.Parameters.AddWithValue("@Address", txtaddress.Text.Trim());
            sqlcmd.ExecuteNonQuery();
            sqlconn.Close();
            string ContactID = hfContactID.Value;
            Clear();
            if (ContactID == "")
            {
                lblSuccessMessage.Text = "Saved";
            }
            else
            {
                lblSuccessMessage.Text = "Updated";
            }
            GridFill();
        }

        void GridFill()
        {
            if (sqlconn.State == ConnectionState.Closed)
                sqlconn.Open();

            SqlDataAdapter sqlda = new SqlDataAdapter("ContactViewAll",sqlconn);
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            sqlconn.Close();

            gvContact.DataSource = dt;
            gvContact.DataBind();
        }

        protected void lnk_OnClick(object sender, EventArgs e)
        {
            int ContactID = Convert.ToInt32((sender as LinkButton).CommandArgument);
            if (sqlconn.State == ConnectionState.Closed)
                sqlconn.Open();

            SqlDataAdapter sqlda = new SqlDataAdapter("ContactViewByID", sqlconn);
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlda.SelectCommand.Parameters.AddWithValue("@ContactID", ContactID);

            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            sqlconn.Close();
            hfContactID.Value = ContactID.ToString();
            txtname.Text = dt.Rows[0]["Name"].ToString();
            txtmobile.Text = dt.Rows[0]["Mobile"].ToString(); 
            txtaddress.Text = dt.Rows[0]["Address"].ToString();
            btnSave.Text = "Update";
            btnDelete.Enabled = true;

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (sqlconn.State == ConnectionState.Closed)
                sqlconn.Open();
            SqlCommand sqlcmd = new SqlCommand("ContactDeleteByID", sqlconn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@ContactID", hfContactID.Value == "" ? 0 : Convert.ToInt32(hfContactID.Value));
            sqlcmd.ExecuteNonQuery();
            sqlconn.Close();
            Clear();
            lblSuccessMessage.Text = "Deleted";
            GridFill();
        }
    }
}