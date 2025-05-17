using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace Wfrp.Infrastructure.Data
{
    public class WfrpDbContextFactory : IDesignTimeDbContextFactory<WfrpDbContext>
    {
        public WfrpDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<WfrpDbContext>();

            // Remplace cette chaîne de connexion par celle de ton minikube si besoin
            optionsBuilder.UseNpgsql("Host=172.29.109.177;Port=30007;Database=wfrpdb;Username=wfrp;Password=secret");

            return new WfrpDbContext(optionsBuilder.Options);
        }
    }
}
