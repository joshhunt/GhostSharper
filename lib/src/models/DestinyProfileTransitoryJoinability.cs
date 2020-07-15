using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// Some basic information about whether you can be joined, how many slots are left etc. Note that this can change quickly, so it may not actually be useful. But perhaps it will be in some use cases?
	[DataContract]
	public class DestinyProfileTransitoryJoinability{

		/// <summary>
		/// The number of slots still available on this person's fireteam.
		/// </summary>
		[DataMember(Name="openSlots", EmitDefaultValue=false)]
		public long OpenSlots { get; set; }

		/// <summary>
		/// Who the person is currently allowing invites from.
		/// </summary>
		[DataMember(Name="privacySetting", EmitDefaultValue=false)]
		public DestinyGamePrivacySetting PrivacySetting { get; set; }

		/// <summary>
		/// Reasons why a person can't join this person's fireteam.
		/// </summary>
		[DataMember(Name="closedReasons", EmitDefaultValue=false)]
		public DestinyJoinClosedReasons ClosedReasons { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyProfileTransitoryJoinability);
        }

		public bool Equals(DestinyProfileTransitoryJoinability input)
		{
			if (input == null) return false;

			return
				(
                    OpenSlots == input.OpenSlots ||
                    (OpenSlots != null && OpenSlots.Equals(input.OpenSlots))
                ) &&
				(
                    PrivacySetting == input.PrivacySetting ||
                    (PrivacySetting != null && PrivacySetting.Equals(input.PrivacySetting))
                ) &&
				(
                    ClosedReasons == input.ClosedReasons ||
                    (ClosedReasons != null && ClosedReasons.Equals(input.ClosedReasons))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.OpenSlots.GetHashCode();
				hashCode = hashCode * 59 + this.PrivacySetting.GetHashCode();
				hashCode = hashCode * 59 + this.ClosedReasons.GetHashCode();
				return hashCode;
			}
		}*/
	}
}
