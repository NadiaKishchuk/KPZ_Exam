
using System.ComponentModel.DataAnnotations;


namespace DTO.Records
{
    public class InfoRecord
    {
    
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
    }
}
