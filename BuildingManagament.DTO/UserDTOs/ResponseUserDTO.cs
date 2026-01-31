using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagament.DTO.UserDTOs
{
    public class ResponseUserDTO
    {
        public int Id { get; set; }
        public string TC { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public int RoleId { get; set; }
        public int BuildingId { get; set; }
        public int? UnitId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
