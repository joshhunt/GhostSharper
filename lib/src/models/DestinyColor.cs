using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// Represents a color whose RGBA values are all represented as values between 0 and 255.
	[DataContract]
	public class DestinyColor{

		[DataMember(Name="red", EmitDefaultValue=false)]
		public int Red { get; set; }

		[DataMember(Name="green", EmitDefaultValue=false)]
		public int Green { get; set; }

		[DataMember(Name="blue", EmitDefaultValue=false)]
		public int Blue { get; set; }

		[DataMember(Name="alpha", EmitDefaultValue=false)]
		public int Alpha { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyColor);
        }

		public bool Equals(DestinyColor input)
		{
			if (input == null) return false;

			return
				(
                    Red == input.Red ||
                    (Red != null && Red.Equals(input.Red))
                ) &&
				(
                    Green == input.Green ||
                    (Green != null && Green.Equals(input.Green))
                ) &&
				(
                    Blue == input.Blue ||
                    (Blue != null && Blue.Equals(input.Blue))
                ) &&
				(
                    Alpha == input.Alpha ||
                    (Alpha != null && Alpha.Equals(input.Alpha))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Red.GetHashCode();
				hashCode = hashCode * 59 + this.Green.GetHashCode();
				hashCode = hashCode * 59 + this.Blue.GetHashCode();
				hashCode = hashCode * 59 + this.Alpha.GetHashCode();
				return hashCode;
			}
		}*/
	}
}
