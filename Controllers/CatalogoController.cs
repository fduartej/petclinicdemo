using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using petclinicdemo.Models;
using petclinicdemo.Data;

namespace petclinicdemo.Controllers
{
    public class CatalogoController : Controller
    {

       private readonly ILogger<CatalogoController> _logger;
       private readonly ApplicationDbContext _context;


        public CatalogoController(ILogger<CatalogoController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var listProductos=_context.Productos.ToList();
            return View(listProductos);
        }


    }
}