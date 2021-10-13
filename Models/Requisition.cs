using RestfullAPI.Consts;
using System;

namespace RestfullAPI.Models
{
    public class Requisition
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public EnumStatus Status { get; set; }
        public DateTime CreateDate { get; set; }
        

    }
}
