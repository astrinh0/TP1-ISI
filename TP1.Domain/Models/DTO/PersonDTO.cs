using RestfullAPI.Consts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Domain.Models.DTO
{
    public class PersonDTO
    {
        public string Name { get; set; }
        public string SnsNumber { get; set; }
        public string Email { get; set; }
        public EnumCovid Covid { get; set; }
        public EnumActive Active { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ChangeDate { get; set; }
    }
}
