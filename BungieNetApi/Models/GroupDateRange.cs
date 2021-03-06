using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum GroupDateRange
    {
        /// <summary>
        /// All = 0
        /// </summary>
        [EnumMember(Value = "0")]
        All = 0,

        /// <summary>
        /// PastDay = 1
        /// </summary>
        [EnumMember(Value = "1")]
        PastDay = 1,

        /// <summary>
        /// PastWeek = 2
        /// </summary>
        [EnumMember(Value = "2")]
        PastWeek = 2,

        /// <summary>
        /// PastMonth = 3
        /// </summary>
        [EnumMember(Value = "3")]
        PastMonth = 3,

        /// <summary>
        /// PastYear = 4
        /// </summary>
        [EnumMember(Value = "4")]
        PastYear = 4,

    }
}