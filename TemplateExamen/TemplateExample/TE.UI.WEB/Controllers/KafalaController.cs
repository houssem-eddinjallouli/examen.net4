using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TE.Core.Domain;
using TE.Core.Services;

namespace TE.UI.WEB.Controllers
{
    public class KafalaController : Controller
    {
        readonly IService<Kafala> servkafala;
        readonly IService<Donator> servdona;
        readonly IService<Beneficiary> servbene;
        public KafalaController(IService<Kafala> servkafala,
            IService<Donator> servdona, IService<Beneficiary> servbene)
        {
            this.servkafala = servkafala;
            this.servdona = servdona;
            this.servbene = servbene;
        }
        // GET: KafalaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: KafalaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: KafalaController/Create
        public ActionResult Create()
        {
            var don = servdona.GetAll();
            var ben = servbene.GetAll();
            ViewBag.dd = new SelectList(don, "Id", "Name");
            ViewBag.bb = new SelectList(ben, "CIN", "Name");
            return View();
        }

        // POST: KafalaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Kafala hh)
        {
            try
            {
                servkafala.Add(hh);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: KafalaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: KafalaController/Edit/5
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

        // GET: KafalaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: KafalaController/Delete/5
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
