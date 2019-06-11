﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MunicipalityRegistry.Projections.Legacy;

namespace MunicipalityRegistry.Projections.Legacy.Migrations
{
    [DbContext(typeof(LegacyContext))]
    [Migration("20190611072239_RenamePlanToReason")]
    partial class RenamePlanToReason
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Be.Vlaanderen.Basisregisters.ProjectionHandling.Runner.ProjectionStates.ProjectionStateItem", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("Position");

                    b.HasKey("Name")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.ToTable("ProjectionStates","MunicipalityRegistryLegacy");
                });

            modelBuilder.Entity("MunicipalityRegistry.Projections.Legacy.MunicipalityDetail.MunicipalityDetail", b =>
                {
                    b.Property<Guid?>("MunicipalityId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FacilitiesLanguagesAsString")
                        .HasColumnName("FacilitiesLanguages");

                    b.Property<string>("NameDutch");

                    b.Property<string>("NameEnglish");

                    b.Property<string>("NameFrench");

                    b.Property<string>("NameGerman");

                    b.Property<string>("NisCode");

                    b.Property<string>("OfficialLanguagesAsString")
                        .HasColumnName("OfficialLanguages");

                    b.Property<int?>("Status");

                    b.Property<DateTimeOffset>("VersionTimestampAsDateTimeOffset")
                        .HasColumnName("VersionTimestamp");

                    b.HasKey("MunicipalityId")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("NisCode")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.ToTable("MunicipalityDetails","MunicipalityRegistryLegacy");
                });

            modelBuilder.Entity("MunicipalityRegistry.Projections.Legacy.MunicipalityList.MunicipalityListItem", b =>
                {
                    b.Property<Guid?>("MunicipalityId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DefaultName");

                    b.Property<string>("NameDutch");

                    b.Property<string>("NameEnglish");

                    b.Property<string>("NameFrench");

                    b.Property<string>("NameGerman");

                    b.Property<string>("NisCode");

                    b.Property<string>("OfficialLanguagesAsString")
                        .HasColumnName("OfficialLanguages");

                    b.Property<int?>("Status");

                    b.Property<DateTimeOffset>("VersionTimestampAsDateTimeOffset")
                        .HasColumnName("VersionTimestamp");

                    b.HasKey("MunicipalityId")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("DefaultName")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.ToTable("MunicipalityList","MunicipalityRegistryLegacy");
                });

            modelBuilder.Entity("MunicipalityRegistry.Projections.Legacy.MunicipalityName.MunicipalityName", b =>
                {
                    b.Property<Guid>("MunicipalityId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsFlemishRegion");

                    b.Property<string>("NameDutch");

                    b.Property<string>("NameDutchSearch");

                    b.Property<string>("NameEnglish");

                    b.Property<string>("NameEnglishSearch");

                    b.Property<string>("NameFrench");

                    b.Property<string>("NameFrenchSearch");

                    b.Property<string>("NameGerman");

                    b.Property<string>("NameGermanSearch");

                    b.Property<string>("NisCode");

                    b.Property<DateTimeOffset>("VersionTimestampAsDateTimeOffset")
                        .HasColumnName("VersionTimestamp");

                    b.HasKey("MunicipalityId")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("IsFlemishRegion");

                    b.HasIndex("NameDutchSearch");

                    b.HasIndex("NameEnglishSearch");

                    b.HasIndex("NameFrenchSearch");

                    b.HasIndex("NameGermanSearch");

                    b.HasIndex("NisCode")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.HasIndex("VersionTimestampAsDateTimeOffset");

                    b.ToTable("MunicipalityName","MunicipalityRegistryLegacy");
                });

            modelBuilder.Entity("MunicipalityRegistry.Projections.Legacy.MunicipalitySyndication.MunicipalitySyndicationItem", b =>
                {
                    b.Property<long>("Position");

                    b.Property<int?>("Application");

                    b.Property<string>("ChangeType");

                    b.Property<string>("DefaultName");

                    b.Property<string>("EventDataAsXml");

                    b.Property<string>("FacilitiesLanguagesAsString")
                        .HasColumnName("FacilitiesLanguages");

                    b.Property<DateTimeOffset>("LastChangedOnAsDateTimeOffset")
                        .HasColumnName("LastChangedOn");

                    b.Property<int?>("Modification");

                    b.Property<Guid?>("MunicipalityId")
                        .IsRequired();

                    b.Property<string>("NameDutch");

                    b.Property<string>("NameEnglish");

                    b.Property<string>("NameFrench");

                    b.Property<string>("NameGerman");

                    b.Property<string>("NisCode");

                    b.Property<string>("OfficialLanguagesAsString")
                        .HasColumnName("OfficialLanguages");

                    b.Property<string>("Operator");

                    b.Property<int?>("Organisation");

                    b.Property<string>("Reason");

                    b.Property<DateTimeOffset>("RecordCreatedAtAsDateTimeOffset")
                        .HasColumnName("RecordCreatedAt");

                    b.Property<int?>("Status");

                    b.HasKey("Position")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.HasIndex("MunicipalityId");

                    b.ToTable("MunicipalitySyndication","MunicipalityRegistryLegacy");
                });

            modelBuilder.Entity("MunicipalityRegistry.Projections.Legacy.MunicipalityVersion.MunicipalityVersion", b =>
                {
                    b.Property<Guid?>("MunicipalityId");

                    b.Property<long>("Position");

                    b.Property<int?>("Application");

                    b.Property<string>("FacilitiesLanguagesAsString")
                        .HasColumnName("FacilitiesLanguages");

                    b.Property<int?>("Modification");

                    b.Property<string>("NameDutch");

                    b.Property<string>("NameEnglish");

                    b.Property<string>("NameFrench");

                    b.Property<string>("NameGerman");

                    b.Property<string>("NisCode");

                    b.Property<string>("OfficialLanguagesAsString")
                        .HasColumnName("OfficialLanguages");

                    b.Property<string>("Operator");

                    b.Property<int?>("Organisation");

                    b.Property<string>("Reason");

                    b.Property<int?>("Status");

                    b.Property<DateTimeOffset?>("VersionTimestampAsDateTimeOffset")
                        .HasColumnName("VersionTimestamp");

                    b.HasKey("MunicipalityId", "Position")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("MunicipalityId");

                    b.HasIndex("NisCode")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.HasIndex("Position");

                    b.ToTable("MunicipalityVersions","MunicipalityRegistryLegacy");
                });
#pragma warning restore 612, 618
        }
    }
}
