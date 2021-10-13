using System.Runtime.Serialization;

namespace RestfullAPI.Consts
{
    public enum EnumStatus
    {
        [EnumMember(Value = "0")]
        P = 0,
        [EnumMember(Value = "1")]
        S = 1
    }
}
