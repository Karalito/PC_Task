// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PresentConnectionAPI.Config;

#nullable disable

namespace PresentConnectionAPI.Data.Migrations
{
    [DbContext(typeof(RecordsDBContext))]
    [Migration("20220516083051_RecordsMigration")]
    partial class RecordsMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("PresentConnectionAPI.Models.Record", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Records");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Body = "This is the body of 1 record form the database made for present connection",
                            Title = "Record 1"
                        },
                        new
                        {
                            Id = 2,
                            Body = "This is the body of 2 record form the database made for present connection",
                            Title = "Record 2"
                        },
                        new
                        {
                            Id = 3,
                            Body = "This is the body of 3 record form the database made for present connection",
                            Title = "Record 3"
                        },
                        new
                        {
                            Id = 4,
                            Body = "This is the body of 4 record form the database made for present connection",
                            Title = "Record 4"
                        },
                        new
                        {
                            Id = 5,
                            Body = "This is the body of 5 record form the database made for present connection",
                            Title = "Record 5"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
