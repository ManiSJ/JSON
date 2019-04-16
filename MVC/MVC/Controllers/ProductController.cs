using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using MVC.Models;

namespace MVC.Controllers
{
    public class ProductController : Controller
    {
        string connectionString = @"Data Source=DESKTOP-E0MRPDM\SQLEXPRESS;Initial Catalog=MvcCrudDB;Integrated Security=True;";
        [HttpGet]
        public ActionResult Index()
        {
            DataTable dtblproduct = new DataTable();
            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                if (sqlconn.State == ConnectionState.Closed)
                    sqlconn.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("Select * from Product", sqlconn);
                sqlda.Fill(dtblproduct);
                sqlconn.Close();
            }
            return View(dtblproduct);
        }

        [HttpGet]
        public ActionResult Create()
        {          
            return View( new ProductModel());
        }

        [HttpPost]
        public ActionResult Create(ProductModel productModel)
        {
            try
            {
                using (SqlConnection sqlconn = new SqlConnection(connectionString))
                {
                    if (sqlconn.State == ConnectionState.Closed)
                        sqlconn.Open();
                    string query = "Insert into Product values(@ProductName,@Price,@Count)";
                    SqlCommand sqlcmd = new SqlCommand(query, sqlconn);
                    sqlcmd.Parameters.AddWithValue("@ProductName", productModel.ProductName);
                    sqlcmd.Parameters.AddWithValue("@Price", productModel.Price);
                    sqlcmd.Parameters.AddWithValue("@Count", productModel.Count);
                    sqlcmd.ExecuteNonQuery();
                    sqlconn.Close();
                }
                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ProductModel pm = new ProductModel();
            DataTable dtblproduct = new DataTable();
            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                if (sqlconn.State == ConnectionState.Closed)
                    sqlconn.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("Select * from Product where ProductID=@ProductID", sqlconn);
                sqlda.SelectCommand.Parameters.AddWithValue("@ProductID", id);
                sqlda.Fill(dtblproduct);
                sqlconn.Close();
            }
            if (dtblproduct.Rows.Count == 1)
            {
                pm.ProductID = Convert.ToInt32(dtblproduct.Rows[0][0].ToString());
                pm.ProductName = dtblproduct.Rows[0][1].ToString();
                pm.Price = Convert.ToDecimal(dtblproduct.Rows[0][2].ToString());
                pm.Count = Convert.ToInt32(dtblproduct.Rows[0][3].ToString());

                return View(pm);
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }

        [HttpPost]
        public ActionResult Edit(ProductModel productModel)
        {
            try
            {
                using (SqlConnection sqlconn = new SqlConnection(connectionString))
                {
                    if (sqlconn.State == ConnectionState.Closed)
                        sqlconn.Open();
                    string query = "Update Product set ProductName=@ProductName,Price=@Price,Count=@Count where ProductID=@ProductID";
                    SqlCommand sqlcmd = new SqlCommand(query, sqlconn);
                    sqlcmd.Parameters.AddWithValue("@ProductName", productModel.ProductName);
                    sqlcmd.Parameters.AddWithValue("@Price", productModel.Price);
                    sqlcmd.Parameters.AddWithValue("@Count", productModel.Count);
                    sqlcmd.Parameters.AddWithValue("@ProductID", productModel.ProductID);
                    sqlcmd.ExecuteNonQuery();
                    sqlconn.Close();
                }
                return RedirectToAction("Index");
            }
            catch(Exception e)
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                if (sqlconn.State == ConnectionState.Closed)
                    sqlconn.Open();
                string query = "Delete from Product where ProductID=@ProductID";
                SqlCommand sqlcmd = new SqlCommand(query, sqlconn);
                sqlcmd.Parameters.AddWithValue("@ProductID", id);
                sqlcmd.ExecuteNonQuery();
                sqlconn.Close();
            }
            return RedirectToAction("Index");
        }

    }
}
