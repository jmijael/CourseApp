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
    public partial class CourseView : System.Web.UI.Page
    {
        private CourseData courseData;
        protected void Page_Load(object sender, EventArgs e)
        {
            courseData = new CourseData();
            if (!IsPostBack)
            {
                ddlCourse.DataSource = courseData.List();
                ddlCourse.DataBind();
                ddlCourse.SelectedIndex = -1;
                tbId.Text = "0";
                tbName.Text = "";
            }
        }

        protected void ddlCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbId.Text = ddlCourse.SelectedItem.Value;
            tbName.Text = ddlCourse.SelectedItem.Text;
            Console.WriteLine(tbId.Text);
            Console.WriteLine(tbName.Text);
        }
        protected void btNew_Click(object sender, EventArgs e)
        {
            tbId.Text = "0";
            tbName.Text = "";
        }

        protected void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                CCourse currentCourse = new CCourse(int.Parse(tbId.Text), tbName.Text);
                if (courseData.Save(currentCourse))
                {
                    ddlCourse.DataSource = courseData.List();
                    ddlCourse.DataBind();
                }
            }
            catch (Exception ex)
            {
            }

        }
    }
}