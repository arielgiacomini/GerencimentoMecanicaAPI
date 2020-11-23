using SGM.Domain.Entities;

namespace SGM.Infrastructure.Repositories.Interfaces
{
    public interface IVeiculoMarcaRepository
    {
        VeiculoMarca GetById(int marcaId);
    }
}