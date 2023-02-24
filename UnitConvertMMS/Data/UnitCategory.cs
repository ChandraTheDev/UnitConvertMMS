namespace UnitConvertMMS.Data
{
    public class UnitCategory
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual IList<UnitRate> UnitRates { get; set; }
    }
}
