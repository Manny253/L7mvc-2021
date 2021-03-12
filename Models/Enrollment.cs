namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-03-eman2021-dykstra1]- when a student is a enrolled they will be given 
    // an enrollmentID, Course ID, StudentID, Grade(may have null value), and student property.
    //the grade is and enumeration type that holds the contant values of A, B, C, D, F
    //which are the grades given to a student 

    public enum Grade 
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        public Student Student { get; set; }

    }
}