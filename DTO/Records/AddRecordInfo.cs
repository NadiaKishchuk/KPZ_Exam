using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Records
{
    public class AddRecordInfo
    {
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
