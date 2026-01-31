using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagament.DTO.ExpenseCategoryDTOs
{
    public class ResponseExpenseCategoryDTO
    {
        public int Id { get; set; }
        public int BuildingId { get; set; }
        public string Name { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
    }
}
