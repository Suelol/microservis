﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebReaders.DB;

#nullable disable

namespace WebReaders.Migrations
{
    [DbContext(typeof(DBReaders))]
    [Migration("20241207102120_second")]
    partial class second
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebReaders.Model.Arend", b =>
                {
                    b.Property<int>("Id_HA")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_HA"));

                    b.Property<DateTime?>("ArendEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ArendStart")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Book")
                        .HasColumnType("int");

                    b.Property<int>("Id_Reader")
                        .HasColumnType("int");

                    b.HasKey("Id_HA");

                    b.HasIndex("Id_Reader");

                    b.ToTable("Arend");
                });

            modelBuilder.Entity("WebReaders.Model.Readers", b =>
                {
                    b.Property<int>("Id_Reader")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Reader"));

                    b.Property<DateTime>("Birth_Day")
                        .HasColumnType("datetime2");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateRegist")
                        .HasColumnType("datetime2");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Reader");

                    b.ToTable("Readers");
                });

            modelBuilder.Entity("WebReaders.Model.Arend", b =>
                {
                    b.HasOne("WebReaders.Model.Readers", "Readers")
                        .WithMany()
                        .HasForeignKey("Id_Reader")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Readers");
                });
#pragma warning restore 612, 618
        }
    }
}
