using System.Collections.Generic;
using CSharpCourseWeek2Task3.Entities;

namespace CSharpCourseWeek2Task3.DataAccess.Abstracts
{
    public interface IInstructorDal
    {
        List<Instructor> GetAll();
        void Add(Instructor instructor);
        void Update(Instructor instructor);
        void Delete(int id);
    }
}