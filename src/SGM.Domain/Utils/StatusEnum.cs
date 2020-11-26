using System.ComponentModel;

namespace SGM.Domain.Enuns
{
    public enum StatusEnum : byte
    {
        [Description("Iniciado - Pendente de Término")]
        IniciadoPendente = 1,
        [Description("Expirado")]
        Expirado = 2,
        [Description("Desistido pelo Cliente")]
        Desistido = 3,
        [Description("Gerou Ordem de Serviço")]
        GerouServico = 4
    }
}