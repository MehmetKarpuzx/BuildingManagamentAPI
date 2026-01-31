using BuildingManagament.Application.Interfaces;
using BuildingManagament.DTO.MeetingDTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BuildingManagament.RESTFullApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [AllowAnonymous]
    public class MeetingController : Controller
    {
        private readonly IMeetingServices _meetingServices;

        public MeetingController(IMeetingServices meetingServices)
        {
            _meetingServices = meetingServices;
        }

        [HttpGet("GetAllMeetings")]
        public async Task<IActionResult> GetAll()
        {
            var list = await _meetingServices.GetAllMeetingsAsync();
            return Ok(list);
        }

        [HttpPost("AddMeeting")]
        public async Task<IActionResult> AddMeeting([FromBody] AddMeetingDTO meetingDto)
        {
            var result = await _meetingServices.AddMeetingAsync(meetingDto);
            return Ok(result);
        }

        [HttpPut("UpdateMeeting/{id}")]
        public async Task<IActionResult> UpdateMeeting(int id, [FromBody] UpdateMeetingDTO meetingDto)
        {
            var result = await _meetingServices.UpdateMeetingAsync(id, meetingDto);
            return Ok(result);
        }
    }
}
