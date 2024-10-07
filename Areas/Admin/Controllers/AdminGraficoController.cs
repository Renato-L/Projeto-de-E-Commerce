using Microsoft.AspNetCore.Mvc;
using PaginaLanches.Areas.Admin.Servicos;

namespace PaginaLanches.Areas.Admin.Controllers;

[Area("Admin")]
public class AdminGraficoController : Controller
{
    private readonly GraficoVendasService _graficoVendas;

    public AdminGraficoController(GraficoVendasService graficoVendas)
    {
        _graficoVendas = graficoVendas ?? throw new ArgumentNullException(nameof(graficoVendas));
    }

    public JsonResult VendasLanches(int dias)
    {
        var lanchesVendasTotais = _graficoVendas.GetVendasLanche(dias);

        return Json(lanchesVendasTotais);
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult VendasMensal()
    {
        return View();
    }

    [HttpGet]
    public IActionResult VendasSemanal()
    {
        return View();
    }

}
