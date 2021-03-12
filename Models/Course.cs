using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

//tinfo200:[2021-03-03-eman2021-dykstra1]-created new course "class". Similar to the student class 
//there are identifiers within the course class that define a course which are the course ID, Title, Credits.
//intoduced the DatabaseGenerated attribute 

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
