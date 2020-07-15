using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyRecordComponent{

		[DataMember(Name="state", EmitDefaultValue=false)]
		public DestinyRecordState State { get; set; }

		[DataMember(Name="objectives", EmitDefaultValue=false)]
		public List<DestinyObjectiveProgress> Objectives { get; set; }

		[DataMember(Name="intervalObjectives", EmitDefaultValue=false)]
		public List<DestinyObjectiveProgress> IntervalObjectives { get; set; }

		[DataMember(Name="intervalsRedeemedCount", EmitDefaultValue=false)]
		public long IntervalsRedeemedCount { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyRecordComponent);
        }

		public bool Equals(DestinyRecordComponent input)
		{
			if (input == null) return false;

			return
				(
                    State == input.State ||
                    (State != null && State.Equals(input.State))
                ) &&
				(
                    Objectives == input.Objectives ||
                    (Objectives != null && Objectives.Equals(input.Objectives))
                ) &&
				(
                    IntervalObjectives == input.IntervalObjectives ||
                    (IntervalObjectives != null && IntervalObjectives.Equals(input.IntervalObjectives))
                ) &&
				(
                    IntervalsRedeemedCount == input.IntervalsRedeemedCount ||
                    (IntervalsRedeemedCount != null && IntervalsRedeemedCount.Equals(input.IntervalsRedeemedCount))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.State.GetHashCode();
				hashCode = hashCode * 59 + this.Objectives.GetHashCode();
				hashCode = hashCode * 59 + this.IntervalObjectives.GetHashCode();
				hashCode = hashCode * 59 + this.IntervalsRedeemedCount.GetHashCode();
				return hashCode;
			}
		}*/
	}
}
