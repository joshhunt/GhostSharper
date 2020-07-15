using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// These properties are an attempt to categorize talent node steps by certain common properties. See the related enumerations for the type of properties being categorized.
	[DataContract]
	public class DestinyTalentNodeStepGroups{

		[DataMember(Name="weaponPerformance", EmitDefaultValue=false)]
		public DestinyTalentNodeStepWeaponPerformances WeaponPerformance { get; set; }

		[DataMember(Name="impactEffects", EmitDefaultValue=false)]
		public DestinyTalentNodeStepImpactEffects ImpactEffects { get; set; }

		[DataMember(Name="guardianAttributes", EmitDefaultValue=false)]
		public DestinyTalentNodeStepGuardianAttributes GuardianAttributes { get; set; }

		[DataMember(Name="lightAbilities", EmitDefaultValue=false)]
		public DestinyTalentNodeStepLightAbilities LightAbilities { get; set; }

		[DataMember(Name="damageTypes", EmitDefaultValue=false)]
		public DestinyTalentNodeStepDamageTypes DamageTypes { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyTalentNodeStepGroups);
        }

		public bool Equals(DestinyTalentNodeStepGroups input)
		{
			if (input == null) return false;

			return
				(
                    WeaponPerformance == input.WeaponPerformance ||
                    (WeaponPerformance != null && WeaponPerformance.Equals(input.WeaponPerformance))
                ) &&
				(
                    ImpactEffects == input.ImpactEffects ||
                    (ImpactEffects != null && ImpactEffects.Equals(input.ImpactEffects))
                ) &&
				(
                    GuardianAttributes == input.GuardianAttributes ||
                    (GuardianAttributes != null && GuardianAttributes.Equals(input.GuardianAttributes))
                ) &&
				(
                    LightAbilities == input.LightAbilities ||
                    (LightAbilities != null && LightAbilities.Equals(input.LightAbilities))
                ) &&
				(
                    DamageTypes == input.DamageTypes ||
                    (DamageTypes != null && DamageTypes.Equals(input.DamageTypes))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.WeaponPerformance.GetHashCode();
				hashCode = hashCode * 59 + this.ImpactEffects.GetHashCode();
				hashCode = hashCode * 59 + this.GuardianAttributes.GetHashCode();
				hashCode = hashCode * 59 + this.LightAbilities.GetHashCode();
				hashCode = hashCode * 59 + this.DamageTypes.GetHashCode();
				return hashCode;
			}
		}*/
	}
}
