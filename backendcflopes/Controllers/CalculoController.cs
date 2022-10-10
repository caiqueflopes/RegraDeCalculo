using backendcflopes.Data;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using backendcflopes.ViewModels;
using backendcflopes.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace backendcflopes.Controllers
{
    [ApiController]
    [Route (template:"v1")]
    public class CalculoController : ControllerBase
    {
        [HttpGet]
        [Route(template:"calculos")]
        public async Task<IActionResult> GetAsync([FromServices] AppDbContext context)
        {

            var calculos = await context
            .Calculos
            .AsNoTracking()
            .ToListAsync();
            return Ok (calculos);
        }

        [HttpGet]
        [Route(template: "calculos/{id}")]
        public async Task<IActionResult> GetBayIdAsync([FromServices] AppDbContext context, [FromRoute] int id)
        {

            var calculo = await context
            .Calculos
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.id == id);
            return calculo==null ?NotFound(): Ok(calculo);
        }
        
        [HttpPost("calculos")]
        public async Task<IActionResult> PostAsync(
            [FromServices] AppDbContext context,
            [FromBody] CreateCalculoViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var calculo = new Calculo
            {
                data_inserido = DateTime.Now,
                ativo = true,
                nome_campanha = model.nome_campanha
            };

            try
            {
                await context.Calculos.AddAsync(calculo);
                await context.SaveChangesAsync();
                return Created($"v1/{calculo.id}", calculo);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpPut("calculos/{id}")]
        public async Task<IActionResult> PutAsync(
            [FromServices] AppDbContext context,
            [FromBody] CreateCalculoViewModel model,
            [FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var calculo = await context.Calculos.FirstOrDefaultAsync(x => x.id == id);

            if (calculo == null)
                return NotFound();

            try
            {
                calculo.nome_campanha = model.nome_campanha;

                context.Calculos.Update(calculo);
                await context.SaveChangesAsync();
                return Ok(calculo);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpDelete("calculos/{id}")]
        public async Task<IActionResult> DeleteAsync(
            [FromServices] AppDbContext context,
            [FromRoute] int id)
        {
            var calculo = await context.Calculos.FirstOrDefaultAsync(x => x.id == id);

            try
            {
                context.Calculos.Remove(calculo);
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
