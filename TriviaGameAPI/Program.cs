using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.Diagnostics;
using System.Text.Json.Serialization;
using TriviaGameAPI.DAL.Repositories;
using TriviaGameAPI.Hubs;

namespace TriviaGameAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddSignalR();

            builder.Services.AddDbContext<TriviaGameDBContext>(optionsAction: dbCtxOption =>
            {
                dbCtxOption.LogTo(str => Debug.WriteLine(str))
                           .UseSqlServer(builder.Configuration["ConnectionStrings:TriviaGameDB"]);
            }, contextLifetime: ServiceLifetime.Scoped, optionsLifetime: ServiceLifetime.Singleton);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();


            app.UseRouting();

            app.UseAuthorization();
            app.MapControllers();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<MultiplayerHub>("/trivia");
            });

            app.Run();
        }
    }
}