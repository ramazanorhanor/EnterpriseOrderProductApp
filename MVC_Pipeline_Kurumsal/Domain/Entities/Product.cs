// Path: EnterpriseOrderProductApp.Domain.Entities.Product.cs
// Type: Class
// Pattern: Entity (OOP)
// Purpose: Ürün verisini temsil eder. EF 6.2 ile DB tablosuna karşılık gelir.
// SOLID: SRP – Sadece veri taşıma sorumluluğu vardır.
// AOP Etkileşimi: Doğrudan AOP ile etkileşimi yoktur. Ancak ProductService üzerinden dolaylı olarak interceptor ile loglanır.

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Pipeline_Kurumsal.Domain.Entities
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
