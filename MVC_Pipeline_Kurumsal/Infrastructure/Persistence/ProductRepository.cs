// Path: EnterpriseOrderProductApp.Infrastructure.Persistence.ProductRepository.cs
// Type: Class
// Implements: IProduct
// Pattern: Repository (OOP)
// Purpose: Product entity’si için veri erişim işlemlerini gerçekleştirir.
// SOLID: DIP – IProduct interface’ine bağlıdır.
// AOP Etkileşimi: ProductService → Add() çağrısı interceptor ile loglanır.

using MVC_Pipeline_Kurumsal.Domain.Entities;
using MVC_Pipeline_Kurumsal.Domain.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MVC_Pipeline_Kurumsal.Infrastructure.Persistence
{
    public class ProductRepository 
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        // public void Add(Product product) => _context.Products.Add(product);
        public void Add(Product product)
        {
            _context.Products.Add(product); // Ürün nesnesi EF context'e eklenir
            _context.SaveChanges();         // Değişiklikler veri tabanına yazılır
        }

        // Diğer CRUD metotları...
        public void Update(Product product) => _context.Entry(product).State = EntityState.Modified;
        public void Delete(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null) _context.Products.Remove(product);
        }

        public Product GetById(int id) => _context.Products.Find(id);
        public IEnumerable<Product> GetAll() => _context.Products.ToList();
    }
}
