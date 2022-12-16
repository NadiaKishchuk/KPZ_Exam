
using System.ComponentModel.DataAnnotations;

namespace Exam.Models
{
    public class Record
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int DoctorId { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        [MaxLength(40), Required]
        public string Name { get; set; }
        [Required]
        public int Repeatness { get; set; } = 0;
        [Required]
        public DateTime DateTime { get; set; }

        public virtual Doctor Doctor {get;set;}

    }
}
