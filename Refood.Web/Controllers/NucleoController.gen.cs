
// ################################################################
//                      Code generated with T4
// ################################################################

using Refood.Web.Services.ViewModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using System.Web.Mvc;
using Refood.Business;
using Refood.Business.DTOs;
using Refood.Business.Interfaces;

namespace Refood.Web.Services
{
    public partial class NucleoController : System.Web.Mvc.Controller 
    {
        private readonly INucleoService _nucleoService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public NucleoController(INucleoService nucleoService)
        {
            this._nucleoService = nucleoService;
        }

        public NucleoController() : this(new NucleoService()) { }

        public ActionResult Index()
        {
            return View("View");
        }

        public ActionResult Edit()
        {
            return View("Edit");
        }

    }
}

    