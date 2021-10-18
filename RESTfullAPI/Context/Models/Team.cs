using RestfullAPI.Consts;
using System;
using System.Collections.Generic;

namespace RestfullAPI.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EnumActive Active {  get; set; }
        public DateTime CreateDate {  get; set; } 
        public DateTime? ChangeDate {  get; set; }




        //DB where is FK

        public virtual ICollection<Requisition> Requisitions {  get; set; }
    }
}
