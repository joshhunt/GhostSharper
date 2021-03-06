using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyItemChangeResponse
    {
        /// <summary>
        /// The response object for retrieving an individual instanced item. None of these components are relevant for an item that doesn't have an "itemInstanceId": for those, get your information from the DestinyInventoryDefinition.
        /// </summary>
        [DataMember(Name = "item", EmitDefaultValue = false)]
        public DestinyItemResponse Item { get; set; }

        /// <summary>
        /// Items that appeared in the inventory possibly as a result of an action.
        /// </summary>
        [DataMember(Name = "addedInventoryItems", EmitDefaultValue = false)]
        public List<DestinyItemComponent> AddedInventoryItems { get; set; }

        /// <summary>
        /// Items that disappeared from the inventory possibly as a result of an action.
        /// </summary>
        [DataMember(Name = "removedInventoryItems", EmitDefaultValue = false)]
        public List<DestinyItemComponent> RemovedInventoryItems { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemChangeResponse);
        }

        public bool Equals(DestinyItemChangeResponse input)
        {
            if (input == null) return false;

            return
                (
                    Item == input.Item ||
                    (Item != null && Item.Equals(input.Item))
                ) &&
                (
                    AddedInventoryItems == input.AddedInventoryItems ||
                    (AddedInventoryItems != null && AddedInventoryItems.SequenceEqual(input.AddedInventoryItems))
                ) &&
                (
                    RemovedInventoryItems == input.RemovedInventoryItems ||
                    (RemovedInventoryItems != null && RemovedInventoryItems.SequenceEqual(input.RemovedInventoryItems))
                ) ;
        }
    }
}

