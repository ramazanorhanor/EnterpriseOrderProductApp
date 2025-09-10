// Path: EnterpriseOrderProductApp.Application.DTOs.ProductDto.cs
// Type: Class
// Purpose: UI’dan gelen ürün verisini taşır ve Entity’ye dönüştürür.
// SOLID: SRP – Sadece veri taşıma ve dönüşüm sorumluluğu taşır.

using MVC_Pipeline_Kurumsal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Pipeline_Kurumsal.Application.DTOs
{
    public class ProductDto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public Product ToEntity()
        {
            return new Domain.Entities.Product
            {
                Name = this.Name,
                Price = this.Price,
                Description = this.Description
            };
        }
    }
}