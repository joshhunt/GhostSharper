using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// If a vendor can ever end up performing actions, these are the properties that will be related to those actions. I&#39;m not going to bother documenting this yet, as it is unused and unclear if it will ever be used... but in case it is ever populated and someone finds it useful, it is defined here.
	[DataContract]
	public class DestinyVendorActionDefinition{

		[DataMember(Name="description", EmitDefaultValue=false)]
		public string Description { get; set; }

		[DataMember(Name="executeSeconds", EmitDefaultValue=false)]
		public long ExecuteSeconds { get; set; }

		[DataMember(Name="icon", EmitDefaultValue=false)]
		public string Icon { get; set; }

		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }

		[DataMember(Name="verb", EmitDefaultValue=false)]
		public string Verb { get; set; }

		[DataMember(Name="isPositive", EmitDefaultValue=false)]
		public bool IsPositive { get; set; }

		[DataMember(Name="actionId", EmitDefaultValue=false)]
		public string ActionId { get; set; }

		[DataMember(Name="actionHash", EmitDefaultValue=false)]
		public uint ActionHash { get; set; }

		[DataMember(Name="autoPerformAction", EmitDefaultValue=false)]
		public bool AutoPerformAction { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyVendorActionDefinition);
        }

		public bool Equals(DestinyVendorActionDefinition input)
		{
			if (input == null) return false;

			return
				(
                    Description == input.Description ||
                    (Description != null && Description.Equals(input.Description))
                ) &&
				(
                    ExecuteSeconds == input.ExecuteSeconds ||
                    (ExecuteSeconds != null && ExecuteSeconds.Equals(input.ExecuteSeconds))
                ) &&
				(
                    Icon == input.Icon ||
                    (Icon != null && Icon.Equals(input.Icon))
                ) &&
				(
                    Name == input.Name ||
                    (Name != null && Name.Equals(input.Name))
                ) &&
				(
                    Verb == input.Verb ||
                    (Verb != null && Verb.Equals(input.Verb))
                ) &&
				(
                    IsPositive == input.IsPositive ||
                    (IsPositive != null && IsPositive.Equals(input.IsPositive))
                ) &&
				(
                    ActionId == input.ActionId ||
                    (ActionId != null && ActionId.Equals(input.ActionId))
                ) &&
				(
                    ActionHash == input.ActionHash ||
                    (ActionHash != null && ActionHash.Equals(input.ActionHash))
                ) &&
				(
                    AutoPerformAction == input.AutoPerformAction ||
                    (AutoPerformAction != null && AutoPerformAction.Equals(input.AutoPerformAction))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Description.GetHashCode();
				hashCode = hashCode * 59 + this.ExecuteSeconds.GetHashCode();
				hashCode = hashCode * 59 + this.Icon.GetHashCode();
				hashCode = hashCode * 59 + this.Name.GetHashCode();
				hashCode = hashCode * 59 + this.Verb.GetHashCode();
				hashCode = hashCode * 59 + this.IsPositive.GetHashCode();
				hashCode = hashCode * 59 + this.ActionId.GetHashCode();
				hashCode = hashCode * 59 + this.ActionHash.GetHashCode();
				hashCode = hashCode * 59 + this.AutoPerformAction.GetHashCode();
				return hashCode;
			}
		}*/
	}
}
