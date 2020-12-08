using SGM.Domain.Entities;
using SGM.Domain.Utils;
using System.Collections.Generic;

namespace SGM.Infrastructure.Repositories.Interfaces
{
    public interface IServicoRepository
    {
        IEnumerable<Servico> GetServicoByAll();
        Count GetServicoCount();
        Servico GetServicoById(int servicoId);
        int SalvarServico(Servico model);
        void AtualizarServico(Servico model);
        int SalvarServicoMaodeObra(ServicoMaodeObra servicoMaodeObra);
        int SalvarServicoPeca(ServicoPeca servicoPeca);
        void DeletarServicoMaodeObra(ServicoMaodeObra servicoMaodeObra);
        void DeletarServicoPeca(ServicoPeca servicoPeca);
        IList<ServicoMaodeObra> GetServicoMaodeObraByServicoId(int servicoId);
        IList<ServicoPeca> GetServicoPecaByServicoId(int servicoId);
        IList<Servico> GetUltimosServico(int quantidade);
        IList<Servico> GetServicoByClienteVeiculoId(int clienteVeiculoId);
    }
}