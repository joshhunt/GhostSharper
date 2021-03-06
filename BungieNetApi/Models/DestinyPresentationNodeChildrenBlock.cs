using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    /// <summary>
    /// As/if presentation nodes begin to host more entities as children, these lists will be added to. One list property exists per type of entity that can be treated as a child of this presentation node, and each holds the identifier of the entity and any associated information needed to display the UI for that entity (if anything)
    /// </summary>
    [DataContract]
    public class DestinyPresentationNodeChildrenBlock
    {
        [DataMember(Name = "presentationNodes", EmitDefaultValue = false)]
        public List<DestinyPresentationNodeChildEntry> PresentationNodes { get; set; }

        [DataMember(Name = "collectibles", EmitDefaultValue = false)]
        public List<DestinyPresentationNodeCollectibleChildEntry> Collectibles { get; set; }

        [DataMember(Name = "records", EmitDefaultValue = false)]
        public List<DestinyPresentationNodeRecordChildEntry> Records { get; set; }

        [DataMember(Name = "metrics", EmitDefaultValue = false)]
        public List<DestinyPresentationNodeMetricChildEntry> Metrics { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyPresentationNodeChildrenBlock);
        }

        public bool Equals(DestinyPresentationNodeChildrenBlock input)
        {
            if (input == null) return false;

            return
                (
                    PresentationNodes == input.PresentationNodes ||
                    (PresentationNodes != null && PresentationNodes.SequenceEqual(input.PresentationNodes))
                ) &&
                (
                    Collectibles == input.Collectibles ||
                    (Collectibles != null && Collectibles.SequenceEqual(input.Collectibles))
                ) &&
                (
                    Records == input.Records ||
                    (Records != null && Records.SequenceEqual(input.Records))
                ) &&
                (
                    Metrics == input.Metrics ||
                    (Metrics != null && Metrics.SequenceEqual(input.Metrics))
                ) ;
        }
    }
}

