using Microsoft.EntityFrameworkCore;
using SGM.Domain.Entities;
using SGM.Infrastructure.Context;
using SGM.Infrastructure.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SGM.Infrastructure.Repositories.Repository
{
    public class VeiculoMarcaRepository : IVeiculoMarcaRepository
    {
        private readonly SGMContext _SGMContext;

        public VeiculoMarcaRepository(SGMContext SGMContext)
        {
            _SGMContext = SGMContext;
        }

        public VeiculoMarca GetById(int marcaId)
        {
            return _SGMContext.VeiculoMarca.AsNoTracking().Where(marca => marca.MarcaId == marcaId).FirstOrDefault();
        }

        public IList<VeiculoMarca> GetMarcasByAll()
        {
            return _SGMContext.VeiculoMarca.AsNoTracking().ToList();
        }
    }
}