using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// Display categories can have custom sort orders. These are the possible options.
    /// </summary>
    
    public enum VendorDisplayCategorySortOrder
    {
        /// <summary>
        /// Default = 0
        /// </summary>
        [EnumMember(Value = "0")]
        Default = 0,

        /// <summary>
        /// SortByTier = 1
        /// </summary>
        [EnumMember(Value = "1")]
        SortByTier = 1,

    }
}