var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/ready", () =>
{
    Console.WriteLine("Order Service is ready");
    return true;
});

app.MapGet("/commit", () =>
{
    Console.WriteLine("Order Service is commited");
    return true;
});

app.MapGet("/rollback", () =>
{
    Console.WriteLine("Order Service is rollbacked");
});


app.Run();
