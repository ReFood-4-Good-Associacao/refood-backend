
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
    [RoutePrefix("api/EquipmentApi")]
    public partial class EquipmentApiController : ApiController
    {
        private readonly IEquipmentService _equipmentService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public EquipmentApiController(IEquipmentService equipmentService)
        {
            this._equipmentService = equipmentService;
        }

        public EquipmentApiController() : this(new EquipmentService()) { }

        /// <summary>
        /// Delete Equipment by id
        /// </summary>
        /// <param name="id">Equipment id</param>
        /// <returns>true if the Equipment is deleted successfully</returns>
        public IHttpActionResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_equipmentService.DeleteEquipment - equipmentId: " + id + " "); 

                _equipmentService.DeleteEquipment(id);

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
        /// Get Equipment by id
        /// </summary>
        /// <param name="id">Equipment id</param>
        /// <returns>Equipment json view model</returns>
        public IHttpActionResult Get(int id)
        {
            try
            {
                // get
                log.Debug("_equipmentService.GetEquipment - equipmentId: " + id + " "); 

                var equipment = new EquipmentViewModel(_equipmentService.GetEquipment(id));

                log.Debug("_equipmentService.GetEquipment - " + EquipmentViewModel.FormatEquipmentViewModel(equipment)); 

                log.Debug("result: 'success'"); 

                //return Json(equipment, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(equipment), "application/json");
                //return equipment;
                //return JsonConvert.SerializeObject(equipment);
                return Ok(equipment);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get list of Equipments
        /// </summary>
        /// <returns>json list of Equipment view models</returns>
        public IHttpActionResult GetList()
        {
            try
            {
                // get list
                List<EquipmentViewModel> equipments;

                log.Debug("_equipmentService.GetEquipments"); 

                // add edit url
                equipments = _equipmentService.GetEquipments()
                        .Select(equipment => new EquipmentViewModel(equipment, GetEditUrl(equipment.EquipmentId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (equipments != null ? equipments.Count().ToString() : "null")); 

                //return Json(equipments, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(equipments), "application/json");
                //return JsonConvert.SerializeObject(equipments);
                return Ok(equipments);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get paged list of Equipments
        /// </summary>
        /// <param name="id">(not used)</param>
        /// <param name="searchTerm">search text</param>
        /// <param name="pageIndex">current page index (starts at 0)</param>
        /// <param name="pageSize">page size</param>
        /// <returns>a single page from the list of Equipments</returns>
        public IHttpActionResult GetPage(int id = 0, string searchTerm = "", int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // get page
                List<EquipmentViewModel> equipments;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_equipmentService.GetEquipments - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                equipments = _equipmentService.GetEquipments(searchTerm, pageIndex, pageSize)
                        .Select(equipment => new EquipmentViewModel(equipment, GetEditUrl(equipment.EquipmentId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (equipments != null ? equipments.Count().ToString() : "null")); 

                //return Json(equipments, JsonRequestBehavior.AllowGet);
                //return JsonConvert.SerializeObject(equipments);
                return Ok(equipments);
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
            , string category = null 
            , int? photo = null 
            , double? quantityInStock = null 
            , double? minimumQuantityNeeded = null 
            , double? pricePerUnit = null 
            , string storageLocation = null 
            , bool? active = null 
        )
        {
            try
            {
                // advanced search

                log.Debug("GetEquipmentListAdvancedSearch"); 

                IEnumerable<EquipmentDTO> resultsDTO = _equipmentService.GetEquipmentListAdvancedSearch(
                     name 
                    , description 
                    , category 
                    , photo 
                    , quantityInStock 
                    , minimumQuantityNeeded 
                    , pricePerUnit 
                    , storageLocation 
                    , active 
                );
            
                // convert to view model list, and add edit url
                List<EquipmentViewModel> equipmentList = resultsDTO.Select(equipment => new EquipmentViewModel(equipment, GetEditUrl(equipment.EquipmentId))).ToList();

                log.Debug("result: 'success', count: " + (equipmentList != null ? equipmentList.Count().ToString() : "null")); 

                //return Content(JsonConvert.SerializeObject(equipmentList), "application/json");
                //return JsonConvert.SerializeObject(equipmentList);
                return Ok(equipmentList);
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
            string editUrl = Url.Content("~/Equipment/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Updates data for an existing Equipment, or creates a new Equipment if the Id is 0
        /// </summary>
        /// <param name="viewModel">Equipment data</param>
        /// <returns>Equipment id</returns>
        public IHttpActionResult Upsert(EquipmentViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.EquipmentId > 0)
            {
                var t = Update(viewModel);
                //return Json(true);
                //return JsonConvert.SerializeObject(t.EquipmentId);
                return Ok(t.EquipmentId);
            }
            else
            {
                var t = Create(viewModel);
                //return Json(t.EquipmentId);
                //return JsonConvert.SerializeObject(t.EquipmentId);
                return Ok(t.EquipmentId);
            }
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Save a list of Equipment
        /// </summary>
        /// <param name="viewModels">Equipment view models</param>
        /// <param name="id">(not used)</param>
        /// <returns>true if the operation is successfull</returns>
        public IHttpActionResult SaveList(EquipmentViewModel[] viewModels, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(EquipmentViewModel viewModel in viewModels)
                    {
                        log.Debug(EquipmentViewModel.FormatEquipmentViewModel(viewModel)); 

                        if (viewModel.EquipmentId > 0)
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

        private EquipmentDTO Create(EquipmentViewModel viewModel)
        {
            try
            {
                log.Debug(EquipmentViewModel.FormatEquipmentViewModel(viewModel)); 

                EquipmentDTO equipment = new EquipmentDTO();

                // copy values
                viewModel.UpdateDTO(equipment, null); //RequestContext.Principal.Identity.GetUserId());
                
                // audit
                equipment.CreateBy = null; //RequestContext.Principal.Identity.GetUserId();
                equipment.CreateOn = DateTime.UtcNow;

                // add
                log.Debug("_equipmentService.AddEquipment - " + EquipmentDTO.FormatEquipmentDTO(equipment)); 

                int id = _equipmentService.AddEquipment(equipment);

                equipment.EquipmentId = id;

                log.Debug("result: 'success', id: " + id); 

                return equipment;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private EquipmentDTO Update(EquipmentViewModel viewModel)
        {
            try
            {
                log.Debug(EquipmentViewModel.FormatEquipmentViewModel(viewModel)); 

                // get
                log.Debug("_equipmentService.GetEquipment - equipmentId: " + viewModel.EquipmentId + " "); 

                var existingEquipment = _equipmentService.GetEquipment(viewModel.EquipmentId);

                log.Debug("_equipmentService.GetEquipment - " + EquipmentDTO.FormatEquipmentDTO(existingEquipment)); 

                if (existingEquipment != null)
                {
                    // copy values
                    viewModel.UpdateDTO(existingEquipment, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_equipmentService.UpdateEquipment - " + EquipmentDTO.FormatEquipmentDTO(existingEquipment)); 

                    _equipmentService.UpdateEquipment(existingEquipment);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingEquipment: null, EquipmentId: " + viewModel.EquipmentId); 
                }

                return existingEquipment;
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

    