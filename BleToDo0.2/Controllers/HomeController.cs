using System;
using System.Web.Mvc;
using BleToDo0._2.Context;
using BleToDo0._2.Models;
using Repositories;
using System.Threading.Tasks;

namespace BleToDo0._2.Controllers
{
    public class HomeController : Controller
    {
        GenericRepository<Afazer> _genericRepository = new GenericRepository<Afazer>(new BaseContext());

        // GET: TAfazers
        public ActionResult Index(string SearchFor)
        {

            if (SearchFor != "" && SearchFor != null)
                return View(_genericRepository.SearchFor(a => a.AFZ_DESCRICAO.StartsWith(SearchFor) && a.AFZ_ATIVO == true));
            else
                return View(_genericRepository.GetAll());

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}