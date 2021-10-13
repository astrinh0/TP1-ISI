using RestfullAPI.Consts;
using System;

namespace RestfullAPI.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SnsNumber { get; set; }
        public string Email { get; set; }
        public EnumCovid Covid { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ChangeDate { get; set; }
    }
}
