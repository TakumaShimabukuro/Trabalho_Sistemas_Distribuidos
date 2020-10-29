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
    public class ClienteController : ControllerBase
    {
        private readonly IData<Cliente> Context;

        public ClienteController()
        {
            Context = new ClienteDao();
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
                    s.Documento,
                    s.Endereco,
                    s.Telefone,
                }));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}