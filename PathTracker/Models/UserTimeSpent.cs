namespace PathTracker.Models
{
    public class UserTimeSpent
    {
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set;}

        public int Duration { get; set; }
    }
}
