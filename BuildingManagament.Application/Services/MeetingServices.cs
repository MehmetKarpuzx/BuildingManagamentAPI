using BuildingManagament.Application.Interfaces;
using BuildingManagament.DTO.MeetingDTOs;
using BuildingManagament.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagament.Application.Services
{
   
   
    public class MeetingServices : IMeetingServices
    {
        private readonly BuildingManagamentDbContext _context;
        public MeetingServices(BuildingManagamentDbContext context)
        {
            _context = context;
        }

        public async Task<AddMeetingDTO> AddMeetingAsync(AddMeetingDTO meetingDto)
        {
            var meeting = new BuildingManagament.Domain.Entities.Meeting
            {
                BuildingId = meetingDto.BuildingId,
                Title = meetingDto.Title,
                MeetingDateTime = meetingDto.MeetingDateTime,
                Location = meetingDto.Location,
                CalledByUserId = meetingDto.CalledByUserId,
                Result = meetingDto.Result
                
                
            };
            await _context.Meetings.AddAsync(meeting);
            await _context.SaveChangesAsync();
            return meetingDto;
        }

        public Task<IEnumerable<ResponseMeetingDTO>> GetAllMeetingsAsync()
        {
            var list = _context.Meetings.Select(m => new ResponseMeetingDTO
            {
                Id = m.Id,
                BuildingId = m.BuildingId,
                Title = m.Title,
                MeetingDateTime = m.MeetingDateTime,
                Location = m.Location,
                CalledByUserId = m.CalledByUserId,
                Result = m.Result,
                CreatedDate = m.CreatedDate
            }).AsEnumerable();
            return Task.FromResult(list);

        }

        public  Task<UpdateMeetingDTO> UpdateMeetingAsync(int id, UpdateMeetingDTO meetingDto)
        {
            var meeting =  _context.Meetings.Find(id);
            if (meeting == null)
            {
                throw new KeyNotFoundException("404");
            }
            meeting.BuildingId = meetingDto.BuildingId;
            meeting.Title = meetingDto.Title;
            meeting.MeetingDateTime = meetingDto.MeetingDateTime;
            meeting.Location = meetingDto.Location;
            meeting.CalledByUserId = meetingDto.CalledByUserId;
            meeting.Result = meetingDto.Result;
             _context.Meetings.Update(meeting);
             _context.SaveChanges();
            return Task.FromResult(meetingDto);



        }
    }
}
