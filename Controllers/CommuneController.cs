using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebGIS.Data;  // Adjust namespace for your DataContext
using WebGIS.Models;  // Adjust namespace for your commune model
using NetTopologySuite.Geometries;
using NetTopologySuite.IO;

namespace WebGIS.Controllers
{
    public class CommuneController : Controller
    {
        private readonly AppDbContext _context;

        public CommuneController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Commune
        public IActionResult Index()
        {
            return View();
        }
        
        
        
            

   
}
}

