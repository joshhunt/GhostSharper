using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class IgnoreResponse{

		[DataMember(Name="isIgnored", EmitDefaultValue=false)]
		public bool IsIgnored { get; set; }

		[DataMember(Name="ignoreFlags", EmitDefaultValue=false)]
		public IgnoreStatus IgnoreFlags { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as IgnoreResponse);
        }

		public bool Equals(IgnoreResponse input)
		{
			if (input == null) return false;

			return
				(
                    IsIgnored == input.IsIgnored ||
                    (IsIgnored != null && IsIgnored.Equals(input.IsIgnored))
                ) &&
				(
                    IgnoreFlags == input.IgnoreFlags ||
                    (IgnoreFlags != null && IgnoreFlags.Equals(input.IgnoreFlags))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.IsIgnored.GetHashCode();
				hashCode = hashCode * 59 + this.IgnoreFlags.GetHashCode();
				return hashCode;
			}
		}*/
	}
}
