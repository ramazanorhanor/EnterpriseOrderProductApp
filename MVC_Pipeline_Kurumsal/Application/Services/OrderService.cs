// Path: EnterpriseOrderProductApp.Application.Services.OrderService.cs
// Type: Class
// Implements: IOrderService
// Pattern: Service Layer (OOP), Intercepted (AOP)
// Purpose: Siparişle ilgili iş mantığını taşır. LoggingInterceptor + AuditInterceptor ile sarılır.
// SOLID: SRP – Sadece sipariş işlemleriyle ilgilenir. DIP – Interface’e bağımlıdır.
// AOP Etkileşimi: Create() methodu hem loglanır hem auditlenir.

using MVC_Pipeline_Kurumsal.Domain.Entities;
using MVC_Pipeline_Kurumsal.Infrastructure.Persistence;
using MVC_Pipeline_Kurumsal.Domain.Interfaces;

namespace MVC_Pipeline_Kurumsal.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly ILogService _logger;
        private readonly OrderRepository _orderRepository;

        public OrderService(OrderRepository orderRepository, ILogService logger)
        {
            _orderRepository = orderRepository;
            _logger = logger;
        }

        public void Create(Order order)
        {
            _logger.Info($"OrderService.Create() çağrıldı: {order.CustomerName}");
            _orderRepository.Add(order);
        }

        public Order GetById(int id) => _orderRepository.GetById(id);
        public void Cancel(int id) => _orderRepository.Cancel(id);
    }
}
