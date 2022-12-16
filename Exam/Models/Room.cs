using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    public class Room
    {
        public int Id { get; set; }

        public virtual IEnumerable<Doctor> Doctors { get; set; }
    }
}
