using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyCollectibleAcquisitionBlock
    {
        [DataMember(Name = "acquireMaterialRequirementHash", EmitDefaultValue = false)]
        public uint AcquireMaterialRequirementHash { get; set; }

        [DataMember(Name = "acquireTimestampUnlockValueHash", EmitDefaultValue = false)]
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
                    (AcquireMaterialRequirementHash.Equals(input.AcquireMaterialRequirementHash))
                ) &&
                (
                    AcquireTimestampUnlockValueHash == input.AcquireTimestampUnlockValueHash ||
                    (AcquireTimestampUnlockValueHash.Equals(input.AcquireTimestampUnlockValueHash))
                ) ;
        }
    }
}

