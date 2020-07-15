using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// The base class for any component-returning object that may need to indicate information about the state of the component being returned.
	[DataContract]
	public class ComponentResponse{

		[DataMember(Name="privacy", EmitDefaultValue=false)]
		public ComponentPrivacySetting Privacy { get; set; }

		/// <summary>
		/// If true, this component is disabled.
		/// </summary>
		[DataMember(Name="disabled", EmitDefaultValue=false)]
		public bool Disabled { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as ComponentResponse);
        }

		public bool Equals(ComponentResponse input)
		{
			if (input == null) return false;

			return
				(
                    Privacy == input.Privacy ||
                    (Privacy != null && Privacy.Equals(input.Privacy))
                ) &&
				(
                    Disabled == input.Disabled ||
                    (Disabled != null && Disabled.Equals(input.Disabled))
                ) ;
		}
	}
}

