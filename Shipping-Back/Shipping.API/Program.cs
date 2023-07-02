using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Shipping.DAL.Data;
using Shipping.DAL.Data.Models;
using System.Text;
using Microsoft.Extensions.Configuration;
using Shipping.BLL.Managers;
using Shipping.DAL.Repositories;
using Shipping.DAL;
using Shipping.BLL;
using System.Security.Claims;
using Shipping.API.Filters;

namespace Shipping.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            #region Default

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            #endregion

            #region Database

            var connectionstring = builder.Configuration.GetConnectionString("Shipping");
            builder.Services.AddDbContext<ShippingContext>(option => option.UseSqlServer(connectionstring));
           
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
                            {
                                options.User.RequireUniqueEmail = true;
                            })

                           .AddEntityFrameworkStores<ShippingContext>()
                           .AddDefaultTokenProviders();

           

            #endregion


           
           

            #region Repositories
         
         
			builder.Services.AddScoped(typeof(IRepository<>), typeof(TRepository<>));
            builder.Services.AddScoped<IOrderRepository, OrderRepository>();
            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddScoped<IGroupPermissionsRepository, GroupPermissionsRepository>();
            builder.Services.AddScoped<ISpecialPricesRepository, SpecialPricesRepository>();
            builder.Services.AddScoped<IRepresentativeGovernatesRepository, RepresentativeGovernatesRepository>();

            #endregion

            #region Managers
            builder.Services.AddScoped<IAccountManager, AccountManager>();
            builder.Services.AddScoped<IBranchManager, BranchManager>();
            builder.Services.AddScoped<IGovernorateManager, GovernorateManager>();
            builder.Services.AddScoped<ICityManager, CityManager>();
            builder.Services.AddScoped<IEmployeeManager, EmployeeManager>();
            builder.Services.AddScoped<IMerchantManager, MarchentManager>();
            builder.Services.AddScoped<IRepresentativeManager, RepresentativeManager>();
            builder.Services.AddScoped<IGroupPermissionManager, GroupPermissionManager>();
            builder.Services.AddScoped<IGroupManager, GroupManager>();
            builder.Services.AddScoped<IOrderManager, OrderManager>();
            builder.Services.AddScoped<IReasonsRefusalTypeManager, ReasonsRefusalTypeManager>();
            builder.Services.AddScoped<IWeightsManager, WeightsManager>();
            builder.Services.AddScoped<IShippingTypeManager, ShippingTypeManager>();
            builder.Services.AddScoped<IDeliverToVillageManager, DeliverToVillageManager>();





            #endregion

            builder.Services.AddScoped<GpAttribute>();
            #region Authentication Scheme

            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = "Bearer";
                options.DefaultChallengeScheme = "Bearer";
            }).AddJwtBearer("Bearer", options =>
            {

                var secretKey = Encoding.ASCII.GetBytes(builder.Configuration.GetSection("SecretKey").Value ?? string.Empty);
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,                 
                    IssuerSigningKey = new SymmetricSecurityKey(secretKey),
                };
            });
            #endregion

            #region Policies
            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("MerchantOnly", policy => policy
                    .RequireClaim(ClaimTypes.Role, "Merchant")
                    .RequireClaim(ClaimTypes.NameIdentifier));
                
               options.AddPolicy("RepresentativeOnly", policy => policy
                    .RequireClaim(ClaimTypes.Role, "Representative")
                    .RequireClaim(ClaimTypes.NameIdentifier));
            });

            #endregion

            #region CORS

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowLocalhost", builder =>
                {
                    builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
                });
            });

            #endregion

            var app = builder.Build();
            app.UseCors("AllowLocalhost");

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}