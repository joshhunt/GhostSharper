using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum GroupsForMemberFilter
    {
        /// <summary>
        /// All = 0
        /// </summary>
        [EnumMember(Value = "0")]
        All = 0,

        /// <summary>
        /// Founded = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Founded = 1,

        /// <summary>
        /// NonFounded = 2
        /// </summary>
        [EnumMember(Value = "2")]
        NonFounded = 2,

    }
}