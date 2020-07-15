using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	/// A response containing all of the components for all requested vendors.
	[DataContract]
	public class InventoryChangedResponse{

		/// <summary>
		/// Items that appeared in the inventory possibly as a result of an action.
		/// </summary>
		[DataMember(Name="addedInventoryItems", EmitDefaultValue=false)]
		public List<DestinyItemComponent> AddedInventoryItems { get; set; }

		/// <summary>
		/// Items that disappeared from the inventory possibly as a result of an action.
		/// </summary>
		[DataMember(Name="removedInventoryItems", EmitDefaultValue=false)]
		public List<DestinyItemComponent> RemovedInventoryItems { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as InventoryChangedResponse);
        }

		public bool Equals(InventoryChangedResponse input)
		{
			if (input == null) return false;

			return
				(
                    AddedInventoryItems == input.AddedInventoryItems ||
                    (AddedInventoryItems != null && AddedInventoryItems.Equals(input.AddedInventoryItems))
                ) &&
				(
                    RemovedInventoryItems == input.RemovedInventoryItems ||
                    (RemovedInventoryItems != null && RemovedInventoryItems.Equals(input.RemovedInventoryItems))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.AddedInventoryItems.GetHashCode();
				hashCode = hashCode * 59 + this.RemovedInventoryItems.GetHashCode();
				return hashCode;
			}
		}*/
	}
}
