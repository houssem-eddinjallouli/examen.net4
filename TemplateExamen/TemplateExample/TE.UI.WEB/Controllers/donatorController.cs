using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TE.Core.Domain;
using TE.Core.Services;

namespace TE.UI.WEB.Controllers
{
    public class donatorController : Controller
    {
        readonly IService<Donator> servdo;
        public donatorController(IService<Donator> servdo)
        {
            this.servdo = servdo;
        }
        // GET: donatorController
        public ActionResult Index()
        {
            return View(servdo.GetAll());
        }
        public ActionResult Kafala(int id)
        {
            return View(servdo
                .GetAll()
                .Where(h=>h.Id==id)
                .SelectMany(j=>j.Kafalas)
                .ToList());
        }
        
        // GET: donatorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: donatorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: donatorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: donatorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: donatorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: donatorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: donatorController/Delete/5
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
