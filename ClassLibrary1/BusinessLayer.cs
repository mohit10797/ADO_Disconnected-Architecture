using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary3; 

namespace ClassLibrary1
{

    public class BusinessLayer
    {
        course c = new course();
        DataLayere d = new DataLayere();
        DataTable dt = new DataTable();
        
        public void insert_course(course c)
        {
            try
            {

                d.insert(c);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public void delete_course(course c)
        {
            try
            {
                d.delete(c);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public void update_course(course c)
        {
            try {
                d.update(c);
            }catch(Exception e)
            {
                throw (e);
            }
            }
        public void search_course(course c)
        {
            try
            {
                d.search(c);
            }catch(Exception e)
            {
                throw (e);
            }
            }
        public DataSet grid_fill()
        {
            return d.grid_fill();
        }

    }
    
}
