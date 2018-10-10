
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
    public partial class TutorialService :  ITutorialService
    {
        public static ITutorialRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TutorialService()
        {
            if (Repository == null)
            {
                Repository = new TutorialRepository();
            }
        }

        public int AddTutorial(TutorialDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(TutorialDTO.FormatTutorialDTO(dto)); 

                R_Tutorial t = TutorialDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddTutorial(t);
                dto.TutorialId = id;

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

        public void DeleteTutorial(TutorialDTO dto)
        {
            try
            {
                log.Debug(TutorialDTO.FormatTutorialDTO(dto)); 
            
                R_Tutorial t = TutorialDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteTutorial(t);
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

        public void DeleteTutorial(int tutorialId)
        {
            try
            {
                log.Debug("tutorialId: " + tutorialId + " "); 

                // delete
                Repository.DeleteTutorial(tutorialId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public TutorialDTO GetTutorial(int tutorialId)
        {
            try
            {
                //Requires.NotNegative("tutorialId", tutorialId);
                
                log.Debug("tutorialId: " + tutorialId + " "); 

                // get
                R_Tutorial t = Repository.GetTutorial(tutorialId);

                TutorialDTO dto = new TutorialDTO(t);

                log.Debug(TutorialDTO.FormatTutorialDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<TutorialDTO> GetTutorials()
        {
            try
            {
                
                log.Debug("GetTutorials"); 

                // get
                IEnumerable<R_Tutorial> results = Repository.GetTutorials();

                IEnumerable<TutorialDTO> resultsDTO = results.Select(e => new TutorialDTO(e));

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

        public IList<TutorialDTO> GetTutorials(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_Tutorial> results = Repository.GetTutorials(searchTerm, pageIndex, pageSize);
            
                IList<TutorialDTO> resultsDTO = results.Select(e => new TutorialDTO(e)).ToList();

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

        public IEnumerable<TutorialDTO> GetTutorialListAdvancedSearch(
             string name 
            , string description 
            , string location 
            , bool? isOnlineTutorial 
            , string language 
            , bool? active 
        )
        {
            try
            {
                log.Debug("GetTutorialListAdvancedSearch"); 

                IEnumerable<R_Tutorial> results = Repository.GetTutorialListAdvancedSearch(
                     name 
                    , description 
                    , location 
                    , isOnlineTutorial 
                    , language 
                    , active 
                );
            
                IEnumerable<TutorialDTO> resultsDTO = results.Select(e => new TutorialDTO(e));

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

        public void UpdateTutorial(TutorialDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "TutorialId");

                log.Debug(TutorialDTO.FormatTutorialDTO(dto)); 

                R_Tutorial t = TutorialDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateTutorial(t);

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

    