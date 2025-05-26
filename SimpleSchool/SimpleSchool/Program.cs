using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SimpleSchool.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<SimpleSchoolContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<SimpleSchoolContext>();


/*builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<SimpleSchoolContext>();
builder.Services.AddControllersWithViews();*/

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

async Task SeedRoles(IServiceProvider serviceProvider)
{
    var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

    string[] roles = { "Leerkracht", "Leerling" };

    foreach (var role in roles)
    {
        if (!await roleManager.RoleExistsAsync(role))
        {
            await roleManager.CreateAsync(new IdentityRole(role));
        }
    }

    // Voeg standaard Leerkracht toe
    string leerkrachtEmail = "leerkracht@school.be";
    string leerkrachtWachtwoord = "Leerkracht123!";

    var leerkrachtUser = await userManager.FindByEmailAsync(leerkrachtEmail);
    if (leerkrachtUser == null)
    {
        leerkrachtUser = new IdentityUser
        {
            UserName = leerkrachtEmail,
            Email = leerkrachtEmail,
            EmailConfirmed = true
        };
        var result = await userManager.CreateAsync(leerkrachtUser, leerkrachtWachtwoord);
        if (result.Succeeded)
        {
            await userManager.AddToRoleAsync(leerkrachtUser, "Leerkracht");
        }
    }
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    await SeedRoles(services);
};

app.Run();




