using System.Collections.Generic;
using CSharpCourseWeek2Task3.Entities;

namespace CSharpCourseWeek2Task3.DataAccess.Abstracts
{
    public interface ICourseDal
    {
        List<Course> GetAll();
        void Add(Course course);
        void Update(Course course);
        void Delete(int id);
    }
}