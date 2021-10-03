using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace AtividadeORM.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Conta = new HashSet<Contum>();
        }

        [Required(ErrorMessage = "O código do cliente é obrigatório")]
        public int CodCli { get; set; }

        [Required(ErrorMessage = "O código do tipo do cliente é obrigatório")]
        public int CodTipoCli { get; set; }

        [Required(ErrorMessage = "O nome do cliente é obrigatório")]
        [MaxLength(100,  ErrorMessage = "O tamanho máximo para o nome do cliente é de 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A data de nascimento do cliente é obrigatório")]
        public DateTime DataNascFund { get; set; }

        [Required(ErrorMessage = "A renda/lucro do cliente é obrigatório")]
        public decimal RendaLucro { get; set; }

        [MaxLength(1, ErrorMessage = "O tamanho máximo para o nome do cliente é de 1 caracter é M ou F")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "O e-mail do cliente é obrigatório")]
        [MaxLength(50, ErrorMessage = "O tamanho máximo para o email do cliente é de 50 caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O endereço do cliente é obrigatório")]
        [MaxLength(200, ErrorMessage = "O tamanho máximo para o endereço do cliente é de 200 caracteres")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "O documento do cliente é obrigatório")]
        [MaxLength(18, ErrorMessage = "O tamanho máximo para o nome do cliente é de 18 caracteres")]
        public string Documento { get; set; }

        [MaxLength(50, ErrorMessage = "O tamanho máximo para o tipo empresa do cliente é de 50 caracteres")]
        public string TipoEmpresa { get; set; }

        public virtual TipoCli CodTipoCliNavigation { get; set; }
        public virtual ICollection<Contum> Conta { get; set; }
    }
}
