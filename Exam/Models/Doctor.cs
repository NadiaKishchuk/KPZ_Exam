using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(40), Required]
        public string Name { get; set; }

        [MaxLength(40), Required]
        public string Surname { get; set; }

        [MinLength(8), MaxLength(16), Required]
        public string Login { get; set; }

        [MinLength(8), MaxLength(16), Required]
        public string Password { get; set; }

        public int RoomId { get; set; }

        public virtual Room  Room {get;set;}

        public virtual IEnumerable<Record> Records { get; set; }

    }
}
