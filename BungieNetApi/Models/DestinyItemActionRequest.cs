using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyItemActionRequest
    {
        [DataMember(Name = "itemId", EmitDefaultValue = false)]
        public long ItemId { get; set; }

        [DataMember(Name = "characterId", EmitDefaultValue = false)]
        public long CharacterId { get; set; }

        [DataMember(Name = "membershipType", EmitDefaultValue = false)]
        public BungieMembershipType MembershipType { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemActionRequest);
        }

        public bool Equals(DestinyItemActionRequest input)
        {
            if (input == null) return false;

            return
                (
                    ItemId == input.ItemId ||
                    (ItemId.Equals(input.ItemId))
                ) &&
                (
                    CharacterId == input.CharacterId ||
                    (CharacterId.Equals(input.CharacterId))
                ) &&
                (
                    MembershipType == input.MembershipType ||
                    (MembershipType != null && MembershipType.Equals(input.MembershipType))
                ) ;
        }
    }
}

