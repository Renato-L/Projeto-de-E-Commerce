using PaginaLanches.Models;

namespace PaginaLanches.Repositories.Interfaces;

public interface IPedidoRepository
{
    void CriarPedido(Pedido pedido);
}
