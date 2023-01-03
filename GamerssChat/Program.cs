using GamerssChat.Repositories;
using GamerssChat.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddControllersWithViews();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMvc();
builder.Services.AddRazorPages();


//builder.Services.AddScoped<NewsService>();
//builder.Services.AddScoped<NewsRepository>();
//builder.Services.AddScoped<CartService>();
//builder.Services.AddScoped<CartRepository>();
//builder.Services.AddScoped<PostCommentService>();
//builder.Services.AddScoped<PostCommentRepository>();
//builder.Services.AddScoped<PostService>();
//builder.Services.AddScoped<PostRepository>();
//builder.Services.AddScoped<ProductCommentService>();
//builder.Services.AddScoped<ProductCommentRepository>();
//builder.Services.AddScoped<ProductService>();
//builder.Services.AddScoped<ProductRepository>();
//builder.Services.AddScoped<ProductService>();
//builder.Services.AddScoped<ProductRepository>();
//builder.Services.AddScoped<UserService>();
//builder.Services.AddScoped<UserRepository>();

builder.Services.AddDbContext<GamersChatDbContext>(options => 
    options.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("v1/swagger.json", "My API V1");
        c.InjectStylesheet("/swagger-ui/SwaggerDark.css");
    });
}
else
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapRazorPages();

//app.MapFallbackToFile("index.html"); ;

app.Run();
