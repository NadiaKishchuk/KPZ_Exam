using Exam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository.Records
{
    public class RecordRepositories : IRecordRepositories
    {
        PsychotherapeuticClinicContext context { get; set; }
        public RecordRepositories(PsychotherapeuticClinicContext context)
        {
            this.context = context;
        }

        public void Add(Record newItem)
        {
            context.Add(newItem);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var record = context.Records.FirstOrDefault(r => r.Id == id);
            if (record == null)
            {
                throw new ArgumentException($"No such patient with id={id}");

            }

            context.Records.Remove(record);
            context.SaveChanges();
        }

        public Record Get(int id)
        {
            return context.Records.FirstOrDefault(r => r.Id == id);
        }

        public void Update(Record newItem)
        {
            context.Update(newItem);
            context.SaveChanges();
            
        }
        public void UpdateDateTimeRecord(int id, DateTime newDate)
        {
            var rec=context.Records.FirstOrDefault(r => r.Id == id);
            if (rec == null)
            {
                throw new ArgumentException("no such record");
            }

            rec.DateTime = newDate;
        }

        public IEnumerable<Record> GetAll()
        {
            return context.Records.ToList();
        }

        public IEnumerable<Record> GetInRoom(int roomId)
        {
            if (context.Rooms.FirstOrDefault(r => r.Id == roomId) == null)
                throw new ArgumentException("no such room");
            return context.Records.Where(r => r.Doctor.RoomId==roomId).ToList();
            
        }

        public IEnumerable<Record> SearchRecords(int roomId, string name)
        {
           var records = GetInRoom(roomId);
           return records.Where(r=>r.Name.Contains(name));
        }
        public IEnumerable<Record> SearchRecords( string name)
        {
            
            return context.Records.Where(r => r.Name.Contains(name));
        }
    }

        
}
