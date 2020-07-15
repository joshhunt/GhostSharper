using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	/// Primarily for Quests, this is the definition of properties related to the item if it is a quest and its various quest steps.
	[DataContract]
	public class DestinyItemSetBlockDefinition{

		/// <summary>
		/// A collection of hashes of set items, for items such as Quest Metadata items that possess this data.
		/// </summary>
		[DataMember(Name="itemList", EmitDefaultValue=false)]
		public List<DestinyItemSetBlockEntryDefinition> ItemList { get; set; }

		/// <summary>
		/// If true, items in the set can only be added in increasing order, and adding an item will remove any previous item. For Quests, this is by necessity true. Only one quest step is present at a time, and previous steps are removed as you advance in the quest.
		/// </summary>
		[DataMember(Name="requireOrderedSetItemAdd", EmitDefaultValue=false)]
		public bool RequireOrderedSetItemAdd { get; set; }

		/// <summary>
		/// If true, the UI should treat this quest as "featured"
		/// </summary>
		[DataMember(Name="setIsFeatured", EmitDefaultValue=false)]
		public bool SetIsFeatured { get; set; }

		/// <summary>
		/// A string identifier we can use to attempt to identify the category of the Quest.
		/// </summary>
		[DataMember(Name="setType", EmitDefaultValue=false)]
		public string SetType { get; set; }

		/// <summary>
		/// The name of the quest line that this quest step is a part of.
		/// </summary>
		[DataMember(Name="questLineName", EmitDefaultValue=false)]
		public string QuestLineName { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemSetBlockDefinition);
        }

		public bool Equals(DestinyItemSetBlockDefinition input)
		{
			if (input == null) return false;

			return
				(
                    ItemList == input.ItemList ||
                    (ItemList != null && ItemList.Equals(input.ItemList))
                ) &&
				(
                    RequireOrderedSetItemAdd == input.RequireOrderedSetItemAdd ||
                    (RequireOrderedSetItemAdd != null && RequireOrderedSetItemAdd.Equals(input.RequireOrderedSetItemAdd))
                ) &&
				(
                    SetIsFeatured == input.SetIsFeatured ||
                    (SetIsFeatured != null && SetIsFeatured.Equals(input.SetIsFeatured))
                ) &&
				(
                    SetType == input.SetType ||
                    (SetType != null && SetType.Equals(input.SetType))
                ) &&
				(
                    QuestLineName == input.QuestLineName ||
                    (QuestLineName != null && QuestLineName.Equals(input.QuestLineName))
                ) ;
		}
	}
}

