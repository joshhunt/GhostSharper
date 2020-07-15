using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// The definition of an item and quantity required in a character&#39;s inventory in order to perform an action.
	[DataContract]
	public class DestinyItemActionRequiredItemDefinition{

		/// <summary>
		/// The minimum quantity of the item you have to have.
		/// </summary>
		[DataMember(Name="count", EmitDefaultValue=false)]
		public long Count { get; set; }

		/// <summary>
		/// The hash identifier of the item you need to have. Use it to look up the DestinyInventoryItemDefinition for more info.
		/// </summary>
		[DataMember(Name="itemHash", EmitDefaultValue=false)]
		public uint ItemHash { get; set; }

		/// <summary>
		/// If true, the item/quantity will be deleted from your inventory when the action is performed. Otherwise, you'll retain these required items after the action is complete.
		/// </summary>
		[DataMember(Name="deleteOnAction", EmitDefaultValue=false)]
		public bool DeleteOnAction { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemActionRequiredItemDefinition);
        }

		public bool Equals(DestinyItemActionRequiredItemDefinition input)
		{
			if (input == null) return false;

			return
				(
                    Count == input.Count ||
                    (Count != null && Count.Equals(input.Count))
                ) &&
				(
                    ItemHash == input.ItemHash ||
                    (ItemHash != null && ItemHash.Equals(input.ItemHash))
                ) &&
				(
                    DeleteOnAction == input.DeleteOnAction ||
                    (DeleteOnAction != null && DeleteOnAction.Equals(input.DeleteOnAction))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Count.GetHashCode();
				hashCode = hashCode * 59 + this.ItemHash.GetHashCode();
				hashCode = hashCode * 59 + this.DeleteOnAction.GetHashCode();
				return hashCode;
			}
		}*/
	}
}
