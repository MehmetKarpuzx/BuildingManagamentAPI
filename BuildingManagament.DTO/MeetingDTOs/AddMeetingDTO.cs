using BuildingManagament.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagament.DTO.MeetingDTOs
{
    public class AddMeetingDTO
    {
        public int BuildingId { get; set; }
        public string Title { get; set; } = null!;
        public DateTime MeetingDateTime { get; set; }
        public string? Location { get; set; }
        public MeetingStatus MeetingStatus { get; set; }
        public int? CalledByUserId { get; set; }
        public string? Result { get; set; }
    }
}
