using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;
using ClassLibrary3;
namespace WebApplication1
{
    public partial class Main : System.Web.UI.Page
    {

         BusinessLayer d = new BusinessLayer();
        course c = new course();
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void insert_Click(object sender, EventArgs e)
        {
            try
            {
                c.course_name = Textname.Text;
                c.credit = Convert.ToInt32(Textcredit.Text);
                c.semester = Convert.ToInt32(Textsemester.Text);
                d.insert_course(c);
            }
            catch (Exception E)
            {
                Response.Write(E.Message.ToString());
            }
            
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            try
            {
                //BusinessLayer d = new BusinessLayer();
                c.id = Convert.ToInt16(Textid.Text);
                d.delete_course(c);
            }
            catch(Exception E)
            {
                Response.Write(E.Message);
            }
        }

        protected void update_Click(object sender, EventArgs e)
        {
            try {
                //BusinessLayer d = new BusinessLayer();
                c.course_name = Textname.Text;
                c.credit = Convert.ToInt32(Textcredit.Text);
                c.semester = Convert.ToInt32(Textsemester.Text);
                c.id = Convert.ToInt16(Textid.Text);
                d.update_course(c);
            }catch(Exception E)

            {
                Response.Write(E.Message);
            }
            }

        protected void search_Click(object sender, EventArgs e)
        {
            try {
                //BusinessLayer d = new BusinessLayer();
                c.id = Convert.ToInt16(Textid.Text);
                d.search_course(c);
                Textname.Text = c.course_name;
                Textcredit.Text = Convert.ToString(c.credit);
                Textsemester.Text = Convert.ToString(c.semester);
            }catch(Exception E)
            {
                Response.Write(E.Message);
            }
            }
    }
}