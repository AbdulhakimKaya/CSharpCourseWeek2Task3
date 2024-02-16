using System;
using System.Collections.Generic;
using CSharpCourseWeek2Task3.Business;
using CSharpCourseWeek2Task3.DataAccess.Concretes;
using CSharpCourseWeek2Task3.Entities;

namespace CSharpCourseWeek2Task3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Category
            Console.WriteLine("========== CATEGORY ==========");
            
            CategoryManager categoryManager = new CategoryManager(new CategoryDal());
            List<Category> categories = categoryManager.GetAll();

            Category category1 = new Category(4, "Yapay Zeka");
            categoryManager.Add(category1);
            
            categoryManager.Update(new Category(3, "Web Programlama"));
            
            categoryManager.Delete(2);
            
            
            foreach (var category in categories)
            {
                Console.WriteLine(category.CategoryName);
            }
            
            
            // Instructor
            Console.WriteLine("\n========= INSTRUCTOR =========");
            
            InstructorManager instructorManager = new InstructorManager(new InstructorDal());
            List<Instructor> instructors = instructorManager.GetAll();

            Instructor instructor1 = new Instructor(3, "Ömer Faruk", "Doğan", "Javaloper");
            instructorManager.Add(instructor1);
            
            instructorManager.Update(new Instructor(3, "Ömer Faruk", "Doğan", "Javaloper, .Netloper"));
            
            instructorManager.Delete(2);


            foreach (var instructor in instructors)
            {
                Console.WriteLine("{0} {1} / {2}", instructor.FirstName, instructor.LastName, instructor.Autobiography);
            }

            
            // Course
            Console.WriteLine("\n=========== COURSE ===========");

            CourseManager courseManager = new CourseManager(new CourseDal());
            List<Course> courses = courseManager.GetAll();

            Course course1 = new Course(3, 1, 1, "2024 Yazılım Geliştirici Yetiştirme Kampı (Java)", 0);
            courseManager.Add(course1);
            
            courseManager.Update(new Course(1, 1, 1, "2020 Yazılım Geliştirici Yetiştirme Kampı (C# + Angular)", 0));
            
            courseManager.Delete(2);

            
            foreach (var course in courses)
            {
                Console.WriteLine(course.CourseName);
            }
        }
    }
}