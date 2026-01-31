using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagament.DTO.BuildingDTOs
{
    public class ResponseBuildingDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public DateTime CreatedDate { get; set; }


    }
}
