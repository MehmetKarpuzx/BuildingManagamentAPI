using BuildingManagament.Application.Interfaces;
using BuildingManagament.DTO.VoteDTOs;
using BuildingManagament.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagament.Application.Services
{
    public class VoteServices : IVoteServices
    {
        private readonly BuildingManagamentDbContext _context;
        public VoteServices(BuildingManagamentDbContext context)
        {
            _context = context;
        }
        public async Task<AddVoteDTO> AddVoteAsync(AddVoteDTO voteDto)
        {
            var vote = new BuildingManagament.Domain.Entities.Vote
            {
                DecisionId = voteDto.DecisionId,
                UserId = voteDto.UserId,
             
            };
            await _context.Votes.AddAsync(vote);
            await _context.SaveChangesAsync();
            return  voteDto;

        }

        public async Task<IEnumerable<ResponseVoteDTO>> GetAllVotesAsync()
        {
            var list = _context.Votes.Select(v => new ResponseVoteDTO
            {
                Id = v.Id,
                DecisionId = v.DecisionId,
                UserId = v.UserId,
                CreatedDate = v.CreatedDate
            }).AsEnumerable();  
            return  await Task.FromResult(list);
        }

        public Task<UpdateVoteDTO> UpdateVoteAsync(int id, UpdateVoteDTO voteDto)
        {
           var vote = _context.Votes.Find(id);
            if (vote == null)
            {
                throw new Exception("404");
            }
            vote.DecisionId = voteDto.DecisionId;
            vote.UserId = voteDto.UserId;
            _context.Votes.Update(vote);
            _context.SaveChanges();
            return Task.FromResult(voteDto);
        }
    }
}
