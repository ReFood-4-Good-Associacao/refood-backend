
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
    public partial class RefoodUserController : System.Web.Mvc.Controller 
    {
        private readonly IRefoodUserService _refoodUserService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RefoodUserController(IRefoodUserService refoodUserService)
        {
            this._refoodUserService = refoodUserService;
        }

        public RefoodUserController() : this(new RefoodUserService()) { }


        public ActionResult Index()
        {
            return View("View");
        }

        public ActionResult Edit()
        {
            return View("Edit");
        }

        public JsonResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_refoodUserService.DeleteRefoodUser - refoodUserId: " + id + " "); 

                _refoodUserService.DeleteRefoodUser(id);

                log.Debug("result: 'success'"); 

                return Json(true, JsonRequestBehavior.AllowGet);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public ActionResult Get(int id)
        {
            try
            {
                // get
                log.Debug("_refoodUserService.GetRefoodUser - refoodUserId: " + id + " "); 

                var refoodUser = new RefoodUserViewModel(_refoodUserService.GetRefoodUser(id));

                log.Debug("_refoodUserService.GetRefoodUser - " + RefoodUserViewModel.FormatRefoodUserViewModel(refoodUser)); 

                log.Debug("result: 'success'"); 

                //return Json(refoodUser, JsonRequestBehavior.AllowGet);
                return Content(JsonConvert.SerializeObject(refoodUser), "application/json");
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public ActionResult GetList()
        {
            try
            {
                // get list
                List<RefoodUserViewModel> refoodUsers;

                log.Debug("_refoodUserService.GetRefoodUsers"); 

                // add edit url
                refoodUsers = _refoodUserService.GetRefoodUsers()
                        .Select(refoodUser => new RefoodUserViewModel(refoodUser, GetEditUrl(refoodUser.RefoodUserId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (refoodUsers != null ? refoodUsers.Count().ToString() : "null")); 

                //return Json(refoodUsers, JsonRequestBehavior.AllowGet);
                return Content(JsonConvert.SerializeObject(refoodUsers), "application/json");
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public JsonResult GetPage(int itemId = 0, string searchTerm = "", int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // get page
                List<RefoodUserViewModel> refoodUsers;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_refoodUserService.GetRefoodUsers - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                refoodUsers = _refoodUserService.GetRefoodUsers(searchTerm, pageIndex, pageSize)
                        .Select(refoodUser => new RefoodUserViewModel(refoodUser, GetEditUrl(refoodUser.RefoodUserId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (refoodUsers != null ? refoodUsers.Count().ToString() : "null")); 

                return Json(refoodUsers, JsonRequestBehavior.AllowGet);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }
        
        protected string GetEditUrl(int id)
        {
            string editUrl = Url.Content("~/RefoodUser/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        public JsonResult Upsert(RefoodUserViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.RefoodUserId > 0)
            {
                var t = Update(viewModel);
                return Json(true);
            }
            else
            {
                var t = Create(viewModel);
                return Json(t.RefoodUserId);
            }
        }

        //[ValidateAntiForgeryToken]
        public JsonResult SaveList(RefoodUserViewModel[] viewModels, int? itemId)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(RefoodUserViewModel viewModel in viewModels)
                    {
                        log.Debug(RefoodUserViewModel.FormatRefoodUserViewModel(viewModel)); 

                        if (viewModel.RefoodUserId > 0)
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

                return Json(true);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private RefoodUserDTO Create(RefoodUserViewModel viewModel)
        {
            try
            {
                log.Debug(RefoodUserViewModel.FormatRefoodUserViewModel(viewModel)); 

                RefoodUserDTO refoodUser = new RefoodUserDTO();

                // copy values
                refoodUser.RefoodUserId = viewModel.RefoodUserId;
                refoodUser.Username = viewModel.Username;
                refoodUser.Fullname = viewModel.Fullname;
                refoodUser.Email = viewModel.Email;
                refoodUser.Active = viewModel.Active;
                refoodUser.IsDeleted = viewModel.IsDeleted;

                
                // audit
                //refoodUser.CreateBy = UserInfo.UserID;
                //refoodUser.UpdateBy = UserInfo.UserID;
                refoodUser.CreateOn = DateTime.UtcNow;
                refoodUser.UpdateOn = DateTime.UtcNow;

                // add
                log.Debug("_refoodUserService.AddRefoodUser - " + RefoodUserDTO.FormatRefoodUserDTO(refoodUser)); 

                int id = _refoodUserService.AddRefoodUser(refoodUser);

                refoodUser.RefoodUserId = id;

                log.Debug("result: 'success', id: " + id); 

                return refoodUser;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private RefoodUserDTO Update(RefoodUserViewModel viewModel)
        {
            try
            {
                log.Debug(RefoodUserViewModel.FormatRefoodUserViewModel(viewModel)); 

                // get
                log.Debug("_refoodUserService.GetRefoodUser - refoodUserId: " + viewModel.RefoodUserId + " "); 

                var existingRefoodUser = _refoodUserService.GetRefoodUser(viewModel.RefoodUserId);

                log.Debug("_refoodUserService.GetRefoodUser - " + RefoodUserDTO.FormatRefoodUserDTO(existingRefoodUser)); 

                if (existingRefoodUser != null)
                {
                    // copy values
                    existingRefoodUser.Username = viewModel.Username;
                    existingRefoodUser.Fullname = viewModel.Fullname;
                    existingRefoodUser.Email = viewModel.Email;
                    existingRefoodUser.Active = viewModel.Active;
                    existingRefoodUser.IsDeleted = viewModel.IsDeleted;

                    // audit
                    //existingRefoodUser.UpdateBy = UserInfo.UserID;
                    existingRefoodUser.UpdateOn = DateTime.UtcNow;

                    // update
                    log.Debug("_refoodUserService.UpdateRefoodUser - " + RefoodUserDTO.FormatRefoodUserDTO(existingRefoodUser)); 

                    _refoodUserService.UpdateRefoodUser(existingRefoodUser);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingRefoodUser: null, RefoodUserId: " + viewModel.RefoodUserId); 
                }

                return existingRefoodUser;
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
    