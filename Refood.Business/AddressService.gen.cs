
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;
using Refood.Core.Repositories;
using Refood.Core.Repositories.Interfaces;
using Refood.Business.DTOs;
using Refood.Business.Interfaces;

namespace Refood.Business
{
    public partial class AddressService :  IAddressService
    {
        public static IAddressRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public AddressService()
        {
            if (Repository == null)
            {
                Repository = new AddressRepository();
            }
        }

        public int AddAddress(AddressDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(AddressDTO.FormatAddressDTO(dto)); 

                R_Address t = AddressDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddAddress(t);
                dto.AddressId = id;

                log.Debug("result: 'success', id: " + id); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }

            return id;
        }

        public void DeleteAddress(AddressDTO dto)
        {
            try
            {
                log.Debug(AddressDTO.FormatAddressDTO(dto)); 
            
                R_Address t = AddressDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteAddress(t);
                dto.IsDeleted = t.IsDeleted;

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public void DeleteAddress(int addressId)
        {
            try
            {
                log.Debug("addressId: " + addressId + " "); 

                // delete
                Repository.DeleteAddress(addressId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public AddressDTO GetAddress(int addressId)
        {
            try
            {
                //Requires.NotNegative("addressId", addressId);
                
                log.Debug("addressId: " + addressId + " "); 

                // get
                R_Address t = Repository.GetAddress(addressId);

                AddressDTO dto = new AddressDTO(t);

                log.Debug(AddressDTO.FormatAddressDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<AddressDTO> GetAddresss()
        {
            try
            {
                
                log.Debug("GetAddresss"); 

                // get
                IEnumerable<R_Address> results = Repository.GetAddresss();

                IEnumerable<AddressDTO> resultsDTO = results.Select(e => new AddressDTO(e));

                log.Debug("result: 'success', count: " + (resultsDTO != null ? resultsDTO.Count().ToString() : "null")); 

                return resultsDTO;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IList<AddressDTO> GetAddresss(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_Address> results = Repository.GetAddresss(searchTerm, pageIndex, pageSize);
            
                IList<AddressDTO> resultsDTO = results.Select(e => new AddressDTO(e)).ToList();

                log.Debug("result: 'success', count: " + (resultsDTO != null ? resultsDTO.Count().ToString() : "null")); 

                return resultsDTO;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<AddressDTO> GetAddressListAdvancedSearch(
             string name 
            , string addressFirstLine 
            , string addressSecondLine 
            , int? countryId 
            , int? districtId 
            , int? countyId 
            , int? parishId 
            , string zipCode 
            , double? latitude 
            , double? longitude 
            , bool? active 
        )
        {
            try
            {
                log.Debug("GetAddressListAdvancedSearch"); 

                IEnumerable<R_Address> results = Repository.GetAddressListAdvancedSearch(
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
            
                IEnumerable<AddressDTO> resultsDTO = results.Select(e => new AddressDTO(e));

                log.Debug("result: 'success', count: " + (resultsDTO != null ? resultsDTO.Count().ToString() : "null")); 

                return resultsDTO;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public void UpdateAddress(AddressDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "AddressId");

                log.Debug(AddressDTO.FormatAddressDTO(dto)); 

                R_Address t = AddressDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateAddress(t);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

    }
}

    