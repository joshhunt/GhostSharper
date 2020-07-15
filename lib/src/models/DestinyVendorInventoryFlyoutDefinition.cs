using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	/// The definition for an &quot;inventory flyout&quot;: a UI screen where we show you part of an otherwise hidden vendor inventory: like the Vault inventory buckets.
	[DataContract]
	public class DestinyVendorInventoryFlyoutDefinition{

		/// <summary>
		/// If the flyout is locked, this is the reason why.
		/// </summary>
		[DataMember(Name="lockedDescription", EmitDefaultValue=false)]
		public string LockedDescription { get; set; }

		/// <summary>
		/// The title and other common properties of the flyout.
		/// </summary>
		[DataMember(Name="displayProperties", EmitDefaultValue=false)]
		public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

		/// <summary>
		/// A list of inventory buckets and other metadata to show on the screen.
		/// </summary>
		[DataMember(Name="buckets", EmitDefaultValue=false)]
		public List<DestinyVendorInventoryFlyoutBucketDefinition> Buckets { get; set; }

		/// <summary>
		/// An identifier for the flyout, in case anything else needs to refer to them.
		/// </summary>
		[DataMember(Name="flyoutId", EmitDefaultValue=false)]
		public uint FlyoutId { get; set; }

		/// <summary>
		/// If this is true, don't show any of the glistening "this is a new item" UI elements, like we show on the inventory items themselves in in-game UI.
		/// </summary>
		[DataMember(Name="suppressNewness", EmitDefaultValue=false)]
		public bool SuppressNewness { get; set; }

		/// <summary>
		/// If this flyout is meant to show you the contents of the player's equipment slot, this is the slot to show.
		/// </summary>
		[DataMember(Name="equipmentSlotHash", EmitDefaultValue=false)]
		public uint EquipmentSlotHash { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyVendorInventoryFlyoutDefinition);
        }

		public bool Equals(DestinyVendorInventoryFlyoutDefinition input)
		{
			if (input == null) return false;

			return
				(
                    LockedDescription == input.LockedDescription ||
                    (LockedDescription != null && LockedDescription.Equals(input.LockedDescription))
                ) &&
				(
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) &&
				(
                    Buckets == input.Buckets ||
                    (Buckets != null && Buckets.Equals(input.Buckets))
                ) &&
				(
                    FlyoutId == input.FlyoutId ||
                    (FlyoutId != null && FlyoutId.Equals(input.FlyoutId))
                ) &&
				(
                    SuppressNewness == input.SuppressNewness ||
                    (SuppressNewness != null && SuppressNewness.Equals(input.SuppressNewness))
                ) &&
				(
                    EquipmentSlotHash == input.EquipmentSlotHash ||
                    (EquipmentSlotHash != null && EquipmentSlotHash.Equals(input.EquipmentSlotHash))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.LockedDescription.GetHashCode();
				hashCode = hashCode * 59 + this.DisplayProperties.GetHashCode();
				hashCode = hashCode * 59 + this.Buckets.GetHashCode();
				hashCode = hashCode * 59 + this.FlyoutId.GetHashCode();
				hashCode = hashCode * 59 + this.SuppressNewness.GetHashCode();
				hashCode = hashCode * 59 + this.EquipmentSlotHash.GetHashCode();
				return hashCode;
			}
		}*/
	}
}
