using System;

namespace SGM.ApplicationServices.ViewModels
{
    public class ColaboradorViewModel
    {
        public int ColaboradorId { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string NomeCompleto { get; set; }
        public string Apelido { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public DateTime? DataAdmissao { get; set; }
        public DateTime? DataDemissao { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}
