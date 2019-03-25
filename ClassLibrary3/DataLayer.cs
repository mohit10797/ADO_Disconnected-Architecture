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
             da = new SqlDataAdapter("Select * from Address_Book",sq);
            da.Fill(data);
        }
        public void insert(course course)
        {
            try
            {
                fill_dataset();
                dr = data.Tables[0].NewRow();
                dr["First_Name"] = course.first_name;
                dr["Last_Name"] = course.last_name;
                dr["Email"] = course.email;
                dr["Phone"] = course.phone;
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
                    if (Convert.ToInt16(dr["Address_id"]) == course.address_id)
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
                    if (Convert.ToInt16(dr["Address_id"]) == course.address_id)
                    {
                        dr["First_Name"] = course.first_name;
                        dr["Last_Name"] = course.last_name;
                        dr["Email"] = course.email;
                        dr["Phone"] = course.phone;
                        data.Tables[0].Rows.Add(dr);
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
                    if (Convert.ToInt16(dr["Address_id"]) == course.address_id)
                    {
                        course.first_name = Convert.ToString(dr["First_Name"]);
                        course.last_name = Convert.ToString(dr["Last_Name"]);
                        course.email = Convert.ToString(dr["Email"]);
                        course.phone = Convert.ToChar(dr["Phone"]);
                    }
                }
                update();
            }catch(Exception e)
            {
                throw (e);
            }


        }
        public DataSet grid_fill()
        {
            fill_dataset();
            return data;
        }
         
    }
}
