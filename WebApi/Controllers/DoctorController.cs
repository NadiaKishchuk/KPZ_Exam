using DTO.Doctors;
using Microsoft.AspNetCore.Mvc;
using Services.Services.Interfaces;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class DoctorController : ControllerBase
    {
        public IDoctorSevice service { get; set; }
        public DoctorController(IDoctorSevice service)
        {
            this.service = service;
        }
        [HttpPost]
        public ActionResult<DoctorInfo> SignIn(SignInDoctorInfo info)
        {
            try
            {
                return Ok( service.SignIn(info));
            }catch(Exception e)
            {
                return BadRequest(e);
            }
        }

    }
}
