namespace BookManagerApp.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BookManagerApp.Models.BookManagerAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookManagerApp.Models.BookManagerAppContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var garciaMarquez = new Author() { Name = "Gabriel Garc�a Marquez" };
            var cervantes = new Author() { Name = "Miguel de Cervantes" };

            var classic = new Category() { Name = "Classic" };

            var book1 = new Book()
            {
                Author = garciaMarquez,
                Category = classic,
                Title = "Cien a�os de soledad",
                Description = "El libro narra la historia de la familia Buend�a a lo largo de siete generaciones en el pueblo ficticio de Macondo. Jos� Arcadio Buend�a y �rsula Iguar�n son un matrimonio de primos que se casaron llenos de presagios y temores por su parentesco y el mito existente..."
            };

            var book2 = new Book()
            {
                Author = cervantes,
                Category = classic,
                Title = "Don Quijote de la Mancha",
                Description = "La novela comienza describi�ndonos a un tal Alonso Quijano, hidalgo pobre, que enloquece leyendo libros de caballer�as y se cree un caballero medieval. Decide armarse como tal en una venta, que �l ve como castillo. Le suceden toda suerte de c�micas aventuras en las que..."
            };

            if (!context.Authors.Any())
            {
                context.Authors.Add(garciaMarquez);
                context.Authors.Add(cervantes);
            }

            if (!context.Categories.Any())
            {
                context.Categories.Add(classic);
            }

            if (!context.Books.Any())
            {
                context.Books.Add(book1);
                context.Books.Add(book2);
            }

            context.SaveChanges();
        }
    }
}
