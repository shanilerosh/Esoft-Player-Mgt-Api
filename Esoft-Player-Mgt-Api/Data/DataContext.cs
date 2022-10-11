using Esoft_Player_Mgt_Api.Entity;
using Microsoft.EntityFrameworkCore;

namespace Esoft_Player_Mgt_Api.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }


       


        public DbSet<Esoft_Player_Mgt_Api.Entity.Player> Player { get; set; }


        public DbSet<Esoft_Player_Mgt_Api.Entity.Team> Team { get; set; }

    }
}
