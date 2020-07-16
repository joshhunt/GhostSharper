using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// Indicates the status of an "Unlock Flag" on a Character or Profile.
    /// </summary>
    /// <summary>
    /// These are individual bits of state that can be either set or not set, and sometimes provide interesting human-readable information in their related DestinyUnlockDefinition.
    /// </summary>
    [DataContract]
    public class DestinyUnlockStatus
    {
        /// <summary>
        /// The hash identifier for the Unlock Flag. Use to lookup DestinyUnlockDefinition for static data. Not all unlocks have human readable data - in fact, most don't. But when they do, it can be very useful to show. Even if they don't have human readable data, you might be able to infer the meaning of an unlock flag with a bit of experimentation...
        /// </summary>
        [DataMember(Name = "unlockHash", EmitDefaultValue = false)]
        public uint UnlockHash { get; set; }

        /// <summary>
        /// Whether the unlock flag is set.
        /// </summary>
        [DataMember(Name = "isSet", EmitDefaultValue = false)]
        public bool IsSet { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyUnlockStatus);
        }

        public bool Equals(DestinyUnlockStatus input)
        {
            if (input == null) return false;

            return
                (
                    UnlockHash == input.UnlockHash ||
                    (UnlockHash != null && UnlockHash.Equals(input.UnlockHash))
                ) &&
                (
                    IsSet == input.IsSet ||
                    (IsSet != null && IsSet.Equals(input.IsSet))
                ) ;
        }
    }
}

