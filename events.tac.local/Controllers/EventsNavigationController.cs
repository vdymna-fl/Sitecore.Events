using events.tac.local.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace events.tac.local.Controllers
{
    public class EventsNavigationController : Controller
    {
        private readonly NavigationBuilder _builder;

        public EventsNavigationController() : this(new NavigationBuilder())
        {
        }

        public EventsNavigationController(NavigationBuilder builder)
        {
            _builder = builder;
        }

        public ActionResult Index()
        {
            return View(_builder.Build());
        }
    }
}