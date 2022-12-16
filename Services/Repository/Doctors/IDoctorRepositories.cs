using DTO.Doctors;
using Exam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository.Doctors
{
    public interface IDoctorRepositories:IRepository<Doctor>
    {
        Doctor SignIn(string login, string password);
    }
}
