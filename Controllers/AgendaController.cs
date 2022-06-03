using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CursoAzure.Controllers
{
    public class AgendaController : Controller
    {
        // GET: AgendaController
        public ActionResult Index()
        {
            List<CursoAzure.Models.AgendaModels> lista= new List<CursoAzure.Models.AgendaModels>();
            CursoAzure.Models.AgendaModels model = new Models.AgendaModels();
            model.Id= 1;
            model.Nombre = "Pedro Guarecuco";
            lista.Add(model);
            model.Id = 2;
            model.Nombre = "Jose Guarecuco";
            lista.Add(model);
            return View(lista);
        }

        // GET: AgendaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AgendaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AgendaController/Create
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

        // GET: AgendaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AgendaController/Edit/5
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

        // GET: AgendaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AgendaController/Delete/5
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
