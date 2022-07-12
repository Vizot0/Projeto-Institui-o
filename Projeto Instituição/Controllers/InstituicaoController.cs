using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoInstituição.Entidades;
using System;
using System.Linq;

namespace ProjetoInstituição.Controllers
{
    public class InstituicaoController : Controller
    {

        private readonly Contexto db;

        public InstituicaoController(Contexto contexto)
        {
            db = contexto;
        }



        // GET: InstituicaoController
        public ActionResult Index()
        {
            return View(db.INTITUICAO.ToList());
        }

        // GET: InstituicaoController/Details/5
        public ActionResult Details(int id)
        {
            return View(db.INTITUICAO.Where(a =>a.instId == id).FirstOrDefault());
        }

        // GET: InstituicaoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InstituicaoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Instituicao collection)
        {
            try
            {
                db.INTITUICAO.Add(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InstituicaoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.INTITUICAO.Where(a=> a.instId == id).FirstOrDefault());
        }

        // POST: InstituicaoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Instituicao collection)
        {
            try
            {
                db.INTITUICAO.Update(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InstituicaoController/Delete/5
        public ActionResult Delete(int id)
        {
           db.INTITUICAO.Remove(db.INTITUICAO.Where(a => a.instId == id).FirstOrDefault());
           db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
