
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
    public partial class ContributionMonetaryReviewerController : System.Web.Mvc.Controller 
    {
        private readonly IContributionMonetaryReviewerService _contributionMonetaryReviewerService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ContributionMonetaryReviewerController(IContributionMonetaryReviewerService contributionMonetaryReviewerService)
        {
            this._contributionMonetaryReviewerService = contributionMonetaryReviewerService;
        }

        public ContributionMonetaryReviewerController() : this(new ContributionMonetaryReviewerService()) { }

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

    