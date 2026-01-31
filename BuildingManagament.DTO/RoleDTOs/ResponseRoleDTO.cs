using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagament.DTO.RoleDTOs
{
    public class ResponseRoleDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
    }
}
