using FuntourBusinessLayer.Service;
using FunTourDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace PruebaAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataService Service = new DataService();


        public ActionResult Index()
        {

            DateTime FromDay = System.DateTime.Now;
            DateTime toDay = System.DateTime.Now;

            string FromPlace = "Resistencia";
            string ToPlace = "Corrientes";

            IEnumerable<Bus> ListOfBusesToGo = Service.GetBuses(FromDay, FromPlace, ToPlace);
            IEnumerable<Bus> ListOfBusesToBack = Service.GetBuses(FromDay, FromPlace, ToPlace);

            ViewBag.BusesToGo = new SelectList(ListOfBusesToGo, "Id_Bus", "Id_Bus");
            ViewBag.BusesToBack = new SelectList(ListOfBusesToBack, "Id_Bus", "Id_Bus");
            ViewBag.BusesToGoToShow = ListOfBusesToGo;
            ViewBag.BusesToBackToShow = ListOfBusesToBack;
            return View();
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