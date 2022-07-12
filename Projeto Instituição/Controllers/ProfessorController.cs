using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoInstituição.Entidades;
using ProjetoInstituição.Models;
using System.Linq;

namespace ProjetoInstituição.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly Contexto db;

        public ProfessorController(Contexto Contexto)
        {
            db = Contexto;
        }
        // GET: ProfessorController
        public ActionResult Index()
        {
            return View(db.PROFESSOR.ToList());
        }

        // GET: ProfessorController/Details/5
        public ActionResult Details(int id)
        {
            return View(db.PROFESSOR.Where(a => a.Id == id).FirstOrDefault());
        }

        // GET: ProfessorController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: ProfessorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Professor collection)
        {
            try
            {
                db.PROFESSOR.Add(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProfessorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.PROFESSOR.Where(a => a.Id == id).FirstOrDefault());
        }

        // POST: ProfessorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Professor collection)
        {
            try
            {
                db.PROFESSOR.Update(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProfessorController/Delete/5
        public ActionResult Delete(int id)
        {
            db.PROFESSOR.Remove(db.PROFESSOR.Where(a => a.Id == id).FirstOrDefault());
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
