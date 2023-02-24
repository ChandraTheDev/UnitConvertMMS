﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UnitConvertMMS.Data;

#nullable disable

namespace UnitConvertMMS.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230224132612_SeedingData")]
    partial class SeedingData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UnitConvertMMS.Data.UnitCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UnitCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Temperature"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Length"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Mass"
                        });
                });

            modelBuilder.Entity("UnitConvertMMS.Data.UnitRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Formula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImperialUnitName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MetricUnitName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("RateMetricToImperial")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("UnitRates");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Formula = "(X*9/5)+32",
                            ImperialUnitName = "f",
                            MetricUnitName = "c",
                            RateMetricToImperial = 0.0
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            ImperialUnitName = "in",
                            MetricUnitName = "mm",
                            RateMetricToImperial = 0.039370000000000002
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            ImperialUnitName = "in",
                            MetricUnitName = "cm",
                            RateMetricToImperial = 0.39369999999999999
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            ImperialUnitName = "yd",
                            MetricUnitName = "m",
                            RateMetricToImperial = 1.0935999999999999
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            ImperialUnitName = "mile",
                            MetricUnitName = "km",
                            RateMetricToImperial = 0.62139999999999995
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            ImperialUnitName = "grain",
                            MetricUnitName = "mg",
                            RateMetricToImperial = 0.0154
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            ImperialUnitName = "oz",
                            MetricUnitName = "g",
                            RateMetricToImperial = 0.035299999999999998
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            ImperialUnitName = "lb",
                            MetricUnitName = "kg",
                            RateMetricToImperial = 2.2046000000000001
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            ImperialUnitName = "ton",
                            MetricUnitName = "kg",
                            RateMetricToImperial = 0.98419999999999996
                        });
                });

            modelBuilder.Entity("UnitConvertMMS.Data.UnitRate", b =>
                {
                    b.HasOne("UnitConvertMMS.Data.UnitCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}