using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Books",
                    Url ="books"
                },
                new Category
                {
                    Id = 2,
                    Name = "Movies",
                    Url = "movies"
                },
                new Category
                {
                    Id = 3,
                    Name = "Video Games",
                    Url = "video-games"
                }

                );

            modelBuilder.Entity<Product>().HasData(
                 new Product
                 {
                     Id = 1,
                     Title = "Mustafa Kemal Atatürk",
                     Description = "Mustafa Kemal Atatürk[c] (1881[d] - 10 Kasım 1938), Türk asker, devlet adamı ve Türkiye Cumhuriyeti'nin kurucusudur.",
                     ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a8/Ataturk1930s.jpg/444px-Ataturk1930s.jpg",
                     Price = 9.05m,
                     CategoryId=1
                 },
                 new Product
                {
            Id = 2,
            Title = "Makbule Atadan",
            Description = "Makbule Atadan (1885, Selanik - 18 Ocak 1956, Ankara), Türk yazar ve siyasetçidir. Türkiye Cumhuriyeti'nin kurucusu Mustafa Kemal Atatürk'ün kız kardeşidir.[1]",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b0/Makbule_Atadan_%28cropped%29.jpg",
            Price = 7.99m,
            CategoryId = 1
                 },
        new Product
        {
            Id = 3,
            Title = "Zübeyde Hanım",
            Description = "Zübeyde Hanım (1857, Selanik - 14 Ocak 1923, İzmir), Ali Rıza Efendi'nin eşi, Mustafa Kemal Atatürk'ün ve Makbule Atadan'ın annesidir. Aslen Karamanlıdır.[2]",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/43/Z%C3%BCbeyde_Han%C4%B1m.jpg/220px-Z%C3%BCbeyde_Han%C4%B1m.jpg",
            Price = 8.99m,
            CategoryId = 1
        },
        new Product
        {
            Id = 4,
            Title = "Mustafa Kemal Atatürk2",
            Description = "Mustafa Kemal Atatürk[c] (1881[d] - 10 Kasım 1938), Türk asker, devlet adamı ve Türkiye Cumhuriyeti'nin kurucusudur.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a8/Ataturk1930s.jpg/444px-Ataturk1930s.jpg",
            Price = 9.05m,
            CategoryId = 2
        },
                 new Product
                 {
                     Id = 5,
                     Title = "Makbule Atadan2",
                     Description = "Makbule Atadan (1885, Selanik - 18 Ocak 1956, Ankara), Türk yazar ve siyasetçidir. Türkiye Cumhuriyeti'nin kurucusu Mustafa Kemal Atatürk'ün kız kardeşidir.[1]",
                     ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b0/Makbule_Atadan_%28cropped%29.jpg",
                     Price = 7.99m,
                     CategoryId = 2
                 },
        new Product
        {
            Id = 6,
            Title = "Zübeyde Hanım2",
            Description = "Zübeyde Hanım (1857, Selanik - 14 Ocak 1923, İzmir), Ali Rıza Efendi'nin eşi, Mustafa Kemal Atatürk'ün ve Makbule Atadan'ın annesidir. Aslen Karamanlıdır.[2]",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/43/Z%C3%BCbeyde_Han%C4%B1m.jpg/220px-Z%C3%BCbeyde_Han%C4%B1m.jpg",
            Price = 8.99m,
            CategoryId = 2
        },
         new Product
         {
             Id = 7,
             Title = "Mustafa Kemal Atatürk2",
             Description = "Mustafa Kemal Atatürk[c] (1881[d] - 10 Kasım 1938), Türk asker, devlet adamı ve Türkiye Cumhuriyeti'nin kurucusudur.",
             ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a8/Ataturk1930s.jpg/444px-Ataturk1930s.jpg",
             Price = 9.05m,
             CategoryId = 3
         },
                 new Product
                 {
                     Id = 8,
                     Title = "Makbule Atadan2",
                     Description = "Makbule Atadan (1885, Selanik - 18 Ocak 1956, Ankara), Türk yazar ve siyasetçidir. Türkiye Cumhuriyeti'nin kurucusu Mustafa Kemal Atatürk'ün kız kardeşidir.[1]",
                     ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b0/Makbule_Atadan_%28cropped%29.jpg",
                     Price = 7.99m,
                     CategoryId = 3
                 },
        new Product
        {
            Id = 9,
            Title = "Zübeyde Hanım2",
            Description = "Zübeyde Hanım (1857, Selanik - 14 Ocak 1923, İzmir), Ali Rıza Efendi'nin eşi, Mustafa Kemal Atatürk'ün ve Makbule Atadan'ın annesidir. Aslen Karamanlıdır.[2]",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/43/Z%C3%BCbeyde_Han%C4%B1m.jpg/220px-Z%C3%BCbeyde_Han%C4%B1m.jpg",
            Price = 8.99m,
            CategoryId = 3
        }



                );
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
