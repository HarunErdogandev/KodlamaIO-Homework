using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate
{
    public class CourseDal : ICourseDal
    {
        public List<Course> Courses;
        public CourseDal()
        {
            Courses = new List<Course>()
            {
                new Course
                {
                    CategoryId = 1,CourseId = 1, CourseName="Senior Yazılım Geliştirici Yetiştirme Kampı",
                },
                 new Course
                {
                    CategoryId = 1,CourseId = 2, CourseName="Yazılım Geliştirici Yetiştirme Kampı",
                }
            };
        }
        public void Add(Course entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Course entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Course entity)
        {
            throw new NotImplementedException();
        }
        public int FunctionName(int categoryID)
        {
           var result= Courses.Where(x => x.CategoryId == categoryID).ToList().Count;
            return result;
        }
    }
}
