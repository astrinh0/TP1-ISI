using System;

namespace RestfullAPI.Models
{
    public class Visit
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int Transgressions { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
