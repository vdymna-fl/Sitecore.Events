﻿using events.tac.local.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace events.tac.local.Controllers
{
    public class EventsBreadcrumbController : Controller
    {
        private readonly BreadcrumbBuilder _builder;

        public EventsBreadcrumbController() : this(new BreadcrumbBuilder())
        {
        }

        public EventsBreadcrumbController(BreadcrumbBuilder builder)
        {
            _builder = builder;
        }


        public ActionResult Index()
        {
            return View(_builder.Build());
        }
    }
}