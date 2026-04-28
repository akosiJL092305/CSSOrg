using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// ---------------- SERVICES ----------------
builder.Services.AddControllers();

// Swagger (always enabled for debugging)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ✅ CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy => policy.AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod());
});

// DB
builder.Services.AddScoped<AppDbContext>();

var app = builder.Build();

// ---------------- MIDDLEWARE ----------------

// 🔥 VERY IMPORTANT: CORS FIRST
app.UseCors("AllowAll");

// Optional but recommended
app.UseHttpsRedirection();

// Swagger (move OUTSIDE environment block)
app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();

app.MapControllers();

app.Run();