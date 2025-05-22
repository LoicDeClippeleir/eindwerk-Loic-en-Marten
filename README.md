# eindwerk-Loic-en-Marten

<table class="table table-striped table-hover table-bordered">
    <thead class="table-dark">


     <button type="button" class="btn btn-success" asp-action="Edit" asp-route-id="@item.Id">Edit</button>
                    <button type="button" class="btn btn-danger" asp-action="Delete" asp-route-id="@item.Id">Delete</button>
                    <button type="button" class="btn btn-warning" asp-action="Details" asp-route-id="@item.Id">Details</button>

                          if (!ModelState.IsValid)
            {
                
                // Bekijk de fouten in ModelState
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
                return View(leerkracht); // Toon het formulier opnieuw met validatiefouten
            }
            // Map het model naar de database-entiteit en sla op
            var leerkrachtViewmodel = new Leerkracht
            {
                Naam = leerkracht.Naam,
                GeboorteDatum = leerkracht.GeboorteDatum,
                EMail = leerkracht.EMail,
                Adres = leerkracht.Adres,
                Vakken = leerkracht.VakkenIds.Select(id => new Vak { Id = id }).ToList()
            };
            _context.Leerkrachten.Add(leerkrachtViewmodel);
            _context.SaveChanges();
            return View(leerkrachtViewmodel);

             new DbSeeder().Seed(builder);
            builder.Entity<Leerkracht>().HasMany(l => l.Vakken).WithOne(l => l.Leerkracht);
            builder.Entity<Leerling>().HasOne(l => l.Studentenkaart).WithOne(k => k.Leerling);
            builder.Entity<Leerling>().HasOne(l=> l.Opleiding).WithMany(k=> k.Leerlingen).HasForeignKey(l => l.OpleidingId);
            builder.Entity<Opleiding>().HasMany(l=> l.Vakken).WithMany(k=> k.Opleidingen).UsingEntity(j => j.ToTable("Opleidingsvakken"));
            base.OnModelCreating(builder);



Rolseeder
            using Bogus.DataSets;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace SimpleSchool.Seeders
{
    public class RolSeeder : ISeeder
    {
        public void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData( new IdentityRole { Name = "Leerling", NormalizedName = "LEERLING" }, 
                                                         new IdentityRole { Name = "Leerkracht", NormalizedName = "LEERKRACHT"},
                                                         new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" });
        }
    }
}

in program :
/*builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<SimpleSchoolContext>();
builder.Services.AddControllersWithViews();*/
