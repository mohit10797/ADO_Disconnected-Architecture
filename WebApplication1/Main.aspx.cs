using System;
using System.Collections.Generic;
using System.Data;
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
                c.address_id = Convert.ToInt16(Textid.Value);
                c.first_name = Textfname.Text;
                c.last_name = (Textlname.Text);
                c.email = Textemail.Text;
                c.phone = Convert.ToChar(Textphone.Text);
                d.insert_course(c);
            }
            catch (Exception E)
            {
                
            }
            

            
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            try
            {
                //BusinessLayer d = new BusinessLayer();
                c.address_id = Convert.ToInt16(Textid.Value);
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
                c.first_name = Textfname.Text;
                c.last_name = Textlname.Text;
                c.email = Textemail.Text;
                c.phone = Convert.ToChar(Textphone.Text);
                c.address_id = Convert.ToInt16(Textid.Value);
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
                c.address_id = Convert.ToInt16(Textid.Value);
                d.search_course(c);
                c.first_name = Textfname.Text;
                c.last_name = Textlname.Text;
                c.email = Textemail.Text;
                c.address_id = Convert.ToInt16(Textid.Value);
            }
            catch(Exception E)
            {
                Response.Write(E.Message);
            }
            }

        protected void Find_lastname_Click(object sender, EventArgs e)
        {
            
        }
        protected void Browse_all_enteries_Click(object sender, EventArgs e)
        {
            DataSet ds = d.grid_fill();
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }

        protected void Search_button_Click(object sender, EventArgs e)
        {
            d.search_course(c);
            Textfname.Text = c.first_name;
            Textlname.Text = c.last_name;
            Textemail.Text = c.email;
            Textphone.Text = Convert.ToString(c.phone);
        }
    }
}