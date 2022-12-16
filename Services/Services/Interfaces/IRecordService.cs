using DTO.Records;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.Interfaces
{
    public interface IRecordService
    {
        IEnumerable<InfoRecord> GetAll();
        InfoRecord Get(int id);
        void Delete(int id);
        void Add(AddRecordInfo newRecord);
        void UpdateDate(UpdateDateTimeRecord updateDateTime);
        IEnumerable<InfoRecord> GetInRoom(int idRoom);
        IEnumerable<InfoRecord> GetInRoomWithName(int idRoom,string name);
        IEnumerable<InfoRecord> GetWithName( string name);

    }
}
