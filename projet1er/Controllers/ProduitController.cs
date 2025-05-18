using controle.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace projet.Controllers
{
    public class ProduitController : Controller
    {
        private readonly DataBaseContext DB;
        public ProduitController(DataBaseContext dataBaseContext)
        {
            DB = dataBaseContext;
        }

        // GET: ProduitController
        public ActionResult Index()
        {
            var produit = DB.produits.ToList();
            return View(produit);
        }


        // GET: ProduitController/Details/5
        public ActionResult Details(int id)
        {
            return View(DB.produits.Find(id));
        }

        // GET: ProduitController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProduitController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Produit produit)
        {
            try
            {
                DB.produits.Add(produit);
                DB.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();

            }
        }
        // GET: ProduitController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(DB.produits.Find(id));
        }


        // POST: ProduitController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Produit produit)
        {
            try
            {
                DB.Entry(produit).State = EntityState.Modified;
                DB.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProduitController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(DB.produits.Find(id));
        }

        // POST: ProduitController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Produit produit)
        {
            try
            {
                DB.produits.Remove(produit);
                DB.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
