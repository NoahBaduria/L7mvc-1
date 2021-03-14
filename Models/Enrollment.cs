namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }


    
   /* //tinfo200:[2021-03-13-NoahBad-dykstra1] - More info that is recquired for student enrollment.
                                                 This incldues course enrollment and student ID, Grade, course and student*/
  
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}