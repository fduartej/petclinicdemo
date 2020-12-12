using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using petclinicdemo.Models;
using petclinicdemo.Data;

namespace petclinicdemo.Controllers.Rest
{
    [ApiController]
    [Route("api/productos")]
    public class APIProductoController : ControllerBase
    {
       private readonly ILogger<APIProductoController> _logger;
       private readonly ApplicationDbContext _context;

        public APIProductoController(ILogger<APIProductoController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }


        [HttpGet]
        public IEnumerable<Producto> Get()
        {
             var listProductos=_context.Productos.OrderBy(s => s.ID).ToList();   
             return listProductos.ToArray();
        }

    }
}