using System;
using System.Collections.Generic;

#nullable disable

namespace AtividadeWebAPI.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Conta = new HashSet<Contum>();
        }

        public int CodCli { get; set; }
        public int CodTipoCli { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascFund { get; set; }
        public decimal RendaLucro { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Documento { get; set; }
        public string TipoEmpresa { get; set; }

        public virtual TipoCli CodTipoCliNavigation { get; set; }
        public virtual ICollection<Contum> Conta { get; set; }
    }
}
