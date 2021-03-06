using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// This is some bare minimum information about a party member in a Fireteam. Unfortunately, without great computational expense on our side we can only get at the data contained here. I'd like to give you a character ID for example, but we don't have it. But we do have these three pieces of information. May they help you on your quest to show meaningful data about current Fireteams.
    /// </summary>
    /// <summary>
    /// Notably, we don't and can't feasibly return info on characters. If you can, try to use just the data below for your UI and purposes. Only hit us with further queries if you absolutely must know the character ID of the currently playing character. Pretty please with sugar on top.
    /// </summary>
    [DataContract]
    public class DestinyProfileTransitoryPartyMember
    {
        /// <summary>
        /// The Membership ID that matches the party member.
        /// </summary>
        [DataMember(Name = "membershipId", EmitDefaultValue = false)]
        public long MembershipId { get; set; }

        /// <summary>
        /// The identifier for the DestinyInventoryItemDefinition of the player's emblem.
        /// </summary>
        [DataMember(Name = "emblemHash", EmitDefaultValue = false)]
        public uint EmblemHash { get; set; }

        /// <summary>
        /// The player's last known display name.
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// A Flags Enumeration value indicating the states that the player is in relevant to being on a fireteam.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public DestinyPartyMemberStates Status { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyProfileTransitoryPartyMember);
        }

        public bool Equals(DestinyProfileTransitoryPartyMember input)
        {
            if (input == null) return false;

            return
                (
                    MembershipId == input.MembershipId ||
                    (MembershipId.Equals(input.MembershipId))
                ) &&
                (
                    EmblemHash == input.EmblemHash ||
                    (EmblemHash.Equals(input.EmblemHash))
                ) &&
                (
                    DisplayName == input.DisplayName ||
                    (DisplayName != null && DisplayName.Equals(input.DisplayName))
                ) &&
                (
                    Status == input.Status ||
                    (Status != null && Status.Equals(input.Status))
                ) ;
        }
    }
}

