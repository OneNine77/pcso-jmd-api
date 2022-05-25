var builder = WebApplication.CreateBuilder(args);
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

var app = builder.Build();
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseHttpsRedirection();

app.MapGet("Hello", () => "This is very cool I Hope");
app.MapGet("Product", () => "Get some product in Azure SQL");


app.Run();

