using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyCollectibleAcquisitionBlock{

		[DataMember(Name="acquireMaterialRequirementHash", EmitDefaultValue=false)]
		public uint AcquireMaterialRequirementHash { get; set; }

		[DataMember(Name="acquireTimestampUnlockValueHash", EmitDefaultValue=false)]
		public uint AcquireTimestampUnlockValueHash { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyCollectibleAcquisitionBlock);
        }

		public bool Equals(DestinyCollectibleAcquisitionBlock input)
		{
			if (input == null) return false;

			return
				(
                    AcquireMaterialRequirementHash == input.AcquireMaterialRequirementHash ||
                    (AcquireMaterialRequirementHash != null && AcquireMaterialRequirementHash.Equals(input.AcquireMaterialRequirementHash))
                ) &&
				(
                    AcquireTimestampUnlockValueHash == input.AcquireTimestampUnlockValueHash ||
                    (AcquireTimestampUnlockValueHash != null && AcquireTimestampUnlockValueHash.Equals(input.AcquireTimestampUnlockValueHash))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.AcquireMaterialRequirementHash.GetHashCode();
				hashCode = hashCode * 59 + this.AcquireTimestampUnlockValueHash.GetHashCode();
				return hashCode;
			}
		}*/
	}
}
