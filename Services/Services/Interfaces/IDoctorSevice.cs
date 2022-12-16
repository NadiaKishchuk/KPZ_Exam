using DTO.Doctors;
using Exam.Models;
using Microsoft.EntityFrameworkCore.Update.Internal;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Services.Services.Interfaces
{
    public interface IDoctorSevice
    {
        DoctorInfo Get(int id);
        IEnumerable<DoctorInfo> GetAll();
        DoctorInfo SignIn(SignInDoctorInfo signInInfo);
        
    }
}
