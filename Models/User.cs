using RestfullAPI.Consts;

namespace RestfullAPI.Models
{
    public class User
    {
        public int Id {  get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public EnumActive Active { get; set; }
    }
}
