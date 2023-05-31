using HotelManagement_API.Model;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string policyName = "myPolicy";
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddAuthorization();
            builder.Services.AddTransient<IItemComponent, EmpComponent>();
            builder.Services.AddCors((options) =>
            {
                options.AddPolicy(policyName, options =>
                {
                    options.AllowAnyHeader();
                    options.AllowAnyOrigin();
                    options.AllowAnyMethod();
                });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();
            app.MapGet("/MenuItems", ([FromServices] IItemComponent com) =>
            {
                return com.GetItems();
            });

            app.MapGet("/MenuItems/{id}", (int id, IItemComponent com) =>
            {
                return com.GetItem(id);
            });

            app.MapPost("/MenuItems", (DBApproach emp, IItemComponent com) =>
            {
                com.AddItem(emp);
                return "Employee Added Successfully";
            });

            app.Run();
        }
    }
}