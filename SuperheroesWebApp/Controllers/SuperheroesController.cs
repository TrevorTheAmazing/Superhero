using SuperheroesWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperheroesWebApp.Controllers
{
    public class SuperheroesController : Controller
    {
        ApplicationDbContext db;
        public SuperheroesController()
        {
            db = new ApplicationDbContext();
        }


        // GET: Superheroes
        public ActionResult Index()
        {
            //get all superhero
            var superheroesIndexView = db.Superheroes.Select(s=>s);
            return View(superheroesIndexView);
        }

        // GET: Superheroes/Details/5
        public ActionResult Details(int id)
        {
            //get details for a superhero
            var superhero = db.Superheroes.Where(s => s.Id == id).Single();
            return View(superhero);
        }

        // GET: Superheroes/Create
        //cant get superhero that dont exist
        public ActionResult Create()
        {
            Superhero superhero = new Superhero();
            return View(superhero);
        }

        // POST: Superheroes/Create
        [HttpPost]
        public ActionResult Create(Superhero superhero)
        {
            try
            {
                // TODO: Add insert logic here
                db.Superheroes.Add(superhero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superheroes/Edit/5
        public ActionResult Edit(int id)
        {
            var superhero = db.Superheroes.Where(s => s.Id == id).Single();
            return View(superhero);
        }

        // POST: Superheroes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Superhero superheroIn)
        {
            Superhero superheroFromDb = null;
            try
            {
                // TODO: Add update logic here
                var tempSuperheroFromDb = db.Superheroes.Where(s => s.Id == superheroIn.Id).Single();
                superheroFromDb = tempSuperheroFromDb;
                superheroFromDb.name = superheroIn.name;
                superheroFromDb.alterEgoName = superheroIn.alterEgoName;
                superheroFromDb.primarySuperheroAbility = superheroIn.primarySuperheroAbility;
                superheroFromDb.secondarySuperheroAbility = superheroIn.secondarySuperheroAbility;
                superheroFromDb.catchphrase = superheroIn.catchphrase;
                
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superheroes/Delete/5
        public ActionResult Delete(int id)
        {
            var superhero = db.Superheroes.Where(s => s.Id == id).Single();
            return View(superhero);
        }

        // POST: Superheroes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Superhero superheroIn)
        {
            Superhero superheroFromDb = null;
            try
            {
                // TODO: Add delete logic here
                var tempSuperheroFromDb = db.Superheroes.Where(s => s.Id == superheroIn.Id).Single();
                superheroFromDb = tempSuperheroFromDb;
                db.Superheroes.Remove(superheroFromDb);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
