using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    
    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext _context;
        public ActivitiesController(DataContext context)
        {
            _context = context;  
        }
        //En este metodo si la peticion trae un id el programa entra por acá y se hará COMO un select * from//
        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
          return await _context.Activities.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivities(Guid id)
        {
            //En este metodo si buscan por id, se hará una busqueda se coloca FindAsyn que refiere a un where (donde el id es)//
          return await _context.Activities.FindAsync(id);
        }

    }
}