// Path: EnterpriseOrderProductApp.Web.Controllers.OrderController.cs
// Type: Class
// Pattern: MVC Controller
// Purpose: Sipariş işlemlerini yönetir. AOP attribute’lar ile genişletilir.
// SOLID: SRP – Sadece siparişle ilgili HTTP işlemlerini yönetir.
// AOP Etkileşimi: [LogAction] ile loglanır, [Permission] ile yetki kontrolü yapılır.

using System.Web.Mvc;
using MVC_Pipeline_Kurumsal.Application.Services;
using MVC_Pipeline_Kurumsal.Application.DTOs;
using MVC_Pipeline_Kurumsal.Attributes;

namespace MVC_Pipeline_Kurumsal.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrderService _orderService;

        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        [LogAction]
        [Permission("User")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [LogAction]
        [Permission("User")]
        public ActionResult Create(OrderDto dto)
        {
            if (!ModelState.IsValid) return View(dto);

            _orderService.Create(dto.ToEntity());
            return RedirectToAction("Index");
        }
    }
}