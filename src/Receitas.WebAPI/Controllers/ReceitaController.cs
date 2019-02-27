using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Receitas.WebAPI.Data;
using Receitas.WebAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Receitas.WebAPI.Controllers
{
    public class ReceitaController : ODataController
    {
        AppDbContext _dbContext;

        public ReceitaController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [EnableQuery]
        public IQueryable<Receita> Get()
        {
            return _dbContext.Receitas;
        }

        [EnableQuery]
        public SingleResult<Receita> Get([FromODataUri] long id)
        {
            IQueryable<Receita> result = _dbContext.Receitas.Where(p => p.ID == id);
            return SingleResult.Create(result);
        }


        public async Task<IActionResult> Post([FromBody] Receita receita)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _dbContext.Receitas.Add(receita);
            await _dbContext.SaveChangesAsync();
            return Created(receita);
        }

        public async Task<IActionResult> Patch([FromODataUri] long key, Delta<Receita> receita)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var entity = await _dbContext.Receitas.FindAsync(key);
            if (entity == null)
                return NotFound();

            receita.Patch(entity);
            await _dbContext.SaveChangesAsync();
            return Updated(entity);
        }

        public async Task<IActionResult> Put([FromODataUri] long key, Receita receita)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (key != receita.ID)
            {
                return BadRequest();
            }

            _dbContext.Entry(receita).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            
            return Updated(receita);
        }

        public async Task<IActionResult> Delete([FromODataUri] long key)
        {
            var receita = await _dbContext.Receitas.FindAsync(key);
            if (receita == null)
                return NotFound();

            _dbContext.Receitas.Remove(receita);
            await _dbContext.SaveChangesAsync();
            return NoContent();
        }
    }
}
