using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.WebSockets;

namespace CourseApp.Models
{
    [Table("Courses")]
    public class Course
    {
        [Key]
        public int CID { get; set; }
        public string CName { get; set; }
        public float CFee { get; set; }
        public string CStatus { get; set; } 
        public string Technology { get; set; }

    }
}
