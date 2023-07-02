using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shipping.DAL.Data.Models;

namespace Shipping.DAL.Data
{
	public class ShippingContext : IdentityDbContext<ApplicationUser>
	{
		
		public DbSet<Governorate> Governorates => Set<Governorate>();
		public DbSet<City> Cities => Set<City>();
		public DbSet<ShippingType> ShippingTypes => Set<ShippingType>();
		public DbSet<Branch> Branches => Set<Branch>();
		public DbSet<Product> Products => Set<Product>();
		public DbSet<Order> Orders => Set<Order>();
		public DbSet<Permission> Permissions => Set<Permission>();
		public DbSet<Group> Groups => Set<Group>();
		public DbSet<SpecialPrice> SpecialPrices => Set<SpecialPrice>();
		public DbSet<GroupPermission> GroupPermissions => Set<GroupPermission>();
        public DbSet<DeliverToVillage> DeliverToVillages => Set<DeliverToVillage>();
        public DbSet<Weight> Weights => Set<Weight>();
        public DbSet<RepresentativeGovernate> RepresentativeGovernates => Set<RepresentativeGovernate>();
        public DbSet<ReasonsRefusalType> ReasonsRefusalTypes => Set<ReasonsRefusalType>();
        public ShippingContext(DbContextOptions options) : base(options)
		{


		}

        List<Permission> permissions = new List<Permission>()
        {
            new Permission()
            {
                Id = 1,
                Name="Branch"

            },
            new Permission()
            {
                Id = 2,
                Name = "City"
               
            },
             new Permission()
            {
                Id =3 ,
                Name = "Governorate"

            }
            , new Permission()
            {
                Id = 4,
                Name = "Employee"

            }, new Permission()
            {
                Id = 5,
                Name = "Representative"

            }, new Permission()
            {
                Id = 6,
                Name = "Merchant"

            },
             new Permission()
            {
                Id = 7,
                Name = "Order"

            },
              new Permission()
            {
                Id = 8,
                Name = "OrderReports"

            },
              new Permission()
            {
                Id = 9,
                Name = "Group"
            },
            new Permission()
            {
                Id = 10,
                Name = "ReasonsRefusalType"

            },
           new Permission()
            {
                Id = 11,
                Name = "ShippingType"
            },
           new Permission()
            {
                Id = 12,
                Name = "DeliverToVillage"
            },
            new Permission()
            {
                Id = 13,
                Name = "Weight"
            },



        };

        Weight weight = new Weight()
        {
            Id = 1,
            DefaultWeight = 10,
            AdditionalPrice = 5
        };

        DeliverToVillage deliverToVillage = new DeliverToVillage()
        {
            Id = 1,
            AdditionalCost = 10
        };
        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            modelBuilder.Entity<Permission>().HasData(permissions);
            modelBuilder.Entity<Weight>().HasData(weight);
            modelBuilder.Entity<DeliverToVillage>().HasData(deliverToVillage);
            base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<ApplicationUser>()
				.HasDiscriminator<string>("UserType")
				.HasValue<Merchant>("Merchant")
				.HasValue<Employee>("Employee")
				.HasValue<Representative>("Representative");

			modelBuilder.Entity<SpecialPrice>()
		   .HasOne(s => s.Governorate)
		   .WithMany(g => g.SpecialPrices)
		   .HasForeignKey(s => s.GovernorateId)
		   .OnDelete(DeleteBehavior.Restrict);

			modelBuilder.Entity<Order>()
			   .HasOne(o => o.Governorate)
			   .WithMany(g => g.Orders)
			   .HasForeignKey(o => o.GovernorateId)
			   .OnDelete(DeleteBehavior.Restrict);

		    modelBuilder.Entity<Branch>()
			   .HasMany(b => b.Orders).WithOne(c => c.Branch)

		.OnDelete(DeleteBehavior.Restrict);


			modelBuilder.Entity<Group>()
			   .HasMany(g => g.GroupPermissions)
			   .WithOne(gp => gp.Group)
			   .HasForeignKey(gp => gp.GroupId);

			modelBuilder.Entity<Permission>()
				.HasMany(p => p.GroupPermissions)
				.WithOne(gp => gp.Permission)
				.HasForeignKey(gp => gp.PermissionId);


            modelBuilder.Entity<Group>()
              .HasMany(g => g.Employees)
              .WithOne(e => e.Group)
              .HasForeignKey(e => e.GroupId);
        }

	}
}
