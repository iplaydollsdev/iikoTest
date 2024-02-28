namespace iikoTestServer.Models
{
    public partial class ProductResponseDto
    {
        public string Id { get; set; }
        public bool Deleted { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Num { get; set; }
        public string Code { get; set; }
        public string Parent { get; set; }
        public ModifierModel[] Modifiers { get; set; }
        public object TaxCategory { get; set; }
        public string Category { get; set; }
        public string AccountingCategory { get; set; }
        public ColorDto Color { get; set; }
        public FontcolorDto FontColor { get; set; }
        public object FrontImageId { get; set; }
        public object Position { get; set; }
        public object ModifierSchemaId { get; set; }
        public string MainUnit { get; set; }
        public object ExcludedSections { get; set; }
        public int DefaultSalePrice { get; set; }
        public string PlaceType { get; set; }
        public bool DefaultIncludedInMenu { get; set; }
        public string Type { get; set; }
        public int UnitWeight { get; set; }
        public int UnitCapacity { get; set; }
        public object[] StoreBalanceLevels { get; set; }
        public object[] Containers { get; set; }
        public object ProductScaleId { get; set; }
        public object[] Barcodes { get; set; }
        public int ColdLossPercent { get; set; }
        public int HotLossPercent { get; set; }
        public object[] AllergenGroups { get; set; }
        public int EstimatedPurchasePrice { get; set; }
        public bool CanSetOpenPrice { get; set; }
        public bool NotInStoreMovement { get; set; }
    }
}
