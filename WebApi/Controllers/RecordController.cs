using DTO.Records;
using Microsoft.AspNetCore.Mvc;
using Services.Services.Interfaces;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class RecordController : ControllerBase
    {
        IRecordService recordService;
        public RecordController(IRecordService recordService)
        {
            this.recordService = recordService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<InfoRecord>> GetInRoom(int roomId)
        {
            try
            {
                return Ok(recordService.GetInRoom(roomId));
            } catch (Exception e) { return BadRequest(e); }
        }
        [HttpGet("{roomId} {searchName}")]
        public ActionResult<IEnumerable<InfoRecord>> GetInRoom(int roomId,string searchName)
        {
            try
            {
                return Ok(recordService.GetInRoomWithName(roomId,searchName));
            }
            catch (Exception e) { return BadRequest(e); }
        }

        [HttpGet("{searchName}")]
        public ActionResult<IEnumerable<InfoRecord>> GetWithName(string searchName)
        {
            try
            {
                return Ok(recordService.GetWithName( searchName));
            }
            catch (Exception e) { return BadRequest(e); }
        }

        [HttpPost]
        public ActionResult AddRecord( AddRecordInfo info)
        {
            try
            {
                recordService.Add(info);
                return Ok();
            }catch(Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPut] 
        public ActionResult UpdateDateTime(UpdateDateTimeRecord update)
        {
            try
            {
                recordService.UpdateDate(update);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        [HttpDelete("{id}")]
       public  ActionResult DeleteRecord(int id)
        {
            try
            {
                recordService.Delete(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }


    }
}
