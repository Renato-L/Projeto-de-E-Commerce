using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PaginaLanches.Models;
using PaginaLanches.Repositories.Interfaces;
using PaginaLanches.ViewModels;

namespace PaginaLanches.Controllers;

public class CarrinhoCompraController : Controller
{
    private readonly ILancheRepository _lancheRepository;
    private readonly CarrinhoCompra _carrinhoCompra;

    public CarrinhoCompraController(ILancheRepository lancheRepository, CarrinhoCompra carrinhoCompra)
    {
        _lancheRepository = lancheRepository;
        _carrinhoCompra = carrinhoCompra;
    }

    public IActionResult Index()
    {
        var itens = _carrinhoCompra.GetCarrinhoCompraItens();
        _carrinhoCompra.CarrinhoCompraItems = itens;

        var carrinhoCompraVM = new CarrinhoCompraViewModel
        {
            CarrinhoCompra = _carrinhoCompra,
            CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
        };

        return View(carrinhoCompraVM);
    }

    [Authorize]
    public IActionResult AdicionarItemNoCarrinhoCompra(int lancheId)
    {
        var lancheSelecionado = _lancheRepository.Lanches.FirstOrDefault(c => c.LancheId == lancheId);

        if (lancheSelecionado != null)
        {
            _carrinhoCompra.AdicionarAoCarrinho(lancheSelecionado);
        }

        return RedirectToAction("Index");
    }

    [Authorize]
    public IActionResult RemoverItemDoCarrinhoCompra(int lancheId)
    {
        var lancheSelecionado = _lancheRepository.Lanches.FirstOrDefault(c => c.LancheId == lancheId);

        if (lancheSelecionado != null)
        {
            _carrinhoCompra.RemoverDoCarrinho(lancheSelecionado);
        }

        return RedirectToAction("Index");
    }
}
