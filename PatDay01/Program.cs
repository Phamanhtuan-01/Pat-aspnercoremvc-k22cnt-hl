var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World! - Phạm Anh Tuấn - 2210900073");

app.Run();
