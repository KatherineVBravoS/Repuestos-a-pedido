using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using proyecto.Controller;
using proyecto.Model;

namespace proyecto.View.Repuestos
{
    public partial class ejemplo : System.Web.UI.Page
    {
        public void BindData()
        {
            RepuestoController con = new RepuestoController();
            DataTable dt = con.ReadRepuestos();

            GridRepuestos.DataSource = dt;
            GridRepuestos.DataBind();

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                BindData();
            }

        }
       

        protected void upload_Click(object sender, EventArgs e)
        {
            
        }
        protected void ImageData()
        {
           
        }
        // edit event
        protected void gvImage_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridRepuestos.EditIndex = e.NewEditIndex;
            ImageData();

        }
        // update event
        protected void gvImage_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
        }
        // cancel edit event
        protected void gvImage_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridRepuestos.EditIndex = -1;
            ImageData();
        }
        //delete event
        protected void gvImage_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            
        }
        /// <summary>
        /// This function is used to delete image from folder when deleting in gridview.
        /// </summary>
        /// <param name="imagename">image name</param>
        protected void ImageDeleteFromFolder(string imagename)
        {
           
        }
    }
}