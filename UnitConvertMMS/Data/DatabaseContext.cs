using Microsoft.EntityFrameworkCore;

namespace UnitConvertMMS.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }
        DbSet<UnitCategory> UnitCategories { get; set; }
        DbSet<UnitRate> UnitRates { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UnitCategory>().HasData(
                new UnitCategory()
                {
                    Id = 1,
                    Name = "Temperature"
                },
                new UnitCategory()
                {
                    Id = 2,
                    Name = "Length"
                },
                new UnitCategory()
                {
                    Id = 3,
                    Name = "Mass"
                }
                );
            builder.Entity<UnitRate>().HasData(
                new UnitRate()
                {
                    Id = 1,
                    CategoryId = 1,
                    MetricUnitName = "c",
                    ImperialUnitName = "f",
                    Formula = "(X*9/5)+32"
                },
                new UnitRate()
                {
                    Id = 2,
                    CategoryId = 2,
                    MetricUnitName = "mm",
                    ImperialUnitName = "in",
                    RateMetricToImperial = 0.03937
                },
                new UnitRate()
                {
                    Id = 3,
                    CategoryId = 2,
                    MetricUnitName = "cm",
                    ImperialUnitName = "in",
                    RateMetricToImperial = 0.3937
                },
                new UnitRate()
                {
                    Id = 4,
                    CategoryId = 2,
                    MetricUnitName = "m",
                    ImperialUnitName = "yd",
                    RateMetricToImperial = 1.0936
                },
                new UnitRate()
                {
                    Id = 5,
                    CategoryId = 2,
                    MetricUnitName = "km",
                    ImperialUnitName = "mile",
                    RateMetricToImperial = 0.6214
                },
                new UnitRate()
                {
                    Id = 6,
                    CategoryId = 3,
                    MetricUnitName = "mg",
                    ImperialUnitName = "grain",
                    RateMetricToImperial = 0.0154
                },
                new UnitRate()
                {
                    Id = 7,
                    CategoryId = 3,
                    MetricUnitName = "g",
                    ImperialUnitName = "oz",
                    RateMetricToImperial = 0.0353
                },
                new UnitRate()
                {
                    Id = 8,
                    CategoryId = 3,
                    MetricUnitName = "kg",
                    ImperialUnitName = "lb",
                    RateMetricToImperial = 2.2046
                },
                new UnitRate()
                {
                    Id = 9,
                    CategoryId = 3,
                    MetricUnitName = "kg",
                    ImperialUnitName = "ton",
                    RateMetricToImperial = 0.001
                },
                new UnitRate()
                {
                    Id = 10,
                    CategoryId = 1,
                    MetricUnitName = "f",
                    ImperialUnitName = "c",
                    Formula = "(X-32)*5/9"
                },
                new UnitRate()
                {
                    Id = 11,
                    CategoryId = 2,
                    MetricUnitName = "in",
                    ImperialUnitName = "mm",
                    RateMetricToImperial = 25.4
                },
                new UnitRate()
                {
                    Id = 12,
                    CategoryId = 2,
                    MetricUnitName = "in",
                    ImperialUnitName = "cm",
                    RateMetricToImperial = 2.54
                },
                new UnitRate()
                {
                    Id = 13,
                    CategoryId = 2,
                    MetricUnitName = "yd",
                    ImperialUnitName = "m",
                    RateMetricToImperial = 0.9144
                },
                new UnitRate()
                {
                    Id = 14,
                    CategoryId = 2,
                    MetricUnitName = "mile",
                    ImperialUnitName = "km",
                    RateMetricToImperial = 1.6093
                },
                new UnitRate()
                {
                    Id = 15,
                    CategoryId = 3,
                    MetricUnitName = "grain",
                    ImperialUnitName = "mg",
                    RateMetricToImperial = 64.7989
                },
                new UnitRate()
                {
                    Id = 16,
                    CategoryId = 3,
                    MetricUnitName = "oz",
                    ImperialUnitName = "g",
                    RateMetricToImperial = 28.3495
                },
                new UnitRate()
                {
                    Id = 17,
                    CategoryId = 3,
                    MetricUnitName = "lb",
                    ImperialUnitName = "kg",
                    RateMetricToImperial = 0.453592
                },
                new UnitRate()
                {
                    Id = 18,
                    CategoryId = 3,
                    MetricUnitName = "ton",
                    ImperialUnitName = "kg",
                    RateMetricToImperial = 1000
                }
                );

        }

    }
}
