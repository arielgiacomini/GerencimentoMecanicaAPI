using System.ComponentModel;

namespace SGM.Domain.Enuns
{
    public enum OrcamentoStatusEnum : byte
    {
        [Description("Orçamento Gerado")]
        OrcamentoGerado = 1,
        [Description("Orçamento Expirado")]
        OrcamentoExpirado = 2,
        [Description("Orçamento Desistido pelo Cliente")]
        OrcamentoDesistido = 3,
        [Description("Orçamento Gerou Ordem de Serviço")]
        OrcamentoGerouServico = 4
    }
}
