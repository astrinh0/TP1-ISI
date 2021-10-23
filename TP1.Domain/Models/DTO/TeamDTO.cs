using RestfullAPI.Consts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Domain.Models.DTO
{
    public class TeamDTO
    {
        public string Name { get; set; }
        public EnumActive Active { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ChangeDate { get; set; }
    }
}
