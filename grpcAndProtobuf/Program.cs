using grpcAndProtobuf.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGrpc();

var app = builder.Build();

app.MapGrpcService<TextGenerationService>();
app.MapGet("/", () => "gRPC AI server running.");

app.Run();
