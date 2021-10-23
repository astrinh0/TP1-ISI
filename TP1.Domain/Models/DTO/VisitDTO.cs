using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Domain.Models.DTO
{
    public class VisitDTO
    {
        public int PersonId { get; set; }
        public int Transgressions { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
