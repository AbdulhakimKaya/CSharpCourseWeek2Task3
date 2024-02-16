namespace CSharpCourseWeek2Task3.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }


        public Category()
        {
        }

        public Category(int ıd, string categoryName)
        {
            Id = ıd;
            CategoryName = categoryName;
        }
    }
}