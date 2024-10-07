using PaginaLanches.Context;
using PaginaLanches.Models;
using PaginaLanches.Repositories.Interfaces;

namespace PaginaLanches.Repositories;

public class PedidoRepository : IPedidoRepository
{
    private readonly AppDbContext _contexto;
    private readonly CarrinhoCompra _carrinhoCompra;

    public PedidoRepository(AppDbContext contexto, CarrinhoCompra carrinhoCompra)
    {
        _contexto = contexto;
        _carrinhoCompra = carrinhoCompra;
    }

    public void CriarPedido(Pedido pedido)
    {
        pedido.PedidoEnviado = DateTime.Now;
        _contexto.Pedidos.Add(pedido);

        _contexto.SaveChanges();

        var carrinhoCompraItens = _carrinhoCompra.CarrinhoCompraItems;

        foreach (var carrinhoItem in carrinhoCompraItens)
        {
            var pedidoDetail = new PedidoDetalhe
            {
                Quantidade = carrinhoItem.Quantidade,
                LancheId = carrinhoItem.Lanche.LancheId,
                PedidoId = pedido.PedidoId,
                Preco = carrinhoItem.Lanche.Preco
            };

            _contexto.PedidoDetalhes.Add(pedidoDetail);
        }

        _contexto.SaveChanges();
    }
}
