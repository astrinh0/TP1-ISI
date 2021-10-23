using Microsoft.AspNetCore.Mvc;
using RestfullAPI.Infrastructure.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using TP1.Domain.Models.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestfullAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {

        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        // GET: api/<teamController>/GetAllActive
        [HttpGet("/GetAllActiveTeams")]
        public Task<List<TeamDTO>> GetAllActive()
        {
            return _teamService.GetAllActive();
        }

        [HttpGet("/GetAllTeams")]
        public Task<List<TeamDTO>> GetAll()
        {
            return _teamService.GetAll();

        }

        // GET api/<teamController>/5
        [HttpGet("/GetTeamByIdOrName")]
        public async Task<TeamDTO> GetTeamByIdOrName(int? id, string? name)
        {
            var result = await _teamService.GetTeamDTO(id, name);

            return result;
        }

        // POST api/<teamController>/AddTeam
        [HttpPost("/AddTeam")]
        public Task<bool> AddTeam([FromBody] TeamDTO team)
        {
            return _teamService.AddTeam(team);
        }

        // PUT api/<teamController>/UpdateTeam
        [HttpPut("/UpdateTeam")]
        public Task<bool> Put([FromBody] TeamDTO team)
        {
            return _teamService.UpdateTeam(team);
        }

        // DELETE api/<teamController>/RemoveTeam
        [HttpDelete("/RemoveTeam")]
        public Task<bool> RemoveTeam(string? name, int? id)
        {
            return _teamService.RemoveTeam(id, name);
        }
    }
}
