using NoteMe.Data.DataContext;
using NoteMe.Data.Repositories.NotesRepository;
using NoteMe.Processors.ProcessorsFactory;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<IContext, Context>();
builder.Services.AddSingleton<INotesRepository, NotesRepository>();
builder.Services.AddScoped<IProcessorsFactory, ProcessorsFactory>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();