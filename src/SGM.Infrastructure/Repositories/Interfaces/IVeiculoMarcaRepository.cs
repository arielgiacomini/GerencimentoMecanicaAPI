using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.Infrastructure.Repositories.Interfaces
{
    public interface IVeiculoMarcaRepository
    {
        VeiculoMarca GetById(int marcaId);
        IList<VeiculoMarca> GetMarcasByAll();
    }
}