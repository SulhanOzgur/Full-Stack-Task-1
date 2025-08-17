using Microsoft.EntityFrameworkCore;
using ProductApi.Data;
using ProductApi.Repositories;
using ProductApi.Services;

var builder = WebApplication.CreateBuilder(args);

// -------------------- Services --------------------

// DbContext (PostgreSQL)
builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseNpgsql(builder.Configuration.GetConnectionString("Default")));

// Katmanlı mimari DI kayıtları
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

// Controllers + Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Frontend için CORS (Next.js: http://localhost:3000)
    builder.Services.AddCors(opt =>
    opt.AddPolicy("frontend",
        p => p.WithOrigins("http://localhost:3000",
        "http://localhost:3001"  )
              .AllowAnyHeader()
              .AllowAnyMethod())); 

// ---------------------------------------------------

var app = builder.Build();

// Swagger sadece Development’ta
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// CORS politikasını etkinleştirdim
app.UseCors("frontend");

app.MapControllers();

app.Run();
