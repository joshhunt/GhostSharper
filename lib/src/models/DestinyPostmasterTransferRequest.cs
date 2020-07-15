using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyPostmasterTransferRequest{

		[DataMember(Name="itemReferenceHash", EmitDefaultValue=false)]
		public uint ItemReferenceHash { get; set; }

		[DataMember(Name="stackSize", EmitDefaultValue=false)]
		public long StackSize { get; set; }

		[DataMember(Name="itemId", EmitDefaultValue=false)]
		public long ItemId { get; set; }

		[DataMember(Name="characterId", EmitDefaultValue=false)]
		public long CharacterId { get; set; }

		[DataMember(Name="membershipType", EmitDefaultValue=false)]
		public BungieMembershipType MembershipType { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyPostmasterTransferRequest);
        }

		public bool Equals(DestinyPostmasterTransferRequest input)
		{
			if (input == null) return false;

			return
				(
                    ItemReferenceHash == input.ItemReferenceHash ||
                    (ItemReferenceHash != null && ItemReferenceHash.Equals(input.ItemReferenceHash))
                ) &&
				(
                    StackSize == input.StackSize ||
                    (StackSize != null && StackSize.Equals(input.StackSize))
                ) &&
				(
                    ItemId == input.ItemId ||
                    (ItemId != null && ItemId.Equals(input.ItemId))
                ) &&
				(
                    CharacterId == input.CharacterId ||
                    (CharacterId != null && CharacterId.Equals(input.CharacterId))
                ) &&
				(
                    MembershipType == input.MembershipType ||
                    (MembershipType != null && MembershipType.Equals(input.MembershipType))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.ItemReferenceHash.GetHashCode();
				hashCode = hashCode * 59 + this.StackSize.GetHashCode();
				hashCode = hashCode * 59 + this.ItemId.GetHashCode();
				hashCode = hashCode * 59 + this.CharacterId.GetHashCode();
				hashCode = hashCode * 59 + this.MembershipType.GetHashCode();
				return hashCode;
			}
		}*/
	}
}
