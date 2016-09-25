using System;
using System.Web.Mvc;
using BleToDo0._2.Context;
using BleToDo0._2.Models;
using Repositories;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace BleToDo0._2.Controllers
{
    public class AfazerController : Controller
    {

        GenericRepository<Afazer> _genericRepository = new GenericRepository<Afazer>(new BaseContext());

        // GET: TAfazers
        public ActionResult Index(string SearchFor, string novo)
        {
            if (novo != "" && novo != null)
            {
                return RedirectToAction("Create", "Afazer");
            }
            else
            {
                if (SearchFor != "" && SearchFor != null)
                    return View(_genericRepository.SearchFor(a => a.AFZ_DESCRICAO.StartsWith(SearchFor) || a.AFZ_DESCRICAO.StartsWith(SearchFor)));
                
                 return View(_genericRepository.GetAll());
            }
            

        }

        // GET: TAfazers/Details/5
        public async Task<ActionResult> Details(Int32 id)
        {
            Afazer Afazer = await _genericRepository.GetByIdAsync(id);
            if (Afazer == null)
            {
                return HttpNotFound();
            }
            return View(Afazer);
        }

        // GET: TAfazers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TAfazers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Afazer Afazer)
        {
            if (ModelState.IsValid)
            {
                Afazer.ApplicationUserId = User.Identity.GetUserId();
                await _genericRepository.InsertAsync(Afazer);
                return RedirectToAction("Index");
            }

            return View(Afazer);
        }

        // GET: TAfazers/Edit/5
        public async Task<ActionResult> Edit(Int32 id)
        {
            Afazer AFazer = await _genericRepository.GetByIdAsync(id);
            if (AFazer == null)
            {
                return HttpNotFound();
            }
            return View(AFazer);
        }

        // POST: TAfazers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Afazer Afazer)
        {
            if (ModelState.IsValid)
            {
                Afazer.ApplicationUserId = User.Identity.GetUserId();
                await _genericRepository.EditAsync(Afazer);
                return RedirectToAction("Index");
            }
            return View(Afazer);
        }

        // GET: TAfazers/Delete/5
        public async Task<ActionResult> Delete(Int32 id)
        {
            Afazer AFazer = await _genericRepository.GetByIdAsync(id);
            if (AFazer == null)
            {
                return HttpNotFound();
            }
            return View(AFazer);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Int32 id)
        {
            Afazer AFazer = await _genericRepository.GetByIdAsync(id);
            await _genericRepository.DeleteAsync(AFazer);
            return RedirectToAction("Index");
        }

    }
}
