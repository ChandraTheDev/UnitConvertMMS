using System.ComponentModel.DataAnnotations.Schema;

namespace UnitConvertMMS.Data
{
    public class UnitRate
    {
        public int Id { get; set; }
        [ForeignKey(nameof(UnitCategory))]
        public int CategoryId { get; set; }
        public UnitCategory? Category { get; set; }
        public string? MetricUnitName { get; set; }
        public string? ImperialUnitName { get; set; }
        public double RateMetricToImperial { get; set; }
        public string? Formula { get; set; }
    }
}
