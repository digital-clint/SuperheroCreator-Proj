using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperheroCreator.Data;
using SuperheroCreator.Models;

namespace SuperheroCreator.Controllers
{
    public class SuperheroController : Controller
    {
        private ApplicationDbContext _context;

        public SuperheroController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SuperheroController
        public ActionResult Index()
        {
            return View(_context.Superheroes);
        }

        // GET: SuperheroController/Details/5
        public ActionResult Details(int id)
        {
            Superhero selectedHero = new Superhero();
            selectedHero = _context.Superheroes.Where(x => x.Id == id).FirstOrDefault();
            return View(selectedHero);
        }

        // GET: SuperheroController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuperheroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Superhero superhero)
        {
            try
            {

                _context.Superheroes.Add(superhero);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperheroController/Edit/5
        public ActionResult Edit(int id)
        {
            Superhero selectedHero = new Superhero();
            selectedHero = _context.Superheroes.Where(x => x.Id == id).FirstOrDefault();
            return View(selectedHero);
        }

        // POST: SuperheroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Superhero superhero)
        {
            try
            {
                _context.Superheroes.Update(superhero);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperheroController/Delete/5
        public ActionResult Delete(Superhero superhero)
        {
            return View();
        }

        // POST: SuperheroController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
