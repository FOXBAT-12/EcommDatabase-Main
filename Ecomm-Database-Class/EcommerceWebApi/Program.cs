using Ecomm_Database_Class.Data;
using Ecomm_Database_Class.Repository;
using Ecomm_Database_Class.Repository.IRepository;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ICartOperations, CartOperations>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>();

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
