using SGM.Domain.Entities;
using SGM.Domain.Utils;
using System.Collections.Generic;

namespace SGM.Infrastructure.Repositories.Interfaces
{
    public interface IServicoRepository
    {
        IEnumerable<Servico> GetByAll();
        Count GetCount();
        Servico GetById(int servicoId);
        void Salvar(Servico model);
        void Atualizar(Servico model);

    }
}