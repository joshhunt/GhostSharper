using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	[DataContract]
	public class TrendingCategories{

		[DataMember(Name="categories", EmitDefaultValue=false)]
		public List<TrendingCategory> Categories { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as TrendingCategories);
        }

		public bool Equals(TrendingCategories input)
		{
			if (input == null) return false;

			return
				(
                    Categories == input.Categories ||
                    (Categories != null && Categories.Equals(input.Categories))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Categories.GetHashCode();
				return hashCode;
			}
		}*/
	}
}
