using BuildingManagament.DTO.MeetingDTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagament.Application.Interfaces
{
    public interface IMeetingServices
    {
        Task<AddMeetingDTO> AddMeetingAsync(AddMeetingDTO meetingDto);
        Task<IEnumerable<ResponseMeetingDTO>> GetAllMeetingsAsync();
        Task<UpdateMeetingDTO> UpdateMeetingAsync(int id, UpdateMeetingDTO meetingDto);
    }
}
