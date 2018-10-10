
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
    public partial class SupplierTypeService :  ISupplierTypeService
    {
        public static ISupplierTypeRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SupplierTypeService()
        {
            if (Repository == null)
            {
                Repository = new SupplierTypeRepository();
            }
        }

        public int AddSupplierType(SupplierTypeDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(SupplierTypeDTO.FormatSupplierTypeDTO(dto)); 

                R_SupplierType t = SupplierTypeDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddSupplierType(t);
                dto.SupplierTypeId = id;

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

        public void DeleteSupplierType(SupplierTypeDTO dto)
        {
            try
            {
                log.Debug(SupplierTypeDTO.FormatSupplierTypeDTO(dto)); 
            
                R_SupplierType t = SupplierTypeDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteSupplierType(t);
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

        public void DeleteSupplierType(int supplierTypeId)
        {
            try
            {
                log.Debug("supplierTypeId: " + supplierTypeId + " "); 

                // delete
                Repository.DeleteSupplierType(supplierTypeId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public SupplierTypeDTO GetSupplierType(int supplierTypeId)
        {
            try
            {
                //Requires.NotNegative("supplierTypeId", supplierTypeId);
                
                log.Debug("supplierTypeId: " + supplierTypeId + " "); 

                // get
                R_SupplierType t = Repository.GetSupplierType(supplierTypeId);

                SupplierTypeDTO dto = new SupplierTypeDTO(t);

                log.Debug(SupplierTypeDTO.FormatSupplierTypeDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<SupplierTypeDTO> GetSupplierTypes()
        {
            try
            {
                
                log.Debug("GetSupplierTypes"); 

                // get
                IEnumerable<R_SupplierType> results = Repository.GetSupplierTypes();

                IEnumerable<SupplierTypeDTO> resultsDTO = results.Select(e => new SupplierTypeDTO(e));

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

        public IList<SupplierTypeDTO> GetSupplierTypes(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_SupplierType> results = Repository.GetSupplierTypes(searchTerm, pageIndex, pageSize);
            
                IList<SupplierTypeDTO> resultsDTO = results.Select(e => new SupplierTypeDTO(e)).ToList();

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

        public IEnumerable<SupplierTypeDTO> GetSupplierTypeListAdvancedSearch(
             string name 
            , string description 
            , bool? active 
        )
        {
            try
            {
                log.Debug("GetSupplierTypeListAdvancedSearch"); 

                IEnumerable<R_SupplierType> results = Repository.GetSupplierTypeListAdvancedSearch(
                     name 
                    , description 
                    , active 
                );
            
                IEnumerable<SupplierTypeDTO> resultsDTO = results.Select(e => new SupplierTypeDTO(e));

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

        public void UpdateSupplierType(SupplierTypeDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "SupplierTypeId");

                log.Debug(SupplierTypeDTO.FormatSupplierTypeDTO(dto)); 

                R_SupplierType t = SupplierTypeDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateSupplierType(t);

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

    