using DTO.Records;
using Exam.Migrations;
using Exam.Models;
using Services.Repository.Records;
using Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class RecordService : IRecordService
    {
        IRecordRepositories repositories;
        public RecordService(IRecordRepositories repositories)
        {
            this.repositories = repositories;
        }

        public void Add(AddRecordInfo newRecord)
        {
            repositories.Add(AutoMapper.Mapper.Map<AddRecordInfo, Record>(newRecord));
        }

        public void Delete(int id)
        {
            repositories.Delete(id);
        }

        public InfoRecord Get(int id)
        {
            var record = repositories.Get(id);
            if (record == null)
                throw new ArgumentException("No such record");

            return AutoMapper.Mapper.Map<Record, InfoRecord>(record);
        }

        public IEnumerable<InfoRecord> GetAll()
        {
            return AutoMapper.Mapper.Map<IEnumerable<Record>, IEnumerable<InfoRecord>>(repositories.GetAll());
        }

        public IEnumerable<InfoRecord> GetInRoom(int idRoom)
        {
            return AutoMapper.Mapper.Map<IEnumerable<Record>, IEnumerable<InfoRecord>>(repositories.GetInRoom(idRoom));
        }

        public IEnumerable<InfoRecord> GetInRoomWithName(int idRoom, string name)
        {
            return GetInRoom(idRoom).Where(r => r.Name.Contains(name));
        }
        public IEnumerable<InfoRecord> GetWithName( string name)
        {
            return AutoMapper.Mapper.Map<IEnumerable<Record>, IEnumerable<InfoRecord>>(repositories.SearchRecords(name));
        }

        public void UpdateDate(UpdateDateTimeRecord updateDateTime)
        {
            repositories.UpdateDateTimeRecord(updateDateTime.id, updateDateTime.newDataTime);
            
        }
      
    }
}
