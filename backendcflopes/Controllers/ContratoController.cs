using backendcflopes.Data;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using backendcflopes.ViewModels;
using backendcflopes.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;

namespace backendcflopes.Controllers
{
    [ApiController]  
    [Route(template: "v1")]
    public class ContratoController : ControllerBase
    {
        [HttpGet]
        [Route(template: "contratos")]
        public async Task<IActionResult> GetAsync([FromServices] AppDbContext context)
        {

            var contratos = await context
            .Contratos
            .AsNoTracking()
            .ToListAsync();
            return Ok(contratos);
        }

        [HttpGet]
        [Route(template: "contratos/{id}")]
        public async Task<IActionResult> GetBayIdAsync([FromServices] AppDbContext context, [FromRoute] int id)
        {

            var contrato = await context
            .Contratos
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.id == id);
            return contrato == null ? NotFound() : Ok(contrato);
        }

        [HttpPost("contratos")]
        public async Task<IActionResult> PostAsync(
            [FromServices] AppDbContext context,
            [FromBody] CreateContratoViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var contrato = new Contrato
            {
                data_inserido = DateTime.Now,
                numero_contrato = model.numero_contrato
            };

            try
            {
                await context.Contratos.AddAsync(contrato);
                await context.SaveChangesAsync();
                return Created($"v1/{contrato.id}", contrato);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpPut("contratos/{id}")]
        public async Task<IActionResult> PutAsync(
            [FromServices] AppDbContext context,
            [FromBody] CreateContratoViewModel model,
            [FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var contrato = await context.Contratos.FirstOrDefaultAsync(x => x.id == id);

            if (contrato == null)
                return NotFound();

            try
            {
                contrato.numero_contrato = model.numero_contrato;

                context.Contratos.Update(contrato);
                await context.SaveChangesAsync();
                return Ok(contrato);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpDelete("contratos/{id}")]
        public async Task<IActionResult> DeleteAsync(
            [FromServices] AppDbContext context,
            [FromRoute] int id)
        {
            var contrato = await context.Contratos.FirstOrDefaultAsync(x => x.id == id);

            try
            {
                context.Contratos.Remove(contrato);
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
