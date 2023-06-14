using ElevenNote.Data.ElevenNoteContext;
using ElevenNote.Data.Entities;
using ElevenNote.Services.CategoryServices;
using ElevenNote.Services.Configurations;
using ElevenNote.Services.NoteServices;
using ElevenNote.Services.UserServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ElevenNoteDBContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddIdentityCore<UserEntity>().AddRoles<IdentityRole>().AddEntityFrameworkStores<ElevenNoteDBContext>();
builder.Services.AddAutoMapper(typeof(MappingConfigurations));
builder.Services.AddHttpContextAccessor();

builder.Services.AddScoped<INoteService,NoteService>();
builder.Services.AddScoped<ICategoryService,CategoryService>();
builder.Services.AddScoped<IAuthenticationManager,AuthenticationManager>();

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
