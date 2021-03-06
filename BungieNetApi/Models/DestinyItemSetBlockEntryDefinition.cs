using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// Defines a particular entry in an ItemSet (AKA a particular Quest Step in a Quest)
    /// </summary>
    [DataContract]
    public class DestinyItemSetBlockEntryDefinition
    {
        /// <summary>
        /// Used for tracking which step a user reached. These values will be populated in the user's internal state, which we expose externally as a more usable DestinyQuestStatus object. If this item has been obtained, this value will be set in trackingUnlockValueHash.
        /// </summary>
        [DataMember(Name = "trackingValue", EmitDefaultValue = false)]
        public long TrackingValue { get; set; }

        /// <summary>
        /// This is the hash identifier for a DestinyInventoryItemDefinition representing this quest step.
        /// </summary>
        [DataMember(Name = "itemHash", EmitDefaultValue = false)]
        public uint ItemHash { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemSetBlockEntryDefinition);
        }

        public bool Equals(DestinyItemSetBlockEntryDefinition input)
        {
            if (input == null) return false;

            return
                (
                    TrackingValue == input.TrackingValue ||
                    (TrackingValue.Equals(input.TrackingValue))
                ) &&
                (
                    ItemHash == input.ItemHash ||
                    (ItemHash.Equals(input.ItemHash))
                ) ;
        }
    }
}

