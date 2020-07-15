using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class GroupMemberLeaveResult{

		[DataMember(Name="group", EmitDefaultValue=false)]
		public GroupV2 Group { get; set; }

		[DataMember(Name="groupDeleted", EmitDefaultValue=false)]
		public bool GroupDeleted { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as GroupMemberLeaveResult);
        }

		public bool Equals(GroupMemberLeaveResult input)
		{
			if (input == null) return false;

			return
				(
                    Group == input.Group ||
                    (Group != null && Group.Equals(input.Group))
                ) &&
				(
                    GroupDeleted == input.GroupDeleted ||
                    (GroupDeleted != null && GroupDeleted.Equals(input.GroupDeleted))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Group.GetHashCode();
				hashCode = hashCode * 59 + this.GroupDeleted.GetHashCode();
				return hashCode;
			}
		}*/
	}
}
