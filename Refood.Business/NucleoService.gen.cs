
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
    public partial class NucleoService :  INucleoService
    {
        public static INucleoRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public NucleoService()
        {
            if (Repository == null)
            {
                Repository = new NucleoRepository();
            }
        }

        public int AddNucleo(NucleoDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(NucleoDTO.FormatNucleoDTO(dto)); 

                R_Nucleo t = NucleoDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddNucleo(t);
                dto.NucleoId = id;

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

        public void DeleteNucleo(NucleoDTO dto)
        {
            try
            {
                log.Debug(NucleoDTO.FormatNucleoDTO(dto)); 
            
                R_Nucleo t = NucleoDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteNucleo(t);
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

        public void DeleteNucleo(int nucleoId)
        {
            try
            {
                log.Debug("nucleoId: " + nucleoId + " "); 

                // delete
                Repository.DeleteNucleo(nucleoId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public NucleoDTO GetNucleo(int nucleoId)
        {
            try
            {
                //Requires.NotNegative("nucleoId", nucleoId);
                
                log.Debug("nucleoId: " + nucleoId + " "); 

                // get
                R_Nucleo t = Repository.GetNucleo(nucleoId);

                NucleoDTO dto = new NucleoDTO(t);

                log.Debug(NucleoDTO.FormatNucleoDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<NucleoDTO> GetNucleos()
        {
            try
            {
                
                log.Debug("GetNucleos"); 

                // get
                IEnumerable<R_Nucleo> results = Repository.GetNucleos();

                IEnumerable<NucleoDTO> resultsDTO = results.Select(e => new NucleoDTO(e));

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

        public IList<NucleoDTO> GetNucleos(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_Nucleo> results = Repository.GetNucleos(searchTerm, pageIndex, pageSize);
            
                IList<NucleoDTO> resultsDTO = results.Select(e => new NucleoDTO(e)).ToList();

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

        public IEnumerable<NucleoDTO> GetNucleoListAdvancedSearch(
             string name 
            , string personResponsible 
            , int? photo 
            , int? addressId 
            , System.DateTime? openingDateFrom 
            , System.DateTime? openingDateTo 
            , string primaryPhoneNumber 
            , string primaryEmail 
            , bool? active 
        )
        {
            try
            {
                log.Debug("GetNucleoListAdvancedSearch"); 

                IEnumerable<R_Nucleo> results = Repository.GetNucleoListAdvancedSearch(
                     name 
                    , personResponsible 
                    , photo 
                    , addressId 
                    , openingDateFrom 
                    , openingDateTo 
                    , primaryPhoneNumber 
                    , primaryEmail 
                    , active 
                );
            
                IEnumerable<NucleoDTO> resultsDTO = results.Select(e => new NucleoDTO(e));

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

        public void UpdateNucleo(NucleoDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "NucleoId");

                log.Debug(NucleoDTO.FormatNucleoDTO(dto)); 

                R_Nucleo t = NucleoDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateNucleo(t);

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

    