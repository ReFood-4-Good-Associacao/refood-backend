
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
    public partial class WeekDayService :  IWeekDayService
    {
        public static IWeekDayRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WeekDayService()
        {
            if (Repository == null)
            {
                Repository = new WeekDayRepository();
            }
        }

        public int AddWeekDay(WeekDayDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(WeekDayDTO.FormatWeekDayDTO(dto)); 

                R_WeekDay t = WeekDayDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddWeekDay(t);
                dto.WeekDayId = id;

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

        public void DeleteWeekDay(WeekDayDTO dto)
        {
            try
            {
                log.Debug(WeekDayDTO.FormatWeekDayDTO(dto)); 
            
                R_WeekDay t = WeekDayDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteWeekDay(t);
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

        public void DeleteWeekDay(int weekDayId)
        {
            try
            {
                log.Debug("weekDayId: " + weekDayId + " "); 

                // delete
                Repository.DeleteWeekDay(weekDayId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public WeekDayDTO GetWeekDay(int weekDayId)
        {
            try
            {
                //Requires.NotNegative("weekDayId", weekDayId);
                
                log.Debug("weekDayId: " + weekDayId + " "); 

                // get
                R_WeekDay t = Repository.GetWeekDay(weekDayId);

                WeekDayDTO dto = new WeekDayDTO(t);

                log.Debug(WeekDayDTO.FormatWeekDayDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<WeekDayDTO> GetWeekDays()
        {
            try
            {
                
                log.Debug("GetWeekDays"); 

                // get
                IEnumerable<R_WeekDay> results = Repository.GetWeekDays();

                IEnumerable<WeekDayDTO> resultsDTO = results.Select(e => new WeekDayDTO(e));

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

        public IList<WeekDayDTO> GetWeekDays(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_WeekDay> results = Repository.GetWeekDays(searchTerm, pageIndex, pageSize);
            
                IList<WeekDayDTO> resultsDTO = results.Select(e => new WeekDayDTO(e)).ToList();

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

        public IEnumerable<WeekDayDTO> GetWeekDayListAdvancedSearch(
             int? nucleoId 
            , string name 
            , string description 
            , int? responsiblePersonId 
            , bool? active 
        )
        {
            try
            {
                log.Debug("GetWeekDayListAdvancedSearch"); 

                IEnumerable<R_WeekDay> results = Repository.GetWeekDayListAdvancedSearch(
                     nucleoId 
                    , name 
                    , description 
                    , responsiblePersonId 
                    , active 
                );
            
                IEnumerable<WeekDayDTO> resultsDTO = results.Select(e => new WeekDayDTO(e));

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

        public void UpdateWeekDay(WeekDayDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "WeekDayId");

                log.Debug(WeekDayDTO.FormatWeekDayDTO(dto)); 

                R_WeekDay t = WeekDayDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateWeekDay(t);

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

    