using backendcflopes.Data;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using backendcflopes.ViewModels;
using backendcflopes.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.ConstrainedExecution;


namespace backendcflopes.Controllers
{
    [ApiController]
    [Route(template: "v1")]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        [Route(template: "clientes")]
        public async Task<IActionResult> GetAsync([FromServices] AppDbContext context)
        {

            var clientes = await context
            .Clientes
            .AsNoTracking()
            .ToListAsync();
            return Ok(clientes);
        }

        [HttpGet]
        [Route(template: "clientes/{id}")]
        public async Task<IActionResult> GetBayIdAsync([FromServices] AppDbContext context, [FromRoute] int id)
        {

            var cliente = await context
            .Clientes
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.id == id);
            return cliente == null ? NotFound() : Ok(cliente);
        }

        [HttpPost("clientes")]
        public async Task<IActionResult> PostAsync(
            [FromServices] AppDbContext context,
            [FromBody] CreateClienteViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var cliente = new Cliente
            {
                data_inserido = DateTime.Now,
                nome     = model.nome,
                cpf      = model.cpf,
                telefone = model.telefone,
                cep      = model.cep,
                uf       = model.uf,
                cidade   = model.cidade
            };

            try
            {
                await context.Clientes.AddAsync(cliente);
                await context.SaveChangesAsync();
                return Created($"v1/{cliente.id}", cliente);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpPut("clientes/{id}")]
        public async Task<IActionResult> PutAsync(
            [FromServices] AppDbContext context,
            [FromBody] CreateClienteViewModel model,
            [FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var cliente = await context.Clientes.FirstOrDefaultAsync(x => x.id == id);

            if (cliente == null)
                return NotFound();

            try
            {
                cliente.nome = model.nome;

                context.Clientes.Update(cliente);
                await context.SaveChangesAsync();
                return Ok(cliente);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpDelete("clientes/{id}")]
        public async Task<IActionResult> DeleteAsync(
            [FromServices] AppDbContext context,
            [FromRoute] int id)
        {
            var cliente = await context.Clientes.FirstOrDefaultAsync(x => x.id == id);

            try
            {
                context.Clientes.Remove(cliente);
                await context.SaveChangesAsync();

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

    }
}
