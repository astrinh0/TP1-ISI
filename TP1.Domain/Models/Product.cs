using RestfullAPI.Consts;
using System;
using System.Collections.Generic;

namespace RestfullAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }
        public EnumActive Active { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ChangeDate { get; set; }


        //Fk

        public virtual ICollection<RequisitionProduct> RequisitionProducts { get; set; }

    }
}
