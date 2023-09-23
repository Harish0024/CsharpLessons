using FirstMVCApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class EntityController : Controller
    {
        // GET: MovieController
        public ActionResult Index()
        {
           
            List<Enitity> list = MoviedbRepository.GetMovieList();
            return View(list);
        }

        // GET: MovieController/Details/5
        public ActionResult Details(int id)
        {
            if (id <= 0)
            {
                return RedirectToAction("Index");
            }
            Enitity enitity = MoviedbRepository.GetMovieById(id);
            return View(enitity);
        }

        // GET: MovieController/Create
        public ActionResult Create()
        {
            Enitity enitity = new Enitity();
            return View(enitity);
        }

        // POST: MovieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Enitity pEnitity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    MoviedbRepository.AddNewEnitity(pEnitity);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Edit/5
        public ActionResult Edit(int id)
        {
            Enitity enitity = MoviedbRepository.GetMovieById(id);
            return View(enitity);
        }

        // POST: MovieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection,Enitity pEnitity)
        {
            try
            {
                if(ModelState.IsValid) 
                    MoviedbRepository.UpdateMovie(pEnitity);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Delete/5
        public ActionResult Delete(int id)
        {
            Enitity enitity = MoviedbRepository.GetMovieById(id);
            return View(enitity);
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection,Enitity pEnitity)
        {
            try
            {
                MoviedbRepository.DeleteMovie(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
