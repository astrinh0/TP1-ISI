using RestfullAPI.Consts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Domain.Models.DTO
{
    public class RequisitionDTO
    {
        public int TeamId { get; set; }
        public EnumStatus Status { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
