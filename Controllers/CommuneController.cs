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
        public IActionResult Map()
        {
            return View();
        }
        public ActionResult Zoom(int? id)
        {
            if (id == null)
            {
                return new StatusCodeResult(statusCode: 400);
            }
            Commune commune = _context.Communes.Find(id);
            if (commune == null)
            {
                return new StatusCodeResult(statusCode: 404);
            }
            return View(commune);
        }
        public IActionResult Edit(int id)
        {
            if(id==null || id==0)
                return NotFound();
            Commune obj= _context.Communes.Find(id);
            if (obj==null)
                return NotFound();
            return View(obj);
        }
        [HttpPost]
        public IActionResult Edit(Commune obj)
        {
            if (ModelState.IsValid)
            {
                _context.Communes.Update(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else return View();
        }
            

   
}
}

