namespace IRentNG.Shared.RequestFeatures
{
    public class PropertyParameters : RequestParameters
    {
        public uint MinPrice { get; set; }
        public uint MaxPrice { get; set; } = int.MaxValue;

        public bool ValidPriceRange => MaxPrice > MinPrice;
    }
}
