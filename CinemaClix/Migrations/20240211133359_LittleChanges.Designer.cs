﻿// <auto-generated />
using System;
using CinemaClix.ApplicationDBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CinemaClix.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20240211133359_LittleChanges")]
    partial class LittleChanges
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CinemaClix.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DirectorPhoto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmbedCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A bachelor party gone wrong.",
                            Director = "Todd Phillips",
                            DirectorPhoto = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c4/Todd_Phillips_%2829486703114%29.jpg/220px-Todd_Phillips_%2829486703114%29.jpg",
                            EmbedCode = "https://www.youtube.com/embed/tlize92ffnY?si=8_7TYqfFhuA7IrRm",
                            Genre = "Comedy",
                            Image = "https://m.media-amazon.com/images/M/MV5BNGQwZjg5YmYtY2VkNC00NzliLTljYTctNzI5NmU3MjE2ODQzXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_.jpg",
                            Rating = "⭐⭐⭐⭐",
                            ReleaseDate = new DateTime(2009, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Hangover"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Based on the true case files of paranormal investigators.",
                            Director = "James Wan",
                            DirectorPhoto = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ec/James_Wan_in_2019.jpg/220px-James_Wan_in_2019.jpg",
                            EmbedCode = "https://www.youtube.com/embed/k10ETZ41q5o?si=nWLREnlD1OIxo-Ds",
                            Genre = "Horror",
                            Image = "https://musicart.xboxlive.com/7/8ac41100-0000-0000-0000-000000000002/504/image.jpg?w=1920&h=1080",
                            Rating = "⭐⭐⭐",
                            ReleaseDate = new DateTime(2013, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Conjuring"
                        },
                        new
                        {
                            Id = 3,
                            Description = "A tale of love, wealth, and tragedy in the Roaring Twenties.",
                            Director = "Baz Luhrmann",
                            DirectorPhoto = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9a/Baz_Luhrmann%2C_%2852123943853%29.jpg/220px-Baz_Luhrmann%2C_%2852123943853%29.jpg",
                            EmbedCode = "https://www.youtube.com/embed/nIewKn6EnAs?si=OLrl6d4S8kE2lj_7",
                            Genre = "Romance",
                            Image = "https://m.media-amazon.com/images/M/MV5BMTkxNTk1ODcxNl5BMl5BanBnXkFtZTcwMDI1OTMzOQ@@._V1_FMjpg_UX1000_.jpg",
                            Rating = "⭐⭐⭐⭐⭐",
                            ReleaseDate = new DateTime(2013, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Great Gatsby"
                        },
                        new
                        {
                            Id = 4,
                            Description = "A high-octane post-apocalyptic action film.",
                            Director = "George Miller",
                            DirectorPhoto = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/13/George_Miller_%2835706244922%29.jpg/220px-George_Miller_%2835706244922%29.jpg",
                            EmbedCode = "https://www.youtube.com/embed/hEJnMQG9ev8?si=FuiIkFOQQ1ONZ9u_",
                            Genre = "Action",
                            Image = "https://m.media-amazon.com/images/M/MV5BN2EwM2I5OWMtMGQyMi00Zjg1LWJkNTctZTdjYTA4OGUwZjMyXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_.jpg",
                            Rating = "⭐⭐⭐⭐",
                            ReleaseDate = new DateTime(2015, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Mad Max: Fury Road"
                        },
                        new
                        {
                            Id = 5,
                            Description = "An animated underwater adventure to find a lost son.",
                            Director = "Andrew Stanton",
                            DirectorPhoto = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/52/Andrew_Stanton_cropped_2009.jpg/220px-Andrew_Stanton_cropped_2009.jpg",
                            EmbedCode = "https://www.youtube.com/embed/wZdpNglLbt8?si=S5voA75MAG_mjVbq",
                            Genre = "Comedy",
                            Image = "https://lumiere-a.akamaihd.net/v1/images/p_findingnemo_19752_05271d3f.jpeg?region=0%2C0%2C540%2C810",
                            Rating = "⭐⭐⭐",
                            ReleaseDate = new DateTime(2003, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Finding Nemo"
                        },
                        new
                        {
                            Id = 6,
                            Description = "A heartwarming love story across decades.",
                            Director = "Nick Cassavetes",
                            DirectorPhoto = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/38/NickCassavetesJune09.jpg/220px-NickCassavetesJune09.jpg",
                            EmbedCode = "https://www.youtube.com/embed/BjJcYdEOI0k?si=BMadHTedURGAwZUI",
                            Genre = "Drama",
                            Image = "https://m.media-amazon.com/images/M/MV5BNzc3Mzg1OGYtZjc3My00Y2NhLTgyOWUtYjRhMmI4OTkwNDg4XkEyXkFqcGdeQXVyMTU3NDU4MDg2._V1_.jpg",
                            Rating = "⭐⭐⭐⭐⭐",
                            ReleaseDate = new DateTime(2004, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Notebook"
                        },
                        new
                        {
                            Id = 7,
                            Description = "A dystopian future where artificial beings question their existence.",
                            Director = "Ridley Scott",
                            DirectorPhoto = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/12/NASA_Journey_to_Mars_and_%E2%80%9CThe_Martian%E2%80%9D_%28201508180030HQ%29.jpg/220px-NASA_Journey_to_Mars_and_%E2%80%9CThe_Martian%E2%80%9D_%28201508180030HQ%29.jpg",
                            EmbedCode = "https://www.youtube.com/embed/gCcx85zbxz4?si=3lnpek05_TeduKqP",
                            Genre = "Adventure",
                            Image = "https://m.media-amazon.com/images/M/MV5BNzA1Njg4NzYxOV5BMl5BanBnXkFtZTgwODk5NjU3MzI@._V1_.jpg",
                            Rating = "⭐⭐⭐⭐",
                            ReleaseDate = new DateTime(1982, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Blade Runner"
                        },
                        new
                        {
                            Id = 8,
                            Description = "A fairy tale adventure with love, humor, and sword fights.",
                            Director = "Rob Reiner",
                            DirectorPhoto = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/11/Rob_Reiner_MFF_2016.jpg/220px-Rob_Reiner_MFF_2016.jpg",
                            EmbedCode = "https://www.youtube.com/embed/O3CIXEAjcc8?si=DdlJdpK5Xg8Wgrx3",
                            Genre = "Horror",
                            Image = "https://m.media-amazon.com/images/M/MV5BMTQwMTIzMTYyOV5BMl5BanBnXkFtZTYwOTI3MTk2._V1_.jpg",
                            Rating = "⭐⭐⭐⭐",
                            ReleaseDate = new DateTime(1987, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Princess Bride"
                        },
                        new
                        {
                            Id = 9,
                            Description = "An astronaut's struggle for survival on Mars.",
                            Director = "Ridley Scott",
                            DirectorPhoto = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/12/NASA_Journey_to_Mars_and_%E2%80%9CThe_Martian%E2%80%9D_%28201508180030HQ%29.jpg/220px-NASA_Journey_to_Mars_and_%E2%80%9CThe_Martian%E2%80%9D_%28201508180030HQ%29.jpg",
                            EmbedCode = "https://www.youtube.com/embed/Ue4PCI0NamI?si=quRuKTUJdxnjDrB0",
                            Genre = "Adventure",
                            Image = "https://lumiere-a.akamaihd.net/v1/images/image_a119dd78.jpeg?region=0%2C0%2C800%2C1200",
                            Rating = "⭐⭐",
                            ReleaseDate = new DateTime(2015, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Martian"
                        },
                        new
                        {
                            Id = 10,
                            Description = "A psychological thriller set on an eerie island.",
                            Director = "Martin Scorsese",
                            DirectorPhoto = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/ce/Martin_Scorsese_MFF_2023.jpg/220px-Martin_Scorsese_MFF_2023.jpg",
                            EmbedCode = "https://www.youtube.com/embed/v8yrZSkKxTA?si=t4JzRlAXamclN8ux",
                            Genre = "Horror",
                            Image = "https://m.media-amazon.com/images/M/MV5BYzhiNDkyNzktNTZmYS00ZTBkLTk2MDAtM2U0YjU1MzgxZjgzXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_.jpg",
                            Rating = "⭐⭐⭐⭐⭐",
                            ReleaseDate = new DateTime(2010, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Shutter Island"
                        },
                        new
                        {
                            Id = 11,
                            Description = "A mind-bending heist in dreams within dreams.",
                            Director = "Christopher Nolan",
                            DirectorPhoto = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/95/Christopher_Nolan_Cannes_2018.jpg/220px-Christopher_Nolan_Cannes_2018.jpg",
                            EmbedCode = "https://www.youtube.com/embed/YoHD9XEInc0?si=q9osXK79R6eD4Ue3",
                            Genre = "Action",
                            Image = "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_.jpg",
                            Rating = "⭐⭐⭐⭐⭐",
                            ReleaseDate = new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Inception"
                        },
                        new
                        {
                            Id = 12,
                            Description = "A gritty and intense superhero film.",
                            Director = "Christopher Nolan",
                            DirectorPhoto = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/95/Christopher_Nolan_Cannes_2018.jpg/220px-Christopher_Nolan_Cannes_2018.jpg",
                            EmbedCode = "https://www.youtube.com/embed/EXeTwQWrcwY?si=Zo_r5S1UQl2-w46s",
                            Genre = "Action",
                            Image = "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_FMjpg_UX1000_.jpg",
                            Rating = "⭐⭐⭐⭐⭐",
                            ReleaseDate = new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Dark Knight"
                        },
                        new
                        {
                            Id = 13,
                            Description = "Dinosaurs come alive in a theme park.",
                            Director = "Steven Spielberg",
                            DirectorPhoto = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8f/MKr25425_Steven_Spielberg_%28Berlinale_2023%29.jpg/220px-MKr25425_Steven_Spielberg_%28Berlinale_2023%29.jpg",
                            EmbedCode = "https://www.youtube.com/embed/lc0UehYemQA?si=_pNuZM-XRGmD7gBi",
                            Genre = "Adventure",
                            Image = "https://m.media-amazon.com/images/M/MV5BMjM2MDgxMDg0Nl5BMl5BanBnXkFtZTgwNTM2OTM5NDE@._V1_FMjpg_UX1000_.jpg",
                            Rating = "⭐⭐⭐",
                            ReleaseDate = new DateTime(1993, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Jurassic Park"
                        },
                        new
                        {
                            Id = 14,
                            Description = "A story of hope and friendship in prison.",
                            Director = "Frank Darabont",
                            DirectorPhoto = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/19/Frank_Darabont_at_the_PaleyFest_2011_-_The_Walking_Dead_panel.jpg/220px-Frank_Darabont_at_the_PaleyFest_2011_-_The_Walking_Dead_panel.jpg",
                            EmbedCode = "https://www.youtube.com/embed/6hB3S9bIaco?si=3NTTLFhDS1iBi-n9",
                            Genre = "Drama",
                            Image = "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlYWMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_FMjpg_UX1000_.jpg",
                            Rating = "⭐⭐⭐⭐⭐",
                            ReleaseDate = new DateTime(1994, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Shawshank Redemption"
                        },
                        new
                        {
                            Id = 15,
                            Description = "A man with a low IQ experiences key historical events.",
                            Director = "Robert Zemeckis",
                            DirectorPhoto = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d7/Robert_Zemeckis_%22The_Walk%22_at_Opening_Ceremony_of_the_28th_Tokyo_International_Film_Festival_%2821835891403%29_%28cropped%29.jpg/220px-Robert_Zemeckis_%22The_Walk%22_at_Opening_Ceremony_of_the_28th_Tokyo_International_Film_Festival_%2821835891403%29_%28cropped%29.jpg",
                            EmbedCode = "https://www.youtube.com/embed/bLvqoHBptjg?si=j8yWcQDqRTy2qUuE",
                            Genre = "Drama",
                            Image = "https://resizing.flixster.com/-XZAfHZM39UwaGJIFWKAE8fS0ak=/v3/t/assets/p15829_v_v13_aa.jpg",
                            Rating = "⭐⭐⭐",
                            ReleaseDate = new DateTime(1994, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Forrest Gump"
                        },
                        new
                        {
                            Id = 16,
                            Description = "A computer hacker learns shocking truths about reality.",
                            Director = "The Wachowskis",
                            DirectorPhoto = "https://m.media-amazon.com/images/M/MV5BMTU1Mjc1MjkzNV5BMl5BanBnXkFtZTgwOTc1NDQ1ODE@._V1_.jpg",
                            EmbedCode = "https://www.youtube.com/embed/m8e-FF8MsqU?si=8sou_wIiTMqUCsIo",
                            Genre = "Action",
                            Image = "https://m.media-amazon.com/images/M/MV5BNzQzOTk3OTAtNDQ0Zi00ZTVkLWI0MTEtMDllZjNkYzNjNTc4L2ltYWdlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_.jpg",
                            Rating = "⭐⭐⭐",
                            ReleaseDate = new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Matrix"
                        },
                        new
                        {
                            Id = 17,
                            Description = "A mafia epic depicting the Corleone family.",
                            Director = "Francis Ford Coppola",
                            DirectorPhoto = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7a/Francis_Ford_Coppola_%2833906700778%29_%28cropped%29.jpg/220px-Francis_Ford_Coppola_%2833906700778%29_%28cropped%29.jpg",
                            EmbedCode = "https://www.youtube.com/embed/sY1S34973zA?si=t7Q3J-XlRUu3wY7k",
                            Genre = "Crime",
                            Image = "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_FMjpg_UX1000_.jpg",
                            Rating = "⭐⭐",
                            ReleaseDate = new DateTime(1972, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Godfather"
                        },
                        new
                        {
                            Id = 18,
                            Description = "An underground fight club that spirals out of control.",
                            Director = "David Fincher",
                            DirectorPhoto = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d1/TheKillerBFILFF051023_%288_of_22%29_%2853255176376%29_%28cropped2%29.jpg/800px-TheKillerBFILFF051023_%288_of_22%29_%2853255176376%29_%28cropped2%29.jpg",
                            EmbedCode = "https://www.youtube.com/embed/BdJKm16Co6M?si=4k-jeEdjR1eG2a4T",
                            Genre = "Drama",
                            Image = "https://m.media-amazon.com/images/M/MV5BMmEzNTkxYjQtZTc0MC00YTVjLTg5ZTEtZWMwOWVlYzY0NWIwXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_.jpg",
                            Rating = "⭐⭐⭐",
                            ReleaseDate = new DateTime(1999, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Fight Club"
                        },
                        new
                        {
                            Id = 19,
                            Description = "A nonlinear narrative intertwining various criminal stories.",
                            Director = "Pulp Fiction",
                            DirectorPhoto = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0b/Quentin_Tarantino_by_Gage_Skidmore.jpg/800px-Quentin_Tarantino_by_Gage_Skidmore.jpg",
                            EmbedCode = "https://www.youtube.com/embed/s7EdQ4FqbhY?si=jN_1gLJmSmuNt2oh",
                            Genre = "Crime",
                            Image = "https://m.media-amazon.com/images/M/MV5BNGNhMDIzZTUtNTBlZi00MTRlLWFjM2QtODNmMjVhZjhlZjFiXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_FMjpg_UX1000_.jpg",
                            Rating = "⭐",
                            ReleaseDate = new DateTime(1994, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Pulp Fiction"
                        });
                });

            modelBuilder.Entity("CinemaClix.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("GmailAddress")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SubscriptionPlans", b =>
                {
                    b.Property<int>("SubscriptionPlansId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubscriptionPlansId"));

                    b.Property<string>("PlanPrice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlanType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubscriptionPlansId");

                    b.ToTable("SubscriptionPlans");

                    b.HasData(
                        new
                        {
                            SubscriptionPlansId = 1,
                            PlanPrice = "$9.99",
                            PlanType = "Basic"
                        },
                        new
                        {
                            SubscriptionPlansId = 2,
                            PlanPrice = "$14.99",
                            PlanType = "Standard"
                        },
                        new
                        {
                            SubscriptionPlansId = 3,
                            PlanPrice = "$19.99",
                            PlanType = "Premium"
                        });
                });

            modelBuilder.Entity("Subscriptions", b =>
                {
                    b.Property<int>("SubscriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubscriptionId"));

                    b.Property<int>("SubscriptionPlansId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("SubscriptionId");

                    b.HasIndex("SubscriptionPlansId");

                    b.HasIndex("UserId");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("Subscriptions", b =>
                {
                    b.HasOne("SubscriptionPlans", "SubscriptionPlans")
                        .WithMany()
                        .HasForeignKey("SubscriptionPlansId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinemaClix.Models.User", "User")
                        .WithMany("Subscriptions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SubscriptionPlans");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CinemaClix.Models.User", b =>
                {
                    b.Navigation("Subscriptions");
                });
#pragma warning restore 612, 618
        }
    }
}
