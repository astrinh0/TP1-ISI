using RestfullAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestfullAPI.Infrastructure.Repositories
{
    public interface ITeamRepository
    {
        Task<List<Team>> GetAllActive();
        Task<List<Team>> GetAll();
        Task<bool> AddTeam(Team input);
        Task<bool> UpdateTeam(Team input);
        Task<bool> RemoveTeam(int? id, string? name);
        Task<Team> GetTeam(int? id, string? name);
    }
}
