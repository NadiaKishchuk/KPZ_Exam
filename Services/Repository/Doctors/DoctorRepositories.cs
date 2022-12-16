using DTO.Doctors;
using Exam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository.Doctors
{
    public class DoctorRepositories : IDoctorRepositories
    {
        PsychotherapeuticClinicContext context { get; set; }
        public DoctorRepositories( PsychotherapeuticClinicContext context)
        {
            this.context = context;
        }

        public void Add(Doctor newItem)
        {
           context.Doctors.Add(newItem);
        }

        public void Delete(int id)
        {
            var record = context.Doctors.FirstOrDefault(r => r.Id == id);
            if (record == null)
            {
                throw new ArgumentException($"No such patient with id={id}");

            }

            context.Doctors.Remove(record);
        }

        public Doctor Get(int id)
        {
            return context.Doctors.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Doctor> GetAll()
        {
            return context.Doctors.ToList();
        }

        public void Update(Doctor newItem)
        {
            context.Update(newItem);
        }

        public Doctor SignIn( string login,string password)
        {
           var doctors =  context.Doctors.Where(d=>d.Login.Equals(login)).ToList();
            return doctors.Where(d => d.Password.Equals(password)).FirstOrDefault();
        }

    }
}
