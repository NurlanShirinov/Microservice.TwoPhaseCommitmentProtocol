var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/ready", () =>
{
    Console.WriteLine("Stock Service is ready");
    return true;
});

app.MapGet("/commit", () =>
{
    Console.WriteLine("Stock Service is commited");
    return true;
});

app.MapGet("/rollback", () =>
{
    Console.WriteLine("Stock Service is rollbacked");
});


app.Run();
