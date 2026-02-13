using AFOAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<AddTwoNumbersService>();
builder.Services.AddScoped<AskQuestionsService>();
builder.Services.AddScoped<GuessItService>();
builder.Services.AddScoped<HelloWorldService>();
builder.Services.AddScoped<MadLibService>();
builder.Services.AddScoped<Magic8BallService>();
builder.Services.AddScoped<OddOrEvenService>();
builder.Services.AddScoped<RestaurantPickerService>();
builder.Services.AddScoped<ReverseItAlphanumericService>();
builder.Services.AddScoped<ReverseItNumbersService>();

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
