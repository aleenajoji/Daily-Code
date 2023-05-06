using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpDBEntities e1= new EmpDBEntities();
            foreach (var item in e1.DEPARTMENTS)
            {
                Console.WriteLine(item.department_name);
            }
               /* using (var context = new EmpDBEntities())

                {

                    var dept = new DEPARTMENT()

                    {

                        department_id = 110,

                        department_name = "IT"


                    };


                    context.DEPARTMENTS.Add(dept);

                    context.SaveChanges();

                }*/
           /* using (var context = new EmpDBEntities())
            {
                var std = context.DEPARTMENTS.First<DEPARTMENT>();
                std.department_name = "CIVIL";
                context.SaveChanges();
            }*/
            using (var context = new EmpDBEntities())
            {
                var query =  context.DEPARTMENTS.Where(s => s.department_id == 501).
                    FirstOrDefault<DEPARTMENT>();

                query.department_name = "CIVIL";
                context.SaveChanges();
            }


        }

        }

    }

