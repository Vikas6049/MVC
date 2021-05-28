using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelClass;

namespace DataBaseConnect.Db.Dbopertions
{
    public class StudentRepository
    {
        public int AddStudent(StudentModel model)
        {
            try
            {
                using (var context = new TestDBEntities1())
                {
                    Testtable test = new Testtable()
                    {
                        Name = model.Name,
                        Email = model.Email
                        
                    };

                    context.Testtable.Add(test);
                    context.SaveChanges();
                    return test.Id;
                    //return 0;
                }

            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
                return 0;
            }
           
        }
    }
}
