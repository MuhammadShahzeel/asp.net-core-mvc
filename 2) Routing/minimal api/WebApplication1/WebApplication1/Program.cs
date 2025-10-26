var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


// we use minimal api when we want to create lightweight web services with minimal setup and configuration
// we dont need controllers or views, just define endpoints directly in the Program.cs file
app.MapGet("/", () => "Welcome to Minimal API in .NET 8");

app.MapGet("/hello/{name}", (string name) => $"Hello, {name}!");

app.MapPost("/user", (User user) =>
{
return Results.Ok($"User added: {user.Name}, Age: {user.Age}");
});


//  Group related endpoints (best practice for large apps)
var users = app.MapGroup("/users");

users.MapGet("/", () => "Get all users");
users.MapPost("/", () => "Add a new user");
users.MapGet("/{id}", (int id) => $"Get user with ID {id}");

app.Run();

//  Add your models below
public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
}



