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
                    RateMetricToImperial = 0.9842
                }
                );

        }

    }
}
