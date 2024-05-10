using webchat;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();


//cors para habilitar o front
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins("http://localhost:4200")
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials();
    });
});
var app = builder.Build();

//myhub vai expor o websocket
app.MapHub<MyHub>("/chat");
app.UseCors();

//app.Start();
//app.MapGet("/", () => "Hello World!");

app.Run();

//https://spectacled-falcon-84a.notion.site/SignalR-2defdceddc7a48048f08cfd137df5ce0

