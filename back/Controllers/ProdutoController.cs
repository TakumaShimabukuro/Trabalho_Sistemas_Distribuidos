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
    public class ProdutoController : ControllerBase
    {
        private readonly IData<Produto> Context;

        public ProdutoController()
        {
            Context = new ProdutoDao();
        }

        [HttpGet()]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(Context.GetAll().Select(s => new
                {
                    s.Id,
                    s.Nome,
                    s.Quantidade,
                    Valor = s.Valor.ToString("N2"),
                    s.Status
                }));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}