// Path: EnterpriseOrderProductApp.Web.Controllers.ProductController.cs
// Type: Class
// Pattern: MVC Controller
// Purpose: Ürün işlemlerini yönetir. AOP attribute’lar ile genişletilir.
// SOLID: SRP – Sadece ürünle ilgili HTTP işlemlerini yönetir.
// AOP Etkileşimi: [LogAction] ile loglanır, [Permission] ile yetki kontrolü yapılır.

using System.Web.Mvc;
using MVC_Pipeline_Kurumsal.Application.Services;
using MVC_Pipeline_Kurumsal.Application.DTOs;
using MVC_Pipeline_Kurumsal.Attributes;

namespace MVC_Pipeline_Kurumsal.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [LogAction]
        [Permission("Admin")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [LogAction]
        [Permission("Admin")]
        public ActionResult Create(ProductDto dto)
        {
            if (!ModelState.IsValid) return View(dto);

            _productService.Add(dto.ToEntity());
            return RedirectToAction("Index");
        }
    }
}