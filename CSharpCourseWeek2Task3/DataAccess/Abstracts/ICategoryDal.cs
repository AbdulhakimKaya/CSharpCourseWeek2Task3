using System.Collections.Generic;
using CSharpCourseWeek2Task3.Entities;

namespace CSharpCourseWeek2Task3.DataAccess.Abstracts
{
    public interface ICategoryDal
    {
        List<Category> GetAll();
        void Add(Category category);
        void Update(Category category);
        void Delete(int id);
    }
}