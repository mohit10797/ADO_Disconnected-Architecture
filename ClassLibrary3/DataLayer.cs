using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ClassLibrary3
{
    public class DataLayere
    {
        DataRow dr;
        DataColumn dc;
        SqlDataAdapter da;
        
        DataSet data = new DataSet();
        void update()
        {
            SqlCommandBuilder sb = new SqlCommandBuilder(da);
            da.Update(data);
        }
        void fill_dataset()
        {
            SqlConnection sq = new SqlConnection("data source=FREYA;initial catalog=gic;integrated security=true");
             da = new SqlDataAdapter("Select * from course",sq);
            da.Fill(data);
        }
        public void insert(course course)
        {
            try
            {
                fill_dataset();
                dr = data.Tables[0].NewRow();
                dr["course_name"] = course.course_name;
                dr["credit"] = course.credit;
                dr["semester"] = course.semester;
                data.Tables[0].Rows.Add(dr);
                update();
            }catch(Exception e)
            {
                throw (e);
            }
        }

        public void delete(course course)
        {
            try
            {
                fill_dataset();
                foreach (DataRow dr in data.Tables[0].Rows)
                {
                    if (Convert.ToInt16(dr["course_id"]) == course.id)
                    {
                        dr.Delete();
                    }
                }
            }catch(Exception e)
            {
                throw e;
            }
            update();

        }
        public void update(course course)
        {
            try
            {
                fill_dataset();
                foreach (DataRow dr in data.Tables[0].Rows)
                {
                    if (Convert.ToInt16(dr["course_id"]) == course.id)
                    {
                        dr["course_name"] = course.course_name;
                        dr["credit"] = course.credit;
                        dr["semester"] = course.semester;
                    }
                }
                update();
            }catch(Exception e)
            {
                throw (e);
            }
            
        }

        public void search(course course)
        {
            fill_dataset();
            try
            {
                foreach (DataRow dr in data.Tables[0].Rows)
                {
                    if (Convert.ToInt16(dr["course_id"]) == course.id)
                    {
                        course.course_name = Convert.ToString(dr["course_name"]);
                        course.credit = Convert.ToInt32(dr["credit"]);
                        course.semester = Convert.ToInt32(dr["semester"]);
                    }
                }
                update();
            }catch(Exception e)
            {
                throw (e);
            }
        }
    }
}
