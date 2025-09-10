

// Path: EnterpriseOrderProductApp.Domain.Entities.Order.cs
// Type: Class
// Pattern: Entity (OOP)
// Purpose: Sipariş verisini temsil eder. EF 6.2 ile DB tablosuna karşılık gelir.
// SOLID: SRP – Sadece veri taşıma sorumluluğu vardır.
// AOP Etkileşimi: Doğrudan AOP ile etkileşimi yoktur. Ancak OrderService üzerinden dolaylı olarak interceptor ile loglanır.
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Pipeline_Kurumsal.Domain.Entities
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;

        [MaxLength(250)]
        public string CustomerName { get; set; }

        [MaxLength(250)]
        public string CustomerEmail { get; set; }
    }
}
