using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// In addition to item quantity information for vendor prices, this also has any optional information that may exist about how the item&#39;s quantity can be modified. (unfortunately not information that is able to be read outside of the BNet servers, but it&#39;s there)
	[DataContract]
	public class DestinyVendorItemQuantity{

		/// <summary>
		/// The hash identifier for the item in question. Use it to look up the item's DestinyInventoryItemDefinition.
		/// </summary>
		[DataMember(Name="itemHash", EmitDefaultValue=false)]
		public uint ItemHash { get; set; }

		/// <summary>
		/// If this quantity is referring to a specific instance of an item, this will have the item's instance ID. Normally, this will be null.
		/// </summary>
		[DataMember(Name="itemInstanceId", EmitDefaultValue=false)]
		public long ItemInstanceId { get; set; }

		/// <summary>
		/// The amount of the item needed/available depending on the context of where DestinyItemQuantity is being used.
		/// </summary>
		[DataMember(Name="quantity", EmitDefaultValue=false)]
		public long Quantity { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyVendorItemQuantity);
        }

		public bool Equals(DestinyVendorItemQuantity input)
		{
			if (input == null) return false;

			return
				(
                    ItemHash == input.ItemHash ||
                    (ItemHash != null && ItemHash.Equals(input.ItemHash))
                ) &&
				(
                    ItemInstanceId == input.ItemInstanceId ||
                    (ItemInstanceId != null && ItemInstanceId.Equals(input.ItemInstanceId))
                ) &&
				(
                    Quantity == input.Quantity ||
                    (Quantity != null && Quantity.Equals(input.Quantity))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.ItemHash.GetHashCode();
				hashCode = hashCode * 59 + this.ItemInstanceId.GetHashCode();
				hashCode = hashCode * 59 + this.Quantity.GetHashCode();
				return hashCode;
			}
		}*/
	}
}
