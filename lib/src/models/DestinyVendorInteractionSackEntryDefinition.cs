using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// Compare this sackType to the sack identifier in the DestinyInventoryItemDefinition.vendorSackType property of items. If they match, show this sack with this interaction.
	[DataContract]
	public class DestinyVendorInteractionSackEntryDefinition{

		[DataMember(Name="sackType", EmitDefaultValue=false)]
		public uint SackType { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyVendorInteractionSackEntryDefinition);
        }

		public bool Equals(DestinyVendorInteractionSackEntryDefinition input)
		{
			if (input == null) return false;

			return
				(
                    SackType == input.SackType ||
                    (SackType != null && SackType.Equals(input.SackType))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.SackType.GetHashCode();
				return hashCode;
			}
		}*/
	}
}
