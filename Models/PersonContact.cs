using System;

namespace RestfullAPI.Models
{
    public class PersonContact
    {
        public int Id {  get; set; }
        public int InfectedId { get; set; }
        public Person Infected { get; set; }
        public int ContactId { get; set; }
        public Person ContactPerson { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreateDate { get; set; }


    }
}
