using BuildingManagament.Application.Interfaces;
using BuildingManagament.DTO.VoteDTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BuildingManagament.RESTFullApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [AllowAnonymous]
    public class VoteController : Controller
    {
        private readonly IVoteServices _voteServices;

        public VoteController(IVoteServices voteServices)
        {
            _voteServices = voteServices;
        }

        [HttpGet("GetAllVotes")]
        public async Task<IActionResult> GetAll()
        {
            var list = await _voteServices.GetAllVotesAsync();
            return Ok(list);
        }

        [HttpPost("AddVote")]
        public async Task<IActionResult> AddVote([FromBody] AddVoteDTO voteDto)
        {
            var result = await _voteServices.AddVoteAsync(voteDto);
            return Ok(result);
        }

        [HttpPut("UpdateVote/{id}")]
        public async Task<IActionResult> UpdateVote(int id, [FromBody] UpdateVoteDTO voteDto)
        {
            var result = await _voteServices.UpdateVoteAsync(id, voteDto);
            return Ok(result);
        }
    }
}
