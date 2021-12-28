using HW27122021.Infrastructure.Repositories.Interfaces;
using HW27122021.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW27122021.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventariosController : ControllerBase
    {
        protected readonly IInventarioRepository inventarioRepository;
        public InventariosController(IInventarioRepository inventarioRepository)
        {
            this.inventarioRepository = inventarioRepository;
        }
        [HttpGet]
        public async Task<IEnumerable<Inventario>> getInventarios()
        {
            return await inventarioRepository.All();
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<Inventario> getInventarioById([FromRoute(Name ="id")]int id)
        {
            return await inventarioRepository.GetById(id);
        }
        [HttpPost]
        public async Task<Inventario> addInventario([FromBody] Inventario inventario) 
        {
            return await inventarioRepository.add(inventario);
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await inventarioRepository.Delete(id);
        }

    }
}
