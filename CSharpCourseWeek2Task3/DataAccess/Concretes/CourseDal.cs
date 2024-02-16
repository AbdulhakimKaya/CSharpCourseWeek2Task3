using System;
using System.Collections.Generic;
using CSharpCourseWeek2Task3.DataAccess.Abstracts;
using CSharpCourseWeek2Task3.Entities;

namespace CSharpCourseWeek2Task3.DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        private List<Course> _courses;

        public CourseDal()
        {
            Course course1 = new Course(1, 1, 1, "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)", 0);
            Course course2 = new Course(2, 2, 2, "2023 Yazılım Geliştirici Yetiştirme Kampı (Python)", 0);

            _courses = new List<Course> { course1, course2 };
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Update(Course course)
        {
            foreach (var item in _courses)
            {
                if (item.Id == course.Id)
                {
                    item.CategoryId = course.CategoryId;
                    item.InstructorId = course.InstructorId;
                    item.CourseName = course.CourseName;
                    item.Price = course.Price;
                }
            }
        }

        public void Delete(int id)
        {
            foreach (var item in _courses)
            {
                if (item.Id == id)
                {
                    _courses.Remove(item);
                    break;
                }
            }
        }
    }
}