// Path: EnterpriseOrderProductApp.Application.Services.ProductService.cs
// Type: Class
// Implements: IProductService
// Pattern: Service Layer (OOP), Intercepted (AOP)
// Purpose: Ürünle ilgili iş mantığını taşır. LoggingInterceptor ile sarılır.
// SOLID: SRP – Sadece ürün işlemleriyle ilgilenir. DIP – Interface’e bağımlıdır.
// AOP Etkileşimi: Tüm methodlar LoggingInterceptor tarafından loglanır.

using MVC_Pipeline_Kurumsal.Domain.Entities;
using MVC_Pipeline_Kurumsal.Domain.Interfaces;
using MVC_Pipeline_Kurumsal.Infrastructure.Persistence;
using System.Collections.Generic;

namespace MVC_Pipeline_Kurumsal.Application.Services
{
    public class ProductService 
    {
        private readonly ILog _logger;
        private readonly ProductRepository _productRepository;

        public ProductService(ProductRepository productRepository, ILog logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }

        public void Add(Product product)
        {
            _logger.Info($"ProductService.Add() çağrıldı: {product.Name}");
            _productRepository.Add(product);
        }

        public void Update(Product product) => _productRepository.Update(product);
        public void Delete(int id) => _productRepository.Delete(id);
        public Product GetById(int id) => _productRepository.GetById(id);
        public IEnumerable<Product> GetAll() => _productRepository.GetAll();
    }
}
