using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PathTracker.Models
{
    public class CoursePath
    {
        public int Id { get; set; }
        [Required]
        public string PathName { get; set; }
        public IList<Course> Courses { get; set; }
        [NotMapped]
        public bool ShowDetails { get; set; }
    }
}
