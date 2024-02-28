using System.Text.Json.Serialization;

namespace iikoTestServer.Models
{
    public partial class ProductRequestDto
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("parent")]
        public string Parent { get; set; }
        [JsonPropertyName("modifiers")]
        public ModifierModel[] Modifiers { get; set; }
        [JsonPropertyName("taxCategory")]
        public object TaxCategory { get; set; }
        [JsonPropertyName("category")]
        public string Category { get; set; }
        [JsonPropertyName("color")]
        public ColorDto Color { get; set; }
        [JsonPropertyName("fontColor")]
        public FontcolorDto FontColor { get; set; }
        [JsonPropertyName("frontImageId")]
        public object FrontImageId { get; set; }
        [JsonPropertyName("position")]
        public object Position { get; set; }
        [JsonPropertyName("mainUnit")]
        public string MainUnit { get; set; }
        [JsonPropertyName("excludedSections")]
        public object ExcludedSections { get; set; }
        [JsonPropertyName("defaultSalePrice")]
        public int DefaultSalePrice { get; set; }
        [JsonPropertyName("placeType")]
        public string PlaceType { get; set; }
        [JsonPropertyName("defaultIncludedInMenu")]
        public bool DefaultIncludedInMenu { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("unitWeight")]
        public int UnitWeight { get; set; }
        [JsonPropertyName("unitCapacity")]
        public int UnitCapacity { get; set; }
        [JsonPropertyName("notInStoreMovement")]
        public bool NotInStoreMovement { get; set; }
    }
}
