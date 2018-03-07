﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using NugetAuditor;
using System;

namespace NugetAuditor.Migrations
{
    [DbContext(typeof(AuditorDbContext))]
    partial class AuditorDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NugetAuditor.Data.ProcessResult", b =>
                {
                    b.Property<string>("PackageId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CurrentVersion");

                    b.Property<DateTime>("DatePublished");

                    b.Property<bool>("IconUrlIsValid");

                    b.Property<bool>("IsSigned");

                    b.Property<bool>("LicenceUrlIsFWLink");

                    b.Property<bool>("LicenceUrlIsValid");

                    b.Property<string>("PackageTitle");

                    b.Property<bool>("ProjectUrlIsFWLink");

                    b.Property<bool>("ProjectUrlIsValid");

                    b.Property<long>("TotalDownloads");

                    b.Property<long>("TotalVersions");

                    b.HasKey("PackageId");

                    b.ToTable("Results");
                });
#pragma warning restore 612, 618
        }
    }
}
