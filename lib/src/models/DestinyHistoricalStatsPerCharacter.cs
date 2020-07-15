using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyHistoricalStatsPerCharacter{

		[DataMember(Name="characterId", EmitDefaultValue=false)]
		public long CharacterId { get; set; }

		[DataMember(Name="deleted", EmitDefaultValue=false)]
		public bool Deleted { get; set; }

		[DataMember(Name="results", EmitDefaultValue=false)]
		public Map<String, DestinyHistoricalStatsByPeriod> Results { get; set; }

		[DataMember(Name="merged", EmitDefaultValue=false)]
		public DestinyHistoricalStatsByPeriod Merged { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyHistoricalStatsPerCharacter);
        }

		public bool Equals(DestinyHistoricalStatsPerCharacter input)
		{
			if (input == null) return false;

			return
				(
                    CharacterId == input.CharacterId ||
                    (CharacterId != null && CharacterId.Equals(input.CharacterId))
                ) &&
				(
                    Deleted == input.Deleted ||
                    (Deleted != null && Deleted.Equals(input.Deleted))
                ) &&
				(
                    Results == input.Results ||
                    (Results != null && Results.Equals(input.Results))
                ) &&
				(
                    Merged == input.Merged ||
                    (Merged != null && Merged.Equals(input.Merged))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.CharacterId.GetHashCode();
				hashCode = hashCode * 59 + this.Deleted.GetHashCode();
				hashCode = hashCode * 59 + this.Results.GetHashCode();
				hashCode = hashCode * 59 + this.Merged.GetHashCode();
				return hashCode;
			}
		}*/
	}
}
