﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MunicipalityRegistry.Projections.Extract;

namespace MunicipalityRegistry.Projections.Extract.Migrations
{
    [DbContext(typeof(ExtractContext))]
    [Migration("20190417120800_AddLanguageInformation")]
    partial class AddLanguageInformation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Be.Vlaanderen.Basisregisters.ProjectionHandling.Runner.ProjectionStates.ProjectionStateItem", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("Position");

                    b.HasKey("Name")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.ToTable("ProjectionStates","MunicipalityRegistryExtract");
                });

            modelBuilder.Entity("MunicipalityRegistry.Projections.Extract.MunicipalityExtract.MunicipalityExtractItem", b =>
                {
                    b.Property<Guid?>("MunicipalityId")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("DbaseRecord");

                    b.Property<string>("NameDutch");

                    b.Property<string>("NameEnglish");

                    b.Property<string>("NameFrench");

                    b.Property<string>("NameGerman");

                    b.Property<string>("NisCode");

                    b.Property<string>("OfficialLanguagesAsString")
                        .HasColumnName("OfficialLanguages");

                    b.HasKey("MunicipalityId")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("NisCode")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.ToTable("Municipality","MunicipalityRegistryExtract");
                });
#pragma warning restore 612, 618
        }
    }
}
