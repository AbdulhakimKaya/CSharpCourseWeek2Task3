using System;
using System.Collections.Generic;
using CSharpCourseWeek2Task3.DataAccess.Abstracts;
using CSharpCourseWeek2Task3.Entities;

namespace CSharpCourseWeek2Task3.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        private List<Instructor> _instructors;

        public InstructorDal()
        {
            Instructor instructor1 = new Instructor(1, "Engin", "Demiroğ", "MCT, PMP, ITIL");
            Instructor instructor2 = new Instructor(2, "Halit Enes", "Kalaycı", "Yazılım Geliştirici");

            _instructors = new List<Instructor> { instructor1, instructor2 };
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Update(Instructor instructor)
        {
            foreach (var item in _instructors)
            {
                if (item.Id == instructor.Id)
                {
                    item.FirstName = instructor.FirstName;
                    item.LastName = instructor.LastName;
                    item.Autobiography = instructor.Autobiography;
                }
            }
        }

        public void Delete(int id)
        {
            foreach (var item in _instructors)
            {
                if (item.Id == id)
                {
                    _instructors.Remove(item);
                    break;
                }
            }
        }
    }
}