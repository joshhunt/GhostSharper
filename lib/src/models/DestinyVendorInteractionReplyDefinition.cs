using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// When the interaction is replied to, Reward sites will fire and items potentially selected based on whether the given unlock expression is TRUE.
	/// You can potentially choose one from multiple replies when replying to an interaction: this is how you get either&#x2F;or rewards from vendors.
	[DataContract]
	public class DestinyVendorInteractionReplyDefinition{

		/// <summary>
		/// The rewards granted upon responding to the vendor.
		/// </summary>
		[DataMember(Name="itemRewardsSelection", EmitDefaultValue=false)]
		public DestinyVendorInteractionRewardSelection ItemRewardsSelection { get; set; }

		/// <summary>
		/// The localized text for the reply.
		/// </summary>
		[DataMember(Name="reply", EmitDefaultValue=false)]
		public string Reply { get; set; }

		/// <summary>
		/// An enum indicating the type of reply being made.
		/// </summary>
		[DataMember(Name="replyType", EmitDefaultValue=false)]
		public DestinyVendorReplyType ReplyType { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyVendorInteractionReplyDefinition);
        }

		public bool Equals(DestinyVendorInteractionReplyDefinition input)
		{
			if (input == null) return false;

			return
				(
                    ItemRewardsSelection == input.ItemRewardsSelection ||
                    (ItemRewardsSelection != null && ItemRewardsSelection.Equals(input.ItemRewardsSelection))
                ) &&
				(
                    Reply == input.Reply ||
                    (Reply != null && Reply.Equals(input.Reply))
                ) &&
				(
                    ReplyType == input.ReplyType ||
                    (ReplyType != null && ReplyType.Equals(input.ReplyType))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.ItemRewardsSelection.GetHashCode();
				hashCode = hashCode * 59 + this.Reply.GetHashCode();
				hashCode = hashCode * 59 + this.ReplyType.GetHashCode();
				return hashCode;
			}
		}*/
	}
}
