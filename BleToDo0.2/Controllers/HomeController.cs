using System;
using System.Web.Mvc;
using BleToDo0._2.Context;
using BleToDo0._2.Models;
using Repositories;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace BleToDo0._2.Controllers
{
    public class HomeController : Controller
    {
        GenericRepository<Afazer> _genericRepository = new GenericRepository<Afazer>(new BaseContext());

        // GET: TAfazers
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            if (userId != "" && userId != null)
            {
                return View(_genericRepository.SearchFor(a => a.ApplicationUserId == userId));
            }
            else
                return View(_genericRepository.GetAll());


        }
    }
}