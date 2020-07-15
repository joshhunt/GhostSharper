using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// Where the sausage gets made. Unlock Expressions are the foundation of the game&#39;s gating mechanics and investment-related restrictions. They can test Unlock Flags and Unlock Values for certain states, using a sufficient amount of logical operators such that unlock expressions are effectively Turing complete.
	/// Use UnlockExpressionParser to evaluate expressions using an IUnlockContext parsed from Babel.
	[DataContract]
	public class DestinyUnlockExpressionDefinition{

		/// <summary>
		/// A shortcut for determining the most restrictive gating that this expression performs. See the DestinyGatingScope enum's documentation for more details.
		/// </summary>
		[DataMember(Name="scope", EmitDefaultValue=false)]
		public DestinyGatingScope Scope { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyUnlockExpressionDefinition);
        }

		public bool Equals(DestinyUnlockExpressionDefinition input)
		{
			if (input == null) return false;

			return
				(
                    Scope == input.Scope ||
                    (Scope != null && Scope.Equals(input.Scope))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Scope.GetHashCode();
				return hashCode;
			}
		}*/
	}
}
