using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CoursesApp.Entity;
using CoursesApp.Data;

namespace CoursesApp.Views
{
    public partial class StudentView : System.Web.UI.Page
    {
        private IStudentRepository studentRepo;
        public StudentView(IStudentRepository pstudentRepo)
        {
            studentRepo = pstudentRepo;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                Repeater1.DataSource = studentRepo.List();
                Repeater1.DataBind();
            }
        }
        public void R1_ItemDataBound(Object Sender, RepeaterItemEventArgs e)
        {

            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                    ((Label)e.Item.FindControl("IdLabel")).ForeColor = System.Drawing.Color.Blue;
            }
        }
    }
}