
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
    public partial class BenificiaryMemberController : System.Web.Mvc.Controller 
    {
        private readonly IBenificiaryMemberService _benificiaryMemberService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BenificiaryMemberController(IBenificiaryMemberService benificiaryMemberService)
        {
            this._benificiaryMemberService = benificiaryMemberService;
        }

        public BenificiaryMemberController() : this(new BenificiaryMemberService()) { }


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
                log.Debug("_benificiaryMemberService.DeleteBenificiaryMember - benificiaryMemberId: " + id + " "); 

                _benificiaryMemberService.DeleteBenificiaryMember(id);

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
                log.Debug("_benificiaryMemberService.GetBenificiaryMember - benificiaryMemberId: " + id + " "); 

                var benificiaryMember = new BenificiaryMemberViewModel(_benificiaryMemberService.GetBenificiaryMember(id));

                log.Debug("_benificiaryMemberService.GetBenificiaryMember - " + BenificiaryMemberViewModel.FormatBenificiaryMemberViewModel(benificiaryMember)); 

                log.Debug("result: 'success'"); 

                //return Json(benificiaryMember, JsonRequestBehavior.AllowGet);
                return Content(JsonConvert.SerializeObject(benificiaryMember), "application/json");
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
                List<BenificiaryMemberViewModel> benificiaryMembers;

                log.Debug("_benificiaryMemberService.GetBenificiaryMembers"); 

                // add edit url
                benificiaryMembers = _benificiaryMemberService.GetBenificiaryMembers()
                        .Select(benificiaryMember => new BenificiaryMemberViewModel(benificiaryMember, GetEditUrl(benificiaryMember.BenificiaryMemberId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (benificiaryMembers != null ? benificiaryMembers.Count().ToString() : "null")); 

                //return Json(benificiaryMembers, JsonRequestBehavior.AllowGet);
                return Content(JsonConvert.SerializeObject(benificiaryMembers), "application/json");
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
                List<BenificiaryMemberViewModel> benificiaryMembers;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_benificiaryMemberService.GetBenificiaryMembers - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                benificiaryMembers = _benificiaryMemberService.GetBenificiaryMembers(searchTerm, pageIndex, pageSize)
                        .Select(benificiaryMember => new BenificiaryMemberViewModel(benificiaryMember, GetEditUrl(benificiaryMember.BenificiaryMemberId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (benificiaryMembers != null ? benificiaryMembers.Count().ToString() : "null")); 

                return Json(benificiaryMembers, JsonRequestBehavior.AllowGet);
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
            string editUrl = Url.Content("~/BenificiaryMember/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        public JsonResult Upsert(BenificiaryMemberViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.BenificiaryMemberId > 0)
            {
                var t = Update(viewModel);
                return Json(true);
            }
            else
            {
                var t = Create(viewModel);
                return Json(t.BenificiaryMemberId);
            }
        }

        //[ValidateAntiForgeryToken]
        public JsonResult SaveList(BenificiaryMemberViewModel[] viewModels, int? itemId)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(BenificiaryMemberViewModel viewModel in viewModels)
                    {
                        log.Debug(BenificiaryMemberViewModel.FormatBenificiaryMemberViewModel(viewModel)); 

                        if (viewModel.BenificiaryMemberId > 0)
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

        private BenificiaryMemberDTO Create(BenificiaryMemberViewModel viewModel)
        {
            try
            {
                log.Debug(BenificiaryMemberViewModel.FormatBenificiaryMemberViewModel(viewModel)); 

                BenificiaryMemberDTO benificiaryMember = new BenificiaryMemberDTO();

                // copy values
                benificiaryMember.BenificiaryMemberId = viewModel.BenificiaryMemberId;
                benificiaryMember.BenificiaryId = viewModel.BenificiaryId;
                benificiaryMember.Name = viewModel.Name;
                benificiaryMember.IsChild = viewModel.IsChild;
                benificiaryMember.Description = viewModel.Description;
                benificiaryMember.BirthDate = viewModel.BirthDate;
                benificiaryMember.Active = viewModel.Active;
                benificiaryMember.IsDeleted = viewModel.IsDeleted;

                
                // audit
                //benificiaryMember.CreateBy = UserInfo.UserID;
                //benificiaryMember.UpdateBy = UserInfo.UserID;
                benificiaryMember.CreateOn = DateTime.UtcNow;
                benificiaryMember.UpdateOn = DateTime.UtcNow;

                // add
                log.Debug("_benificiaryMemberService.AddBenificiaryMember - " + BenificiaryMemberDTO.FormatBenificiaryMemberDTO(benificiaryMember)); 

                int id = _benificiaryMemberService.AddBenificiaryMember(benificiaryMember);

                benificiaryMember.BenificiaryMemberId = id;

                log.Debug("result: 'success', id: " + id); 

                return benificiaryMember;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private BenificiaryMemberDTO Update(BenificiaryMemberViewModel viewModel)
        {
            try
            {
                log.Debug(BenificiaryMemberViewModel.FormatBenificiaryMemberViewModel(viewModel)); 

                // get
                log.Debug("_benificiaryMemberService.GetBenificiaryMember - benificiaryMemberId: " + viewModel.BenificiaryMemberId + " "); 

                var existingBenificiaryMember = _benificiaryMemberService.GetBenificiaryMember(viewModel.BenificiaryMemberId);

                log.Debug("_benificiaryMemberService.GetBenificiaryMember - " + BenificiaryMemberDTO.FormatBenificiaryMemberDTO(existingBenificiaryMember)); 

                if (existingBenificiaryMember != null)
                {
                    // copy values
                    existingBenificiaryMember.BenificiaryId = viewModel.BenificiaryId;
                    existingBenificiaryMember.Name = viewModel.Name;
                    existingBenificiaryMember.IsChild = viewModel.IsChild;
                    existingBenificiaryMember.Description = viewModel.Description;
                    existingBenificiaryMember.BirthDate = viewModel.BirthDate;
                    existingBenificiaryMember.Active = viewModel.Active;
                    existingBenificiaryMember.IsDeleted = viewModel.IsDeleted;

                    // audit
                    //existingBenificiaryMember.UpdateBy = UserInfo.UserID;
                    existingBenificiaryMember.UpdateOn = DateTime.UtcNow;

                    // update
                    log.Debug("_benificiaryMemberService.UpdateBenificiaryMember - " + BenificiaryMemberDTO.FormatBenificiaryMemberDTO(existingBenificiaryMember)); 

                    _benificiaryMemberService.UpdateBenificiaryMember(existingBenificiaryMember);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingBenificiaryMember: null, BenificiaryMemberId: " + viewModel.BenificiaryMemberId); 
                }

                return existingBenificiaryMember;
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
    