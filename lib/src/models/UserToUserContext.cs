using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class UserToUserContext{

		[DataMember(Name="isFollowing", EmitDefaultValue=false)]
		public bool IsFollowing { get; set; }

		[DataMember(Name="ignoreStatus", EmitDefaultValue=false)]
		public IgnoreResponse IgnoreStatus { get; set; }

		[DataMember(Name="globalIgnoreEndDate", EmitDefaultValue=false)]
		public string GlobalIgnoreEndDate { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as UserToUserContext);
        }

		public bool Equals(UserToUserContext input)
		{
			if (input == null) return false;

			return
				(
                    IsFollowing == input.IsFollowing ||
                    (IsFollowing != null && IsFollowing.Equals(input.IsFollowing))
                ) &&
				(
                    IgnoreStatus == input.IgnoreStatus ||
                    (IgnoreStatus != null && IgnoreStatus.Equals(input.IgnoreStatus))
                ) &&
				(
                    GlobalIgnoreEndDate == input.GlobalIgnoreEndDate ||
                    (GlobalIgnoreEndDate != null && GlobalIgnoreEndDate.Equals(input.GlobalIgnoreEndDate))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.IsFollowing.GetHashCode();
				hashCode = hashCode * 59 + this.IgnoreStatus.GetHashCode();
				hashCode = hashCode * 59 + this.GlobalIgnoreEndDate.GetHashCode();
				return hashCode;
			}
		}*/
	}
}
