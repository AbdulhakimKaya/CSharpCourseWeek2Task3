using System.Collections.Generic;
using CSharpCourseWeek2Task3.DataAccess.Abstracts;
using CSharpCourseWeek2Task3.Entities;

namespace CSharpCourseWeek2Task3.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        private List<Category> _categories;

        public CategoryDal()
        {
            Category category1 = new Category(1, "Backend");
            Category category2 = new Category(2, "Frontend");
            Category category3 = new Category(3, "Veri Bilimi");

            _categories = new List<Category> { category1, category2, category3 };
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Update(Category category)
        {
            foreach (var item in _categories)
            {
                if (item.Id == category.Id)
                {
                    item.CategoryName = category.CategoryName;
                }
            }
        }

        public void Delete(int id)
        {
            foreach (var item in _categories)
            {
                if (item.Id == id)
                {
                    _categories.Remove(item);
                    break;
                }
            }
        }
    }
}