
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
    public partial class EnergySourceService :  IEnergySourceService
    {
        public static IEnergySourceRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public EnergySourceService()
        {
            if (Repository == null)
            {
                Repository = new EnergySourceRepository();
            }
        }

        public int AddEnergySource(EnergySourceDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(EnergySourceDTO.FormatEnergySourceDTO(dto)); 

                R_EnergySource t = EnergySourceDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddEnergySource(t);
                dto.EnergySourceId = id;

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

        public void DeleteEnergySource(EnergySourceDTO dto)
        {
            try
            {
                log.Debug(EnergySourceDTO.FormatEnergySourceDTO(dto)); 
            
                R_EnergySource t = EnergySourceDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteEnergySource(t);
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

        public void DeleteEnergySource(int energySourceId)
        {
            try
            {
                log.Debug("energySourceId: " + energySourceId + " "); 

                // delete
                Repository.DeleteEnergySource(energySourceId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public EnergySourceDTO GetEnergySource(int energySourceId)
        {
            try
            {
                //Requires.NotNegative("energySourceId", energySourceId);
                
                log.Debug("energySourceId: " + energySourceId + " "); 

                // get
                R_EnergySource t = Repository.GetEnergySource(energySourceId);

                EnergySourceDTO dto = new EnergySourceDTO(t);

                log.Debug(EnergySourceDTO.FormatEnergySourceDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<EnergySourceDTO> GetEnergySources()
        {
            try
            {
                
                log.Debug("GetEnergySources"); 

                // get
                IEnumerable<R_EnergySource> results = Repository.GetEnergySources();

                IEnumerable<EnergySourceDTO> resultsDTO = results.Select(e => new EnergySourceDTO(e));

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

        public IList<EnergySourceDTO> GetEnergySources(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_EnergySource> results = Repository.GetEnergySources(searchTerm, pageIndex, pageSize);
            
                IList<EnergySourceDTO> resultsDTO = results.Select(e => new EnergySourceDTO(e)).ToList();

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

        public IEnumerable<EnergySourceDTO> GetEnergySourceListAdvancedSearch(
             string name 
            , string description 
            , bool? active 
        )
        {
            try
            {
                log.Debug("GetEnergySourceListAdvancedSearch"); 

                IEnumerable<R_EnergySource> results = Repository.GetEnergySourceListAdvancedSearch(
                     name 
                    , description 
                    , active 
                );
            
                IEnumerable<EnergySourceDTO> resultsDTO = results.Select(e => new EnergySourceDTO(e));

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

        public void UpdateEnergySource(EnergySourceDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "EnergySourceId");

                log.Debug(EnergySourceDTO.FormatEnergySourceDTO(dto)); 

                R_EnergySource t = EnergySourceDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateEnergySource(t);

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

    