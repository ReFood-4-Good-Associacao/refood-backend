
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
    public partial class SupplierService :  ISupplierService
    {
        public static ISupplierRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SupplierService()
        {
            if (Repository == null)
            {
                Repository = new SupplierRepository();
            }
        }

        public int AddSupplier(SupplierDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(SupplierDTO.FormatSupplierDTO(dto)); 

                R_Supplier t = SupplierDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddSupplier(t);
                dto.SupplierId = id;

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

        public void DeleteSupplier(SupplierDTO dto)
        {
            try
            {
                log.Debug(SupplierDTO.FormatSupplierDTO(dto)); 
            
                R_Supplier t = SupplierDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteSupplier(t);
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

        public void DeleteSupplier(int supplierId)
        {
            try
            {
                log.Debug("supplierId: " + supplierId + " "); 

                // delete
                Repository.DeleteSupplier(supplierId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public SupplierDTO GetSupplier(int supplierId)
        {
            try
            {
                //Requires.NotNegative("supplierId", supplierId);
                
                log.Debug("supplierId: " + supplierId + " "); 

                // get
                R_Supplier t = Repository.GetSupplier(supplierId);

                SupplierDTO dto = new SupplierDTO(t);

                log.Debug(SupplierDTO.FormatSupplierDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<SupplierDTO> GetSuppliers()
        {
            try
            {
                
                log.Debug("GetSuppliers"); 

                // get
                IEnumerable<R_Supplier> results = Repository.GetSuppliers();

                IEnumerable<SupplierDTO> resultsDTO = results.Select(e => new SupplierDTO(e));

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

        public IList<SupplierDTO> GetSuppliers(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_Supplier> results = Repository.GetSuppliers(searchTerm, pageIndex, pageSize);
            
                IList<SupplierDTO> resultsDTO = results.Select(e => new SupplierDTO(e)).ToList();

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

        public IEnumerable<SupplierDTO> GetSupplierListAdvancedSearch(
             string name 
            , int? supplierTypeId 
            , string phone 
            , string email 
            , double? latitude 
            , double? longitude 
            , string description 
            , string website 
            , int? addressId 
        )
        {
            try
            {
                log.Debug("GetSupplierListAdvancedSearch"); 

                IEnumerable<R_Supplier> results = Repository.GetSupplierListAdvancedSearch(
                     name 
                    , supplierTypeId 
                    , phone 
                    , email 
                    , latitude 
                    , longitude 
                    , description 
                    , website 
                    , addressId 
                );
            
                IEnumerable<SupplierDTO> resultsDTO = results.Select(e => new SupplierDTO(e));

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

        public void UpdateSupplier(SupplierDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "SupplierId");

                log.Debug(SupplierDTO.FormatSupplierDTO(dto)); 

                R_Supplier t = SupplierDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateSupplier(t);

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

    