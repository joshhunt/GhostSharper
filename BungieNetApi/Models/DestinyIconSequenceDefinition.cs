using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyIconSequenceDefinition
    {
        [DataMember(Name = "frames", EmitDefaultValue = false)]
        public List<string> Frames { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyIconSequenceDefinition);
        }

        public bool Equals(DestinyIconSequenceDefinition input)
        {
            if (input == null) return false;

            return
                (
                    Frames == input.Frames ||
                    (Frames != null && Frames.SequenceEqual(input.Frames))
                ) ;
        }
    }
}

