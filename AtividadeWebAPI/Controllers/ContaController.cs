using AtividadeWebAPI.Application;
using AtividadeWebAPI.Context;
using AtividadeWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeWebAPI.Controllers
{
    [Route("banco/conta")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly BANCOContext _context;
        public ClienteController(BANCOContext context)
        {
            _context = context;
        }
        [HttpGet]
        public List<Contum> Get()
        {
            ContaAplication objAppConta = new ContaAplication(_context);

            try
            {
                return objAppConta.GetAllContas();
            }
            catch (Exception ex)
            {
                var retorno = new List<Contum>();
                var conta = new Contum();
                conta.Agencia = ex.Message;
                retorno.Add(conta);
                return retorno;
            }

        }

        [HttpGet("{codConta}")]
        public Contum Get(int codConta)
        {
            ContaAplication objAppConta = new ContaAplication(_context);
            return objAppConta.GetContaByID(codConta);
        }

        [HttpPost]
        public string Post([FromBody] Contum conta)
        {
            ContaAplication objAppConta = new ContaAplication(_context);
            return objAppConta.InserirConta(conta);
        }


        [HttpPut("{CodConta}")]
        public string Put([FromBody] Contum conta)
        {
            ContaAplication objAppConta = new ContaAplication(_context);
            return objAppConta.AtualizarConta(conta);
        }

        [HttpDelete("{codConta}")]
        public string Delete(int codConta)
        {
            ContaAplication objAppConta = new(_context);
            return objAppConta.DeleteContaByCod(codConta);
        }
    }
}