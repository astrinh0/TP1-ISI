using Microsoft.EntityFrameworkCore;
using RestfullAPI.Context.Mappers;
using RestfullAPI.Models;

namespace RestfullAPI.Context
{
    public class DataContext : DbContext

    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Team> Teams { get; set; }
        //public DbSet<Message> Messages { get; set; }

        //public DbSet<Group> Groups { get; set; }

        //public DbSet<GroupMessage> GroupMessages { get; set; }

        //public DbSet<UserMessage> UserMessages { get; set; }

        //public DbSet<GroupUser> GroupUsers { get; set; }

        //public DbSet<File> Files { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("db");
            builder.ApplyConfiguration(new ProductMap());
            //builder.ApplyConfiguration(new MessageMap());
            //builder.ApplyConfiguration(new GroupMap());
            //builder.ApplyConfiguration(new GroupMessageMap());
            //builder.ApplyConfiguration(new UserMessageMap());
            //builder.ApplyConfiguration(new GroupUserMap());
            //builder.ApplyConfiguration(new FileMap());
        }


    }
}
