var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/ready", () =>
{
    Console.WriteLine("Payment Service is ready");
    return true;
});

app.MapGet("/commit", () =>
{
    Console.WriteLine("Payment Service is commited");
    return true;
});

app.MapGet("/rollback", () =>
{
    Console.WriteLine("Payment Service is rollbacked");
});


app.Run();
