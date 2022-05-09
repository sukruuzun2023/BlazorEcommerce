using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Mustafa Kemal Atatürk[c] (1881[d] - 10 Kasım 1938), Türk asker, devlet adamı ve Türkiye Cumhuriyeti'nin kurucusudur.", "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a8/Ataturk1930s.jpg/444px-Ataturk1930s.jpg", 9.05m, "Mustafa Kemal Atatürk" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Makbule Atadan (1885, Selanik - 18 Ocak 1956, Ankara), Türk yazar ve siyasetçidir. Türkiye Cumhuriyeti'nin kurucusu Mustafa Kemal Atatürk'ün kız kardeşidir.[1]", "https://upload.wikimedia.org/wikipedia/commons/b/b0/Makbule_Atadan_%28cropped%29.jpg", 7.99m, "Makbule Atadan" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Zübeyde Hanım (1857, Selanik - 14 Ocak 1923, İzmir), Ali Rıza Efendi'nin eşi, Mustafa Kemal Atatürk'ün ve Makbule Atadan'ın annesidir. Aslen Karamanlıdır.[2]", "https://upload.wikimedia.org/wikipedia/commons/thumb/4/43/Z%C3%BCbeyde_Han%C4%B1m.jpg/220px-Z%C3%BCbeyde_Han%C4%B1m.jpg", 8.99m, "Zübeyde Hanım" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
