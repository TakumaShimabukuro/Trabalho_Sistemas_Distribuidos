using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoSDQwertyDashboard.Dao;
using ProjetoSDQwertyDashboard.Models;

namespace ProjetoSDQwertyDashboard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IData<Pedido> Context;

        public PedidoController()
        {
            this.Context = new PedidoDao();
        }

        [HttpGet()]
        public IActionResult GetAll()
        {
            try
            {
                var result = this.Context.GetAll();
                return Ok(result.Select(p => new
                {
                    p.Id,
                    Data = p.Data.ToString("dd/MM/yyyy"),
                    Preco = p.Preco.ToString("N2"),
                    p.Status,
                    Produtos = p.Produtos.Select(s => new { 
                       s.Id,
                       s.Nome,
                       Valor = s.Valor.ToString("N2"),
                       s.Quantidade
                    }),
                    Cliente = new
                    {
                        p.Cliente.Id,
                        p.Cliente.Nome
                    }
                }));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}