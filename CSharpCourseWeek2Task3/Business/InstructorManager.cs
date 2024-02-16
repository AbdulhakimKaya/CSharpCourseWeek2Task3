using System.Collections.Generic;
using CSharpCourseWeek2Task3.DataAccess.Abstracts;
using CSharpCourseWeek2Task3.Entities;

namespace CSharpCourseWeek2Task3.Business
{
    public class InstructorManager
    {
        private readonly IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }

        public void Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
        }

        public void Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);
        }

        public void Delete(int id)
        {
            _instructorDal.Delete(id);
        }
    }
}