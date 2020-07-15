using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyItemTransferRequest{

		[DataMember(Name="itemReferenceHash", EmitDefaultValue=false)]
		public uint ItemReferenceHash { get; set; }

		[DataMember(Name="stackSize", EmitDefaultValue=false)]
		public long StackSize { get; set; }

		[DataMember(Name="transferToVault", EmitDefaultValue=false)]
		public bool TransferToVault { get; set; }

		[DataMember(Name="itemId", EmitDefaultValue=false)]
		public long ItemId { get; set; }

		[DataMember(Name="characterId", EmitDefaultValue=false)]
		public long CharacterId { get; set; }

		[DataMember(Name="membershipType", EmitDefaultValue=false)]
		public BungieMembershipType MembershipType { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemTransferRequest);
        }

		public bool Equals(DestinyItemTransferRequest input)
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
                    TransferToVault == input.TransferToVault ||
                    (TransferToVault != null && TransferToVault.Equals(input.TransferToVault))
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
				hashCode = hashCode * 59 + this.TransferToVault.GetHashCode();
				hashCode = hashCode * 59 + this.ItemId.GetHashCode();
				hashCode = hashCode * 59 + this.CharacterId.GetHashCode();
				hashCode = hashCode * 59 + this.MembershipType.GetHashCode();
				return hashCode;
			}
		}*/
	}
}
