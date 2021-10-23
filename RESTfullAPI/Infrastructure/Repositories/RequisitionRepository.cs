using RestfullAPI.Context;
using RestfullAPI.Models;
using System.Threading.Tasks;

namespace RestfullAPI.Infrastructure.Repositories
{
    public class RequisitionRepository : IRequisitionRepository
    {
        private readonly DataContext _context;

        public RequisitionRepository(DataContext context)
        {
            _context = context;
        }

        //public Task<bool> CreateRequisition(Requisition requisition)
        //{
           
        //}
    }
}
