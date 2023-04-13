using hotel_management_api.Models;
using hotel_management_api.Seeder;
using Microsoft.EntityFrameworkCore;

namespace hotel_management_api.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }


        #region User
        public DbSet<User> users { get; set; }
        #endregion

        #region HotelRoom
        public DbSet<HotelRoom> hotel_rooms { get; set; }
        #endregion

        #region Customer
        public DbSet<Customer> customers { get; set; }
        #endregion

        #region Booking
        public DbSet<Booking> bookings { get; set; }
        #endregion


        public static void UpdateDatabase(DatabaseContext context)
        {
            context.Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var sqlConnection = "Server=localhost;Port=3306;Database=hotel_management;Uid=root;Pwd=;MaximumPoolSize=500;";
                optionsBuilder.UseMySql(sqlConnection,
                    MySqlServerVersion.LatestSupportedServerVersion);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region User
            new UserSeeder(modelBuilder).SeedData();
            #endregion

            #region HotelRoomSeeder
            new HotelRoomSeeder(modelBuilder).SeedData();
            #endregion

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DatabaseContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}