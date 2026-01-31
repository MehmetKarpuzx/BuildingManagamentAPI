using BuildingManagament.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagament.DTO.VoteDTOs
{
    public class ResponseVoteDTO
    {
        public int Id { get; set; }
        public int DecisionId { get; set; }
        public int UserId { get; set; }
        public VoteType VoteType { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
