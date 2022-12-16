using DTO.Doctors;
using DTO.Records;
using Exam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Mapper
{
    public class DbMapper
    {
        public void Create()
        {
            AutoMapper.Mapper.CreateMap<Doctor, DoctorInfo>();
            AutoMapper.Mapper.CreateMap<DoctorInfo, Doctor>();

            AutoMapper.Mapper.CreateMap<Doctor, SignInDoctorInfo>();
            AutoMapper.Mapper.CreateMap<SignInDoctorInfo, Doctor>();


            AutoMapper.Mapper.CreateMap<Record, AddRecordInfo>();
            AutoMapper.Mapper.CreateMap<AddRecordInfo, Record>();

            AutoMapper.Mapper.CreateMap<Record, InfoRecord>();
            AutoMapper.Mapper.CreateMap<InfoRecord, Record>();

            AutoMapper.Mapper.CreateMap<Record, UpdateDateTimeRecord>();
            AutoMapper.Mapper.CreateMap<UpdateDateTimeRecord, Record>();



        }
    }
}
