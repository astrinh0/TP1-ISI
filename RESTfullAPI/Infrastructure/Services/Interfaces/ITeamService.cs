using System.Collections.Generic;
using System.Threading.Tasks;
using TP1.Domain.Models.DTO;

namespace RestfullAPI.Infrastructure.Services
{
    public interface ITeamService
    {
        Task<List<TeamDTO>> GetAllActive();
        Task<List<TeamDTO>> GetAll();
        Task<bool> AddTeam(TeamDTO input);
        Task<bool> UpdateTeam(TeamDTO input);
        Task<bool> RemoveTeam(int? id, string? name);
        Task<TeamDTO> GetTeamDTO(int? id, string? name);
    }
}
