using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagament.DTO.UserDTOs
{
    public class UpdateUserDTO
    {
        public string TC { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public int RoleId { get; set; }
        public int BuildingId { get; set; }
        public int? UnitId { get; set; }
    }
}
