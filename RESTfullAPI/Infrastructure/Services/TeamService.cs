using AutoMapper;
using RestfullAPI.Infrastructure.Repositories;
using RestfullAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using TP1.Domain.Models.DTO;

namespace RestfullAPI.Infrastructure.Services
{
    public class TeamService : ITeamService
    {
        private readonly ITeamRepository _teamRepository;
        private readonly IMapper _mapper;

        public TeamService(ITeamRepository teamRepository, IMapper mapper)
        {
            _teamRepository = teamRepository;
            _mapper = mapper;
        }

        public async Task<bool> AddTeam(TeamDTO input)
        {
            var aux = _mapper.Map<Team>(input);

            return await _teamRepository.AddTeam(aux);
        }

        public async Task<List<TeamDTO>> GetAll()
        {
            var teams = await _teamRepository.GetAll();
            
            return _mapper.Map<List<TeamDTO>>(teams);
        }

        public async Task<List<TeamDTO>> GetAllActive()
        {
            var teams = await _teamRepository.GetAllActive();
            return _mapper.Map<List<TeamDTO>>(teams);
        }

        public async Task<TeamDTO> GetTeamDTO(int? id, string name)
        {
            return _mapper.Map<TeamDTO>(await _teamRepository.GetTeam(id, name));
        }

        public async Task<bool> RemoveTeam(int? id, string name)
        {
            return await _teamRepository.RemoveTeam(id, name);
        }

        public async Task<bool> UpdateTeam(TeamDTO input)
        {
            var aux = _mapper.Map<Team>(input);

            return await _teamRepository.UpdateTeam(aux);
        }
    }
}
