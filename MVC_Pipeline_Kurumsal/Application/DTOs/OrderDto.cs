// Path: EnterpriseOrderProductApp.Application.DTOs.OrderDto.cs
// Type: Class
// Purpose: UI’dan gelen sipariş verisini taşır ve Entity’ye dönüştürür.
// SOLID: SRP – Sadece veri taşıma ve dönüşüm sorumluluğu taşır.
using MVC_Pipeline_Kurumsal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Pipeline_Kurumsal.Application.DTOs
{
    public class OrderDto
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public Order ToEntity()
        {
            return new Order
            {
                ProductId = this.ProductId,
                Quantity = this.Quantity,
                CustomerName = this.CustomerName,
                CustomerEmail = this.CustomerEmail,
                TotalPrice = 0 // Service içinde hesaplanabilir
            };
        }
    }
}