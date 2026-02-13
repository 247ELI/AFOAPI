using AFOAPI.Services;

var builder = WebApplication.CreateBuilder(args);

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

// Add CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Enable CORS
app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
