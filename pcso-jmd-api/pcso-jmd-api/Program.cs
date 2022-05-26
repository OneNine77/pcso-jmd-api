var builder = WebApplication.CreateBuilder(args);
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

var app = builder.Build();
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseHttpsRedirection();

app.MapGet("Hello", () => "This is very cool I Hope");
app.MapGet("Product", () => "Get some product in Azure SQL");

app.MapPost("Product", (Product p) => "Product saved in SQL");
app.MapDelete("Product", (string Name) => "Deleted");
app.MapPost("Chat", (Message msg) => "Message posted to chat SQL");


app.Run();

//Some data contracts

public record class Message(string Name, string Msg);
public record class Product(string Name, string Picture, int Price);


