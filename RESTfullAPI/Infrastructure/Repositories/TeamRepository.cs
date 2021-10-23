using Microsoft.EntityFrameworkCore;
using RestfullAPI.Context;
using RestfullAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestfullAPI.Infrastructure.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly DataContext _context;

        public TeamRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<bool> AddTeam(Team input)
        {
            if (await _context.Teams.FirstOrDefaultAsync(x => x.Name == input.Name) != null)
                return false;

            var result = _context.Teams.Add(input);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<List<Team>> GetAll()
        {
            return await _context.Teams.ToListAsync();
        }

        public async Task<List<Team>> GetAllActive()
        {
            return await _context.Teams.Where(x => x.Active == Consts.EnumActive.Y).ToListAsync();
        }

        public async Task<Team> GetTeam(int? id, string name)
        {
            return await _context.Teams.FirstOrDefaultAsync(x => x.Id == id || x.Name == name);
        }

        public async Task<bool> RemoveTeam(int? id, string name)
        {
            var team = await _context.Teams.FirstOrDefaultAsync(x => x.Id == id || x.Name == name);

            if (team != null)
            {
                team.Active = Consts.EnumActive.N;
                _context.Teams.Update(team);
                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }

        public async Task<bool> UpdateTeam(Team input)
        {

            var team = await _context.Teams.FirstOrDefaultAsync(x => x.Id == input.Id);

            if (team != null)
            {
                team.Name = input.Name;

                _context.Teams.Update(team);
                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}
