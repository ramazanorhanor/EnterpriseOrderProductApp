// Path: EnterpriseOrderProductApp.Domain.Interfaces.IProduct.cs
// Type: Interface
// Pattern: Repository Interface (OOP)
// Purpose: Product entity’si için temel veri erişim operasyonlarını soyutlar.
// SOLID: ISP – Sadece Product’a özel operasyonları içerir.
// AOP Etkileşimi: ProductService içinde çağrıldığında, LoggingInterceptor tarafından methodlar loglanır.

using MVC_Pipeline_Kurumsal.Domain.Entities;
using System.Collections.Generic;

namespace MVC_Pipeline_Kurumsal.Domain.Interfaces
{
    //public interface IProduct
    //{
    //    Product GetById(int id);
    //    IEnumerable<Product> GetAll();
    //    void Add(Product product);
    //    void Update(Product product);
    //    void Delete(int id);
    //}
}
