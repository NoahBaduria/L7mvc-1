using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{

    /* //tinfo200:[2021-03-13-NoahBad-dykstra1] - All info needed for courses. CourseID, Title, and how many credits the course is worth
     
     
     
     
     */
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}