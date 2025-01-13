using All_For_One_API.services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Adding all services into scope
builder.Services.AddScoped<HelloWorldService>();
builder.Services.AddScoped<AskingQuestionsService>();
builder.Services.AddScoped<AddingTwoNumbersService>();
builder.Services.AddScoped<MadlibService>();
builder.Services.AddScoped<OddOrEvenService>();
builder.Services.AddScoped<ReverseItAlphanumericService>();
builder.Services.AddScoped<ReverseItNumbersOnlyService>();
builder.Services.AddScoped<Magic8BallService>();
builder.Services.AddScoped<GuessItService>();
builder.Services.AddScoped<RestaurantPickerService>();

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
