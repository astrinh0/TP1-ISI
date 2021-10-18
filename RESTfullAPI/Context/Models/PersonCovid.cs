using System;

namespace RestfullAPI.Models
{
    public class PersonCovid
    {
        public int Id {  get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
