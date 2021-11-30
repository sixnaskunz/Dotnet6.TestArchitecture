var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Declaration of Options Pattern
builder.Services.Configure<PatternOptions>(builder.Configuration.GetSection(PatternOptions.OptionsPattern));
builder.Services.Configure<PatternOptions>(PatternOptions.OptionsPattern, builder.Configuration.GetSection("OptionsPattern:ObjectField"));

builder.Services.Configure<LoggingOptions>(builder.Configuration.GetSection(LoggingOptions.Logging));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();