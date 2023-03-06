using System.ComponentModel.DataAnnotations;

namespace PathTracker.Models
{
    public class UserTimeSpent
    {
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set;}

        [Range(0, int.MaxValue)]
        public int Duration { get; set; }
    }
}
