using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseStaticFiles();


app.MapFallbackToFile("sign-in.txt");
app.Run();
