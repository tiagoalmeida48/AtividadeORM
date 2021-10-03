using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace AtividadeWebAPI.Models
{
    public partial class Contum
    {

        public int CodConta { get; set; }

        [Required(ErrorMessage = "O código da agencia é obrigatório")]
        [MaxLength(5, ErrorMessage = "O tamanho máximo para a agencia é de 5 caracteres")]
        public string Agencia { get; set; }

        [Required(ErrorMessage = "O número da conta é obrigatório")]
        [MaxLength(10, ErrorMessage = "O tamanho máximo do número da conta é de 10 caracteres")]
        public string NumeroConta { get; set; }

        [Required(ErrorMessage = "O código do banco é obrigatório")]
        [MaxLength(10, ErrorMessage = "O tamanho máximo do código do banco é de 10 caracteres")]
        public string CodigoBanco { get; set; }

        [Required(ErrorMessage = "O código do cliente é obrigatório")]
        public int CodCli { get; set; }

        [Required(ErrorMessage = "O saldo inicial é obrigatório")]
        public decimal SaldoInicial { get; set; }

        [Required(ErrorMessage = "O saldo atual é obrigatório")]
        public decimal SaldoAtual { get; set; }

        [Required(ErrorMessage = "O código do tipo da conta é obrigatório")]
        public int? CodTipoConta { get; set; }

        public virtual Cliente CodCliNavigation { get; set; }
        public virtual TipoContum CodTipoContaNavigation { get; set; }
    }
}
