using System.Runtime.Serialization;

namespace RestfullAPI.Consts
{
    public enum EnumActive
    { 
        [EnumMember(Value = "0")]
        N = 0,
        [EnumMember(Value = "1")]
        Y = 1
    }
}
