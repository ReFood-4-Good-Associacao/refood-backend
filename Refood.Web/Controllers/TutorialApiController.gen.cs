
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
using Microsoft.AspNet.Identity;
using Refood.Business;
using Refood.Business.DTOs;
using Refood.Business.Interfaces;

namespace Refood.Web.Services
{
    //[Authorize]
    [RoutePrefix("api/TutorialApi")]
    public partial class TutorialApiController : ApiController
    {
        private readonly ITutorialService _tutorialService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TutorialApiController(ITutorialService tutorialService)
        {
            this._tutorialService = tutorialService;
        }

        public TutorialApiController() : this(new TutorialService()) { }

        /// <summary>
        /// Delete Tutorial by id
        /// </summary>
        /// <param name="id">Tutorial id</param>
        /// <returns>true if the Tutorial is deleted successfully</returns>
        public IHttpActionResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_tutorialService.DeleteTutorial - tutorialId: " + id + " "); 

                _tutorialService.DeleteTutorial(id);

                log.Debug("result: 'success'"); 

                //return JsonConvert.SerializeObject(true);
                return Ok(true);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get Tutorial by id
        /// </summary>
        /// <param name="id">Tutorial id</param>
        /// <returns>Tutorial json view model</returns>
        public IHttpActionResult Get(int id)
        {
            try
            {
                // get
                log.Debug("_tutorialService.GetTutorial - tutorialId: " + id + " "); 

                var tutorial = new TutorialViewModel(_tutorialService.GetTutorial(id));

                log.Debug("_tutorialService.GetTutorial - " + TutorialViewModel.FormatTutorialViewModel(tutorial)); 

                log.Debug("result: 'success'"); 

                //return Json(tutorial, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(tutorial), "application/json");
                //return tutorial;
                //return JsonConvert.SerializeObject(tutorial);
                return Ok(tutorial);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get list of Tutorials
        /// </summary>
        /// <returns>json list of Tutorial view models</returns>
        public IHttpActionResult GetList()
        {
            try
            {
                // get list
                List<TutorialViewModel> tutorials;

                log.Debug("_tutorialService.GetTutorials"); 

                // add edit url
                tutorials = _tutorialService.GetTutorials()
                        .Select(tutorial => new TutorialViewModel(tutorial, GetEditUrl(tutorial.TutorialId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (tutorials != null ? tutorials.Count().ToString() : "null")); 

                //return Json(tutorials, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(tutorials), "application/json");
                //return JsonConvert.SerializeObject(tutorials);
                return Ok(tutorials);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get paged list of Tutorials
        /// </summary>
        /// <param name="id">(not used)</param>
        /// <param name="searchTerm">search text</param>
        /// <param name="pageIndex">current page index (starts at 0)</param>
        /// <param name="pageSize">page size</param>
        /// <returns>a single page from the list of Tutorials</returns>
        public IHttpActionResult GetPage(int id = 0, string searchTerm = "", int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // get page
                List<TutorialViewModel> tutorials;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_tutorialService.GetTutorials - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                tutorials = _tutorialService.GetTutorials(searchTerm, pageIndex, pageSize)
                        .Select(tutorial => new TutorialViewModel(tutorial, GetEditUrl(tutorial.TutorialId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (tutorials != null ? tutorials.Count().ToString() : "null")); 

                //return Json(tutorials, JsonRequestBehavior.AllowGet);
                //return JsonConvert.SerializeObject(tutorials);
                return Ok(tutorials);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IHttpActionResult GetListAdvancedSearch(
            int id = 0 
            , string name = null 
            , string description = null 
            , string location = null 
            , bool? isOnlineTutorial = null 
            , string language = null 
            , bool? active = null 
        )
        {
            try
            {
                // advanced search

                log.Debug("GetTutorialListAdvancedSearch"); 

                IEnumerable<TutorialDTO> resultsDTO = _tutorialService.GetTutorialListAdvancedSearch(
                     name 
                    , description 
                    , location 
                    , isOnlineTutorial 
                    , language 
                    , active 
                );
            
                // convert to view model list, and add edit url
                List<TutorialViewModel> tutorialList = resultsDTO.Select(tutorial => new TutorialViewModel(tutorial, GetEditUrl(tutorial.TutorialId))).ToList();

                log.Debug("result: 'success', count: " + (tutorialList != null ? tutorialList.Count().ToString() : "null")); 

                //return Content(JsonConvert.SerializeObject(tutorialList), "application/json");
                //return JsonConvert.SerializeObject(tutorialList);
                return Ok(tutorialList);
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        
        protected string GetEditUrl(int id)
        {
            string editUrl = Url.Content("~/Tutorial/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Updates data for an existing Tutorial, or creates a new Tutorial if the Id is 0
        /// </summary>
        /// <param name="viewModel">Tutorial data</param>
        /// <returns>Tutorial id</returns>
        public IHttpActionResult Upsert(TutorialViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.TutorialId > 0)
            {
                var t = Update(viewModel);
                //return Json(true);
                //return JsonConvert.SerializeObject(t.TutorialId);
                return Ok(t.TutorialId);
            }
            else
            {
                var t = Create(viewModel);
                //return Json(t.TutorialId);
                //return JsonConvert.SerializeObject(t.TutorialId);
                return Ok(t.TutorialId);
            }
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Save a list of Tutorial
        /// </summary>
        /// <param name="viewModels">Tutorial view models</param>
        /// <param name="id">(not used)</param>
        /// <returns>true if the operation is successfull</returns>
        public IHttpActionResult SaveList(TutorialViewModel[] viewModels, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(TutorialViewModel viewModel in viewModels)
                    {
                        log.Debug(TutorialViewModel.FormatTutorialViewModel(viewModel)); 

                        if (viewModel.TutorialId > 0)
                        {
                            var t = Update(viewModel);
                        }
                        else
                        {
                            var t = Create(viewModel);
                        }

                    }
                }
                else
                {
                    log.Error("viewModels: null"); 
                }

                //return Json(true);
                //return JsonConvert.SerializeObject(true);
                return Ok(true);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private TutorialDTO Create(TutorialViewModel viewModel)
        {
            try
            {
                log.Debug(TutorialViewModel.FormatTutorialViewModel(viewModel)); 

                TutorialDTO tutorial = new TutorialDTO();

                // copy values
                viewModel.UpdateDTO(tutorial, null); //RequestContext.Principal.Identity.GetUserId());
                
                // audit
                tutorial.CreateBy = null; //RequestContext.Principal.Identity.GetUserId();
                tutorial.CreateOn = DateTime.UtcNow;

                // add
                log.Debug("_tutorialService.AddTutorial - " + TutorialDTO.FormatTutorialDTO(tutorial)); 

                int id = _tutorialService.AddTutorial(tutorial);

                tutorial.TutorialId = id;

                log.Debug("result: 'success', id: " + id); 

                return tutorial;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private TutorialDTO Update(TutorialViewModel viewModel)
        {
            try
            {
                log.Debug(TutorialViewModel.FormatTutorialViewModel(viewModel)); 

                // get
                log.Debug("_tutorialService.GetTutorial - tutorialId: " + viewModel.TutorialId + " "); 

                var existingTutorial = _tutorialService.GetTutorial(viewModel.TutorialId);

                log.Debug("_tutorialService.GetTutorial - " + TutorialDTO.FormatTutorialDTO(existingTutorial)); 

                if (existingTutorial != null)
                {
                    // copy values
                    viewModel.UpdateDTO(existingTutorial, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_tutorialService.UpdateTutorial - " + TutorialDTO.FormatTutorialDTO(existingTutorial)); 

                    _tutorialService.UpdateTutorial(existingTutorial);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingTutorial: null, TutorialId: " + viewModel.TutorialId); 
                }

                return existingTutorial;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

    }
}

    