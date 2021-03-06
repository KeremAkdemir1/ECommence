// <auto-generated />
using System;
using E_Commence.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace E_Commence.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210916071756_InitialCatalog")]
    partial class InitialCatalog
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("E_Commence.Models.Data.Beverage", b =>
                {
                    b.Property<int>("BeverageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Alcohol")
                        .HasColumnType("bit");

                    b.Property<string>("BeverageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BeveragePhotoLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BeveragePrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BeveragesCategoryId")
                        .HasColumnType("int");

                    b.HasKey("BeverageId");

                    b.HasIndex("BeveragesCategoryId");

                    b.ToTable("Beverages");
                });

            modelBuilder.Entity("E_Commence.Models.Data.BeverageCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BeverageCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("BeverageCategories");
                });

            modelBuilder.Entity("E_Commence.Models.Data.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Writer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Writing")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BlogId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("E_Commence.Models.Data.Food", b =>
                {
                    b.Property<int>("FoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("FoodName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FoodPhotoLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FoodPrice")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FoodId");

                    b.HasIndex("CategoryID");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("E_Commence.Models.Data.FoodCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FoodCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("FoodCategories");
                });

            modelBuilder.Entity("E_Commence.Models.Data.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Admin")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("E_Commence.Models.Data.Vegetable", b =>
                {
                    b.Property<int>("VegetableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("VegetableName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VegetablePhotoLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VegetablePrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VegetablesCategoryId")
                        .HasColumnType("int");

                    b.HasKey("VegetableId");

                    b.HasIndex("VegetablesCategoryId");

                    b.ToTable("Vegetables");
                });

            modelBuilder.Entity("E_Commence.Models.Data.VegetableCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("VegetableCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("VegetableCategories");
                });

            modelBuilder.Entity("E_Commence.Models.Data.Beverage", b =>
                {
                    b.HasOne("E_Commence.Models.Data.BeverageCategory", "Beverages")
                        .WithMany("Category")
                        .HasForeignKey("BeveragesCategoryId");

                    b.Navigation("Beverages");
                });

            modelBuilder.Entity("E_Commence.Models.Data.Food", b =>
                {
                    b.HasOne("E_Commence.Models.Data.FoodCategory", "Category")
                        .WithMany("Food")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("E_Commence.Models.Data.Vegetable", b =>
                {
                    b.HasOne("E_Commence.Models.Data.VegetableCategory", "Vegetables")
                        .WithMany("Category")
                        .HasForeignKey("VegetablesCategoryId");

                    b.Navigation("Vegetables");
                });

            modelBuilder.Entity("E_Commence.Models.Data.BeverageCategory", b =>
                {
                    b.Navigation("Category");
                });

            modelBuilder.Entity("E_Commence.Models.Data.FoodCategory", b =>
                {
                    b.Navigation("Food");
                });

            modelBuilder.Entity("E_Commence.Models.Data.VegetableCategory", b =>
                {
                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
