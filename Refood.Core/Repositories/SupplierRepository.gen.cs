
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;
using Refood.Core.Repositories.Interfaces;

namespace Refood.Core.Repositories
{
    public partial class SupplierRepository : ISupplierRepository
    {
        public int AddSupplier(R_Supplier t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteSupplier(R_Supplier t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteSupplier(int supplierId)
        {
            var t = GetSupplier(supplierId);
            DeleteSupplier(t);
        }

        public R_Supplier GetSupplier(int supplierId)
        {
            //Requires.NotNegative("supplierId", supplierId);
            
            R_Supplier t = R_Supplier.SingleOrDefault(supplierId);

            return t;
        }

        public IEnumerable<R_Supplier> GetSuppliers()
        {
             
            IEnumerable<R_Supplier> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Supplier")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_Supplier.Query(sql);

            return results;
        }

        public IList<R_Supplier> GetSuppliers(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_Supplier> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Supplier")
                .Where("IsDeleted = 0")
                .Where(
                    "Name like '%" + searchTerm + "%'"
                     + " or " + "Phone like '%" + searchTerm + "%'"
                     + " or " + "Email like '%" + searchTerm + "%'"
                     + " or " + "Description like '%" + searchTerm + "%'"
                     + " or " + "Website like '%" + searchTerm + "%'"
                )
            ;

            results = R_Supplier.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_Supplier> GetSupplierListAdvancedSearch(
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
            IEnumerable<R_Supplier> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Supplier")
                .Where("IsDeleted = 0" 
                    + (name != null ? " and Name like '%" + name + "%'" : "")
                    + (supplierTypeId != null ? " and SupplierTypeId = " + supplierTypeId : "")
                    + (phone != null ? " and Phone like '%" + phone + "%'" : "")
                    + (email != null ? " and Email like '%" + email + "%'" : "")
                    + (latitude != null ? " and Latitude like '%" + latitude + "%'" : "")
                    + (longitude != null ? " and Longitude like '%" + longitude + "%'" : "")
                    + (description != null ? " and Description like '%" + description + "%'" : "")
                    + (website != null ? " and Website like '%" + website + "%'" : "")
                    + (addressId != null ? " and AddressId like '%" + addressId + "%'" : "")
                 )
            ;

            results = R_Supplier.Query(sql);

            return results;
        }

        public void UpdateSupplier(R_Supplier t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "SupplierId");

            t.Update();
        }

    }
}

        