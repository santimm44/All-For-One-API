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

//configuring cors policy for unrestricted access
//this code will allow anyone with the link to access the endpoints
builder.Services.AddCors(Options => {
    Options.AddPolicy("AllowAll", 
    policy =>
    {
        //allows access from any origin
        //allows any http request a.k.a httpget, httppost, httpput et cetera
        //Allows any header
        policy.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//call the policy
app.UseCors("AllowAll");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
