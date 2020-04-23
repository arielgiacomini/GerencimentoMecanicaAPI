using SGM.Domain.Entities;
using SGM.Domain.Entities.Orcamentos;
using SGM.Domain.Utils;
using SGM.Infrastructure.Context;
using SGM.Infrastructure.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SGM.Infrastructure.Repositories.Repository
{
    public class OrcamentoRepository : IOrcamentoRepository
    {
        private readonly SGMContext _SGMContext;

        public OrcamentoRepository(SGMContext sgmContext)
        {
            _SGMContext = sgmContext;
        }

        public IEnumerable<Orcamento> GetByAll()
        {
            return _SGMContext.Orcamento.ToList();
        }

        public Count GetCount()
        {
            var contagem = _SGMContext.Orcamento.Count();

            Count cont = new Count();
            {
                cont.Contagem = contagem;
            }

            return cont;
        }

        public Orcamento GetById(int orcamentoId)
        {
            return _SGMContext.Orcamento.Where(x => x.OrcamentoId == orcamentoId).FirstOrDefault();
        }

        public void Salvar(Orcamento entidade)
        {
            _SGMContext.Orcamento.Add(entidade);
            _SGMContext.SaveChanges();
        }

        public void Atualizar(Orcamento entidade)
        {
            var orcamento = GetById(entidade.OrcamentoId);
            orcamento.ClienteId = entidade.ClienteId;
            orcamento.VeiculoId = entidade.VeiculoId;
            orcamento.Descricao = entidade.Descricao;
            orcamento.ValorAdicional = entidade.ValorAdicional;
            orcamento.PercentualDesconto = entidade.PercentualDesconto;
            orcamento.ValorDesconto = entidade.ValorDesconto;
            orcamento.ValorTotal = entidade.ValorTotal;
            orcamento.StatusId = entidade.StatusId;
            orcamento.Ativo = entidade.Ativo;

            _SGMContext.Update(orcamento);
            _SGMContext.SaveChanges();
        }

        public IEnumerable<ClienteOrcamentoList> GetByAllPaginado(int page)
        {
            var clienteOrcamentos =
                _SGMContext
                .Cliente
                .GroupJoin(
                        _SGMContext
                        .Orcamento, s => s.ClienteId, f => f.ClienteId,
                        (f, orcamentosCliente) => new ClienteOrcamentoList
                        {
                            Orcamentos = orcamentosCliente,
                            ClienteId = f.ClienteId,
                            NomeCliente = f.NomeCliente,
                            Apelido = f.Apelido,
                            DocumentoCliente = f.DocumentoCliente,
                            Sexo = f.Sexo,
                            EstadoCivil = f.EstadoCivil,
                            DataNascimento = f.DataNascimento,
                            Email = f.Email,
                            TelefoneFixo = f.TelefoneFixo,
                            TelefoneCelular = f.TelefoneCelular,
                            TelefoneOutros = f.TelefoneOutros,
                            LogradouroCEP = f.LogradouroCEP,
                            LogradouroNome = f.LogradouroNome,
                            LogradouroNumero = f.LogradouroNumero,
                            LogradouroComplemento = f.LogradouroComplemento,
                            LogradouroMunicipio = f.LogradouroMunicipio,
                            LogradouroBairro = f.LogradouroBairro,
                            LogradouroUF = f.LogradouroUF,
                            RecebeNotificacoes = f.RecebeNotificacoes,
                            ClienteAtivo = f.ClienteAtivo,
                            DataAlteracao = f.DataAlteracao
                        });

            return clienteOrcamentos.Skip((page - 1) * 5).Take(5).ToList();
        }
    }
}
