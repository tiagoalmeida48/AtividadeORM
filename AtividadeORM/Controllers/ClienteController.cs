using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtividadeORM.Models;
using AtividadeORM.Context;
using AtividadeORM.Aplicacao;
using AtividadeORM.Aplicacao;
using AtividadeORM.Models;
using AtividadeORM.Context;

namespace AtividadeORM.Controllers
{
    [Route("banco/cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly BANCOContext _context;
        public ClienteController(BANCOContext context)
        {
            _context = context;
        }
        [HttpGet]
        public List<Cliente> Get()
        {
            ClienteAplicacao objAppCli = new ClienteAplicacao(_context);

            try
            {
                return objAppCli.GetAllClients();
            }
            catch (Exception ex)
            {
                var retorno = new List<Cliente>();
                var cli = new Cliente();
                cli.Nome = ex.Message;
                retorno.Add(cli);
                return retorno;
            }

        }

        [HttpGet("{codCli}")]
        public Cliente Get(int codCli)
        {
            ClienteAplicacao objAppCli = new ClienteAplicacao(_context);
            return objAppCli.GetCliByID(codCli);
        }


        [HttpPost]
        public void Post([FromBody] string value)
        {
        }


        [HttpPut("{CodCli}")]
        public string Put([FromBody] Cliente cli)
        {
            string retorno = "";
            ClienteAplicacao objAppCli = new ClienteAplicacao(_context);

            if (cli.CodCli > 0)
            {
                retorno = objAppCli.AtualizarCliente(cli);
            }
            else
            {
                retorno = objAppCli.InserirCliente(cli);
            }
            return retorno;
        }

        [HttpDelete("{codCli}")]
        public void Delete(int codCli)
        {
            ClienteAplicacao objAppCli = new ClienteAplicacao(_context);
            objAppCli.DeleteClientByCod(codCli);
        }
    }
}