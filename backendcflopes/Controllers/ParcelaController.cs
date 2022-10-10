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
    [Route(template: "v1")]
    public class ParcelaController : ControllerBase
    {
        [HttpGet]
        [Route(template: "parcelas")]
        public async Task<IActionResult> GetAsync([FromServices] AppDbContext context)
        {

            var parcelas = await context
            .Parcelas
            .AsNoTracking()
            .ToListAsync();
            return Ok(parcelas);
        }

        [HttpGet]
        [Route(template: "parcelas/{id}")]
        public async Task<IActionResult> GetBayIdAsync([FromServices] AppDbContext context, [FromRoute] int id)
        {

            var parcela = await context
            .Parcelas
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.id == id);
            return parcela == null ? NotFound() : Ok(parcela);
        }

        [HttpPost("parcelas")]
        public async Task<IActionResult> PostAsync(
            [FromServices] AppDbContext context,
            [FromBody] CreateParcelaViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var parcela = new Parcela
            {
                data_inserido = DateTime.Now,
                valor_parcela_original = model.valor_parcela_original
            };

            try
            {
                await context.Parcelas.AddAsync(parcela);
                await context.SaveChangesAsync();
                return Created($"v1/{parcela.id}", parcela);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpPut("parcelas/{id}")]
        public async Task<IActionResult> PutAsync(
            [FromServices] AppDbContext context,
            [FromBody] CreateParcelaViewModel model,
            [FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var parcela = await context.Parcelas.FirstOrDefaultAsync(x => x.id == id);

            if (parcela == null)
                return NotFound();

            try
            {
                parcela.valor_parcela_original = model.valor_parcela_original;

                context.Parcelas.Update(parcela);
                await context.SaveChangesAsync();
                return Ok(parcela);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpDelete("parcelas/{id}")]
        public async Task<IActionResult> DeleteAsync(
            [FromServices] AppDbContext context,
            [FromRoute] int id)
        {
            var parcela = await context.Parcelas.FirstOrDefaultAsync(x => x.id == id);

            try
            {
                context.Parcelas.Remove(parcela);
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
