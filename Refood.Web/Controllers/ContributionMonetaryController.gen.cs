
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
    public partial class ContributionMonetaryController : System.Web.Mvc.Controller 
    {
        private readonly IContributionMonetaryService _contributionMonetaryService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ContributionMonetaryController(IContributionMonetaryService contributionMonetaryService)
        {
            this._contributionMonetaryService = contributionMonetaryService;
        }

        public ContributionMonetaryController() : this(new ContributionMonetaryService()) { }

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

    