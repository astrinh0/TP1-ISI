using RestfullAPI.Consts;
using System;
using System.Collections.Generic;

namespace RestfullAPI.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SnsNumber { get; set; }
        public string Email { get; set; }
        public EnumCovid Covid { get; set; }
        public EnumActive Active { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ChangeDate { get; set; }


        //DB where is FK

        public virtual ICollection<PersonContact> PersonContacts { get; set; }
        public virtual ICollection<Visit> Visits { get; set; }
        public virtual ICollection<PersonCovid> PersonCovids { get; set; }

    }
}
