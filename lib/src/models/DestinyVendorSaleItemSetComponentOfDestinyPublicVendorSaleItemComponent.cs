using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponent{

		[DataMember(Name="saleItems", EmitDefaultValue=false)]
		public Map<String, DestinyPublicVendorSaleItemComponent> SaleItems { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponent);
        }

		public bool Equals(DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponent input)
		{
			if (input == null) return false;

			return
				(
                    SaleItems == input.SaleItems ||
                    (SaleItems != null && SaleItems.Equals(input.SaleItems))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.SaleItems.GetHashCode();
				return hashCode;
			}
		}*/
	}
}
