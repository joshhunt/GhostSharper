using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// The same as GroupV2ClanInfo, but includes any investment data.
	[DataContract]
	public class GroupV2ClanInfoAndInvestment{

		[DataMember(Name="d2ClanProgressions", EmitDefaultValue=false)]
		public Map<String, DestinyProgression> D2ClanProgressions { get; set; }

		[DataMember(Name="clanCallsign", EmitDefaultValue=false)]
		public string ClanCallsign { get; set; }

		[DataMember(Name="clanBannerData", EmitDefaultValue=false)]
		public ClanBanner ClanBannerData { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as GroupV2ClanInfoAndInvestment);
        }

		public bool Equals(GroupV2ClanInfoAndInvestment input)
		{
			if (input == null) return false;

			return
				(
                    D2ClanProgressions == input.D2ClanProgressions ||
                    (D2ClanProgressions != null && D2ClanProgressions.Equals(input.D2ClanProgressions))
                ) &&
				(
                    ClanCallsign == input.ClanCallsign ||
                    (ClanCallsign != null && ClanCallsign.Equals(input.ClanCallsign))
                ) &&
				(
                    ClanBannerData == input.ClanBannerData ||
                    (ClanBannerData != null && ClanBannerData.Equals(input.ClanBannerData))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.D2ClanProgressions.GetHashCode();
				hashCode = hashCode * 59 + this.ClanCallsign.GetHashCode();
				hashCode = hashCode * 59 + this.ClanBannerData.GetHashCode();
				return hashCode;
			}
		}*/
	}
}
