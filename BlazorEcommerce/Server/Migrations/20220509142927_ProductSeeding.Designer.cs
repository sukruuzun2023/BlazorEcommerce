// <auto-generated />
using BlazorEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220509142927_ProductSeeding")]
    partial class ProductSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Mustafa Kemal Atatürk[c] (1881[d] - 10 Kasım 1938), Türk asker, devlet adamı ve Türkiye Cumhuriyeti'nin kurucusudur.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a8/Ataturk1930s.jpg/444px-Ataturk1930s.jpg",
                            Price = 9.05m,
                            Title = "Mustafa Kemal Atatürk"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Makbule Atadan (1885, Selanik - 18 Ocak 1956, Ankara), Türk yazar ve siyasetçidir. Türkiye Cumhuriyeti'nin kurucusu Mustafa Kemal Atatürk'ün kız kardeşidir.[1]",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b0/Makbule_Atadan_%28cropped%29.jpg",
                            Price = 7.99m,
                            Title = "Makbule Atadan"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Zübeyde Hanım (1857, Selanik - 14 Ocak 1923, İzmir), Ali Rıza Efendi'nin eşi, Mustafa Kemal Atatürk'ün ve Makbule Atadan'ın annesidir. Aslen Karamanlıdır.[2]",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/43/Z%C3%BCbeyde_Han%C4%B1m.jpg/220px-Z%C3%BCbeyde_Han%C4%B1m.jpg",
                            Price = 8.99m,
                            Title = "Zübeyde Hanım"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
