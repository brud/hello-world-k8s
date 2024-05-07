var builder = WebApplication.CreateSlimBuilder(args);

var app = builder.Build();

var apiV1Group = app.MapGroup("/api/v1");
apiV1Group.MapGet("/", () => "online");
apiV1Group.MapGet("/hello", (HttpContext context) => $"Hello, world! {context.Connection.LocalIpAddress}");
app.Run();