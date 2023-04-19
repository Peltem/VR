using System.Runtime.CompilerServices;
using WebApplication3;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<ApplicationContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.MapPost("/bron", (HttpContext context, ApplicationContext context1) =>
{
    var Form = context.Request.Form;
    string FIO = Form["FIO"];
    string Num = Form["num"];
    DateOnly date = DateOnly.Parse(Form["date"]);
    DateTime time = DateTime.Parse(Form["time"]);
    context1.Bron.Add(new Brons { Name = FIO, date=date, Number = Num, DateTime = time });
    context1.SaveChanges();
    return Results.Ok("Я ебал твою маму");
});
app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
