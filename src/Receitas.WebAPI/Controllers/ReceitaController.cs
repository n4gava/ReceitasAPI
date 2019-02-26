using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using Receitas.WebAPI.Data;
using Receitas.WebAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
