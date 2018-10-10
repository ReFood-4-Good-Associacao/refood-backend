
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
    public partial class AddressController : System.Web.Mvc.Controller 
    {
        private readonly IAddressService _addressService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public AddressController(IAddressService addressService)
        {
            this._addressService = addressService;
        }

        public AddressController() : this(new AddressService()) { }


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
                log.Debug("_addressService.DeleteAddress - addressId: " + id + " "); 

                _addressService.DeleteAddress(id);

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
                log.Debug("_addressService.GetAddress - addressId: " + id + " "); 

                var address = new AddressViewModel(_addressService.GetAddress(id));

                log.Debug("_addressService.GetAddress - " + AddressViewModel.FormatAddressViewModel(address)); 

                log.Debug("result: 'success'"); 

                //return Json(address, JsonRequestBehavior.AllowGet);
                return Content(JsonConvert.SerializeObject(address), "application/json");
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
                List<AddressViewModel> addresss;

                log.Debug("_addressService.GetAddresss"); 

                // add edit url
                addresss = _addressService.GetAddresss()
                        .Select(address => new AddressViewModel(address, GetEditUrl(address.AddressId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (addresss != null ? addresss.Count().ToString() : "null")); 

                //return Json(addresss, JsonRequestBehavior.AllowGet);
                return Content(JsonConvert.SerializeObject(addresss), "application/json");
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
                List<AddressViewModel> addresss;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_addressService.GetAddresss - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                addresss = _addressService.GetAddresss(searchTerm, pageIndex, pageSize)
                        .Select(address => new AddressViewModel(address, GetEditUrl(address.AddressId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (addresss != null ? addresss.Count().ToString() : "null")); 

                return Json(addresss, JsonRequestBehavior.AllowGet);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public ActionResult GetListAdvancedSearch(
            int itemId = 0 
            , string name = null 
            , string addressFirstLine = null 
            , string addressSecondLine = null 
            , int? countryId = null 
            , int? districtId = null 
            , int? countyId = null 
            , int? parishId = null 
            , string zipCode = null 
            , double? latitude = null 
            , double? longitude = null 
            , bool? active = null 
        )
        {
            try
            {
                // advanced search

                log.Debug("GetAddressListAdvancedSearch"); 

                IEnumerable<AddressDTO> resultsDTO = _addressService.GetAddressListAdvancedSearch(
                     name 
                    , addressFirstLine 
                    , addressSecondLine 
                    , countryId 
                    , districtId 
                    , countyId 
                    , parishId 
                    , zipCode 
                    , latitude 
                    , longitude 
                    , active 
                );
            
                // convert to view model list, and add edit url
                List<AddressViewModel> addressList = resultsDTO.Select(address => new AddressViewModel(address, GetEditUrl(address.AddressId))).ToList();

                log.Debug("result: 'success', count: " + (addressList != null ? addressList.Count().ToString() : "null")); 

                return Content(JsonConvert.SerializeObject(addressList), "application/json");
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
            string editUrl = Url.Content("~/Address/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        public JsonResult Upsert(AddressViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.AddressId > 0)
            {
                var t = Update(viewModel);
                return Json(true);
            }
            else
            {
                var t = Create(viewModel);
                return Json(t.AddressId);
            }
        }

        //[ValidateAntiForgeryToken]
        public JsonResult SaveList(AddressViewModel[] viewModels, int? itemId)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(AddressViewModel viewModel in viewModels)
                    {
                        log.Debug(AddressViewModel.FormatAddressViewModel(viewModel)); 

                        if (viewModel.AddressId > 0)
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

        private AddressDTO Create(AddressViewModel viewModel)
        {
            try
            {
                log.Debug(AddressViewModel.FormatAddressViewModel(viewModel)); 

                AddressDTO address = new AddressDTO();

                // copy values
                address.AddressId = viewModel.AddressId;
                address.Name = viewModel.Name;
                address.AddressFirstLine = viewModel.AddressFirstLine;
                address.AddressSecondLine = viewModel.AddressSecondLine;
                address.CountryId = viewModel.CountryId;
                address.DistrictId = viewModel.DistrictId;
                address.CountyId = viewModel.CountyId;
                address.ParishId = viewModel.ParishId;
                address.ZipCode = viewModel.ZipCode;
                address.Latitude = viewModel.Latitude;
                address.Longitude = viewModel.Longitude;
                address.Active = viewModel.Active;
                address.IsDeleted = viewModel.IsDeleted;

                
                // audit
                //address.CreateBy = UserInfo.UserID;
                //address.UpdateBy = UserInfo.UserID;
                address.CreateOn = DateTime.UtcNow;
                address.UpdateOn = DateTime.UtcNow;

                // add
                log.Debug("_addressService.AddAddress - " + AddressDTO.FormatAddressDTO(address)); 

                int id = _addressService.AddAddress(address);

                address.AddressId = id;

                log.Debug("result: 'success', id: " + id); 

                return address;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private AddressDTO Update(AddressViewModel viewModel)
        {
            try
            {
                log.Debug(AddressViewModel.FormatAddressViewModel(viewModel)); 

                // get
                log.Debug("_addressService.GetAddress - addressId: " + viewModel.AddressId + " "); 

                var existingAddress = _addressService.GetAddress(viewModel.AddressId);

                log.Debug("_addressService.GetAddress - " + AddressDTO.FormatAddressDTO(existingAddress)); 

                if (existingAddress != null)
                {
                    // copy values
                    existingAddress.Name = viewModel.Name;
                    existingAddress.AddressFirstLine = viewModel.AddressFirstLine;
                    existingAddress.AddressSecondLine = viewModel.AddressSecondLine;
                    existingAddress.CountryId = viewModel.CountryId;
                    existingAddress.DistrictId = viewModel.DistrictId;
                    existingAddress.CountyId = viewModel.CountyId;
                    existingAddress.ParishId = viewModel.ParishId;
                    existingAddress.ZipCode = viewModel.ZipCode;
                    existingAddress.Latitude = viewModel.Latitude;
                    existingAddress.Longitude = viewModel.Longitude;
                    existingAddress.Active = viewModel.Active;
                    existingAddress.IsDeleted = viewModel.IsDeleted;

                    // audit
                    //existingAddress.UpdateBy = UserInfo.UserID;
                    existingAddress.UpdateOn = DateTime.UtcNow;

                    // update
                    log.Debug("_addressService.UpdateAddress - " + AddressDTO.FormatAddressDTO(existingAddress)); 

                    _addressService.UpdateAddress(existingAddress);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingAddress: null, AddressId: " + viewModel.AddressId); 
                }

                return existingAddress;
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
    