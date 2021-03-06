using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum ForumMediaType
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// Image = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Image = 1,

        /// <summary>
        /// Video = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Video = 2,

        /// <summary>
        /// Youtube = 3
        /// </summary>
        [EnumMember(Value = "3")]
        Youtube = 3,

    }
}