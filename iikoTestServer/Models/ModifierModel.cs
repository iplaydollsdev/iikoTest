namespace iikoTestServer.Models
{
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
