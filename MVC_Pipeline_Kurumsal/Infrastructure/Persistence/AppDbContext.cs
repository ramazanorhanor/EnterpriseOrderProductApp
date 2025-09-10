// Path: EnterpriseOrderProductApp.Infrastructure.Persistence.AppDbContext.cs
// Type: Class
// Pattern: EF DbContext
// Purpose: EF 6.2 ile veritabanı bağlantısını ve DbSet’leri tanımlar.
// SOLID: SRP – Sadece veritabanı bağlantı ve yapılandırma sorumluluğu taşır.
// AOP Etkileşimi: Doğrudan yok. Repository çağrıları Service üzerinden interceptor ile loglanır.

using System.Data.Entity;
using MVC_Pipeline_Kurumsal.Domain.Entities;

namespace MVC_Pipeline_Kurumsal.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=DefaultConnection") { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
