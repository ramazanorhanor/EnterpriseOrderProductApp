// Path: EnterpriseOrderProductApp.Domain.Interfaces.IOrderService.cs
// Type: Interface
// Pattern: Service Interface (OOP)
// Purpose: Sipariş işlemlerinin iş mantığını soyutlar.
// SOLID: DIP – Controller, bu interface’e bağımlıdır; somut sınıfa değil.
// AOP Etkileşimi: OrderService.Create() methodu, LoggingInterceptor ve AuditInterceptor tarafından sarılır.

using MVC_Pipeline_Kurumsal.Domain.Entities;

namespace MVC_Pipeline_Kurumsal.Domain.Interfaces
{
    public interface IOrderService
    {
        void Create(Order order);
        Order GetById(int id);
        void Cancel(int id);
    }
}
