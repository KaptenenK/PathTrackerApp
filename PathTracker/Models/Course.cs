using System.ComponentModel.DataAnnotations;

namespace PathTracker.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        public string CourseName { get; set; } 

        public int CoursePathId { get; set; }
        public CoursePath CoursePath { get; set; }
        public ICollection<UserTimeSpent>? UserTimeSpendings { get; set; }
    }
}
