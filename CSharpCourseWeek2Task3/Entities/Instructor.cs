namespace CSharpCourseWeek2Task3.Entities
{
    public class Instructor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Autobiography { get; set; }

        public Instructor()
        {
        }

        public Instructor(int ıd, string firstName, string lastName, string autobiography)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            Autobiography = autobiography;
        }
    }
}