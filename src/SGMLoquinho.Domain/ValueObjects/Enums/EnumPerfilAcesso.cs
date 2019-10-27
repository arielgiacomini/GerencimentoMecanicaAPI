using System.ComponentModel;

namespace SGMLoquinho.Domain.ValueObjects.Enums
{
    public enum EnumPerfilAcesso : short
    {
        [Description("Sem acesso")]
        SemAcesso = 0,

        [Description("Administrador")]
        Admin = 1,

        [Description("Supervisão")]
        Supervisao = 2,

        [Description("Básico c/ Visualizações dados Sensíveis")]
        BasicoComVisualizacoesSensiveis = 3,

        [Description("Básico c/ Visualizações dados Sensíveis porém os adiciona")]
        BasicoComVisualizacoesSensiveisComAdd = 4,

        [Description("Básico s/ Visualizações dados Sensíveis")]
        BasicoSemVisualizacoesSensiveis = 5,

        [Description("Básico s/ Visualizações dados Sensíveis porém os adiciona")]
        BasicoSemVisualizacoesSensiveisComAdd = 6,
    }
}
