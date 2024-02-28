namespace iikoTestServer.Models
{

    public partial class ProductModel
    {
        //public object TaxCategory { get; set; }
        //public string Category { get; set; }
        //public string AccountingCategory { get; set; }
        //public object FrontImageId { get; set; }
        //public object Position { get; set; }
        //public object ModifierSchemaId { get; set; }
        //public string MainUnit { get; set; }
        //public object[] ExcludedSections { get; set; }
        //public int DefaultSalePrice { get; set; }
        //public string PlaceType { get; set; }
        //public bool DefaultIncludedInMenu { get; set; }
        //public string Type { get; set; }
        //public int UnitWeight { get; set; }
        //public int UnitCapacity { get; set; }
        //public object[] StoreBalanceLevels { get; set; }
        //public object[] Containers { get; set; }
        //public object ProductScaleId { get; set; }
        //public object[] Barcodes { get; set; }
        //public int ColdLossPercent { get; set; }
        //public int HotLossPercent { get; set; }
        //public object[] AllergenGroups { get; set; }
        //public int EstimatedPurchasePrice { get; set; }
        //public bool CanSetOpenPrice { get; set; }
        //public bool NotInStoreMovement { get; set; }

        public class ModifierModel
        {
            public string Modifier { get; set; }
            public int DefaultAmount { get; set; }
            public int FreeOfChargeAmount { get; set; }
            public int MinimumAmount { get; set; }
            public int MaximumAmount { get; set; }
            public bool HideIfDefaultAmount { get; set; }
            public bool Required { get; set; }
            public bool ChildModifiersHaveMinMaxRestrictions { get; set; }
            public bool Splittable { get; set; }
            public ModifierModel[] ChildModifiers { get; set; }
        }
    }
}
