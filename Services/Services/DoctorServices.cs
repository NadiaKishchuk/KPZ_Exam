using DTO.Doctors;
using Exam.Models;
using Services.Repository.Doctors;
using Services.Services.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class DoctorService : IDoctorSevice
    {
        IDoctorRepositories repositories;
        public DoctorService(IDoctorRepositories repositories)
        {
            this.repositories = repositories;
        }
        public DoctorInfo Get(int id)
        {
            var doctor = repositories.Get(id);
            if (repositories == null)
            {
                throw new ArgumentException("no such doctor");
            }
            return AutoMapper.Mapper.Map<Doctor, DoctorInfo>(doctor);
                
        }

       

        public DoctorInfo SignIn(SignInDoctorInfo signInInfo)
        {
            
            var doctor = repositories.SignIn(signInInfo.Login, signInInfo.Password);
            if (doctor != null)
            {
                return AutoMapper.Mapper.Map<Doctor, DoctorInfo>(doctor);
            }
            throw new ArgumentException("Invalid password");
            return null;

        }

        public IEnumerable<DoctorInfo> GetAll()
        {
           return AutoMapper.Mapper
                .Map<IEnumerable<Doctor>,IEnumerable<DoctorInfo>>(repositories.GetAll());
        }
    }
}
