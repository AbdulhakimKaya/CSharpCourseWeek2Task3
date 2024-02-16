using System.Collections.Generic;
using CSharpCourseWeek2Task3.DataAccess.Abstracts;
using CSharpCourseWeek2Task3.Entities;

namespace CSharpCourseWeek2Task3.Business
{
    public class CourseManager
    {
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }

        public void Delete(int id)
        {
            _courseDal.Delete(id);
        }
    }
}