using Microsoft.EntityFrameworkCore;
using HopitalAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Ajouter DbContext avec SQLite
builder.Services.AddDbContext<HopitalDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Initialiser la base de donn�es
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<HopitalDbContext>();
    context.Database.EnsureCreated(); // Cr�e automatiquement la base de donn�es si elle n'existe pas
    DbInitializer.Initialize(context);

}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
