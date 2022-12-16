using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Doctors
{
    public class DoctorInfo
    {
        public int Id { get; set; }

        [MaxLength(40), Required]
        public string Name { get; set; }

        [MaxLength(40), Required]
        public string Surname { get; set; }

        public int RoomId { get; set; }
    }
}
