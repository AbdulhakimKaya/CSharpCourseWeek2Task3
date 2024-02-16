namespace CSharpCourseWeek2Task3.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
        public string CourseName { get; set; }
        public double Price { get; set; }

        public Course()
        {
        }

        public Course(int ıd, int categoryId, int ınstructorId, string courseName, double price)
        {
            Id = ıd;
            CategoryId = categoryId;
            InstructorId = ınstructorId;
            CourseName = courseName;
            Price = price;
        }
    }
}