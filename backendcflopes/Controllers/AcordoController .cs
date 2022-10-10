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
    public class AcordoController : ControllerBase
    {
        [HttpGet]
        [Route(template: "acordos")]

        public async Task<IActionResult> GetAsync([FromServices] AppDbContext context)
        {

            var acordos = await context
            .Acordos
            .AsNoTracking()
            .ToListAsync();
            return Ok (acordos);
        }

        [HttpGet]
        [Route(template: "acordos/{id}")]
        public async Task<IActionResult> GetBayIdAsync([FromServices] AppDbContext context, [FromRoute] int id)
        {

            var acordos = await context
            .Acordos
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.id == id);
            return acordos == null ?NotFound(): Ok(acordos);
        }

        [HttpPost("acordos")]
        public async Task<IActionResult> PostAsync(
            [FromServices] AppDbContext context,
            [FromBody] CreateAcordoViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest();
  
            var acordo = new Acordo
            {
             
                valor_acordo = model.valor_acordo,
                ativo = true,
                valor_juros_acordo = 10

            };

            try
            {
                await context.Acordos.AddAsync(acordo);
                await context.SaveChangesAsync();
                return Created($"v1/{acordo.id}", acordo);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpPut("acordos/{id}")]
        public async Task<IActionResult> PutAsync(
            [FromServices] AppDbContext context,
            [FromBody] CreateAcordoViewModel model,
            [FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var acordo = await context.Acordos.FirstOrDefaultAsync(x => x.id == id);

            if (acordo == null)
                return NotFound();

            try
            {
                acordo.valor_acordo = Convert.ToDouble(model.valor_acordo);

                context.Acordos.Update(acordo);
                await context.SaveChangesAsync();
                return Ok(acordo);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpDelete("acordos/{id}")]
        public async Task<IActionResult> DeleteAsync(
            [FromServices] AppDbContext context,
            [FromRoute] int id)
        {
            var acordo = await context.Acordos.FirstOrDefaultAsync(x => x.id == id);

            try
            {
                context.Acordos.Remove(acordo);
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
