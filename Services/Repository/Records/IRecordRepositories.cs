using DTO.Records;
using Exam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository.Records
{
    public interface IRecordRepositories:IRepository<Record>
    {
        IEnumerable<Record> GetInRoom(int roomId);
        void UpdateDateTimeRecord(int id, DateTime newDate);
        IEnumerable<Record> SearchRecords(int roomId, string name);
        IEnumerable<Record> SearchRecords(string name);
    }
}
