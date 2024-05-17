using Microsoft.EntityFrameworkCore;
using SignalR_Day_2.Data;
using SignalR_Day_2.Hubs;

namespace SignalR_Day_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddSignalR();
            builder.Services.AddDbContext<ChatContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("conn")));
            builder.Services.AddCors(corsOptions =>
            {
                corsOptions.AddPolicy("MyPolicy", CorsPolicyBuilder =>
                {
                    CorsPolicyBuilder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                }
                );
            });
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseCors("MyPolicy");
            app.UseAuthorization();
            app.MapHub<ChatHub>("/chat");
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=chat}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
