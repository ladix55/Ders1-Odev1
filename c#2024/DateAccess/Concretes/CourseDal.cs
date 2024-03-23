using c_2024.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_2024.DateAccess.Concretes
{   
    public class CourseDal
    {
        List<Course> courses;
        public CourseDal()
        {
            Course course1 = new Course();
            course1.Id = 1;
            course1.Name = "C#";
            course1.Description = ".Net 8...";
            course1.Price = 0;

            Course course2 = new Course();
            course2.Id = 2;
            course2.Name = "Python";
            course2.Description = "Python 3.5";
            course2.Price = 10;

            Course course3 = new Course();
            course3.Id = 3;
            course3.Name = "JAVA";
            course3.Description = "Java ile Nesene...";
            course3.Price = 55;

            courses = new List<Course> { course1, course2, course3 };

        }
        public List<Course> GetAll()
        {
            //burada db işlemleri yapılır.
        }
    }
}
