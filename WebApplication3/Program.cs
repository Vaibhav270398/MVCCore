var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
#if DEBUG
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
#endif
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.UseDefaultFiles();	
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
	name:"default",
	pattern:"{controller=Home}/{action=Index}/{id?}"
	);

app.Run();

