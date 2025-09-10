// Path: EnterpriseOrderProductApp.Infrastructure.Persistence.OrderRepository.cs
// Type: Class
// Implements: IOrderService (veri erişim değil, servis çağrısı için kullanılır)
// Pattern: Repository (OOP)
// Purpose: Order entity’si için veri erişim işlemlerini gerçekleştirir.
// SOLID: DIP – IOrderService üzerinden çağrılır.
// AOP Etkileşimi: OrderService → Create() çağrısı interceptor ile loglanır.

using MVC_Pipeline_Kurumsal.Domain.Entities;
using MVC_Pipeline_Kurumsal.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MVC_Pipeline_Kurumsal.Infrastructure.Persistence
{
    public class OrderRepository
    {
        private readonly AppDbContext _context;

        public OrderRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Order order) => _context.Orders.Add(order);
        public Order GetById(int id) => _context.Orders.Find(id);
        public IEnumerable<Order> GetAll() => _context.Orders.ToList();
        public void Cancel(int id)
        {
            var order = _context.Orders.Find(id);
            if (order != null) _context.Orders.Remove(order);
        }
    }
}
