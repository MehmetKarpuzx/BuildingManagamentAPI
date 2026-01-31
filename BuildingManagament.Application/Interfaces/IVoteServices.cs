using BuildingManagament.DTO.VoteDTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagament.Application.Interfaces
{
    public interface IVoteServices
    {
        Task<IEnumerable<ResponseVoteDTO>> GetAllVotesAsync();
        Task<AddVoteDTO> AddVoteAsync(AddVoteDTO voteDto);
        Task<UpdateVoteDTO> UpdateVoteAsync(int id, UpdateVoteDTO voteDto);
    }
}
