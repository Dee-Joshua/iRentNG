namespace IRentNG.Shared.RequestFeatures
{
    public class PropertyParameters : RequestParameters
    {
        public PropertyParameters() => OrderBy = "name";

        public uint MinPrice { get; set; }
        public uint MaxPrice { get; set; } = int.MaxValue;

        public bool ValidPriceRange => MaxPrice > MinPrice;

        public string? SearchTerm { get; set; }
    }
}
