
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
    public partial class SupplierTypeRepository : ISupplierTypeRepository
    {
        public int AddSupplierType(R_SupplierType t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteSupplierType(R_SupplierType t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteSupplierType(int supplierTypeId)
        {
            var t = GetSupplierType(supplierTypeId);
            DeleteSupplierType(t);
        }

        public R_SupplierType GetSupplierType(int supplierTypeId)
        {
            //Requires.NotNegative("supplierTypeId", supplierTypeId);
            
            R_SupplierType t = R_SupplierType.SingleOrDefault(supplierTypeId);

            return t;
        }

        public IEnumerable<R_SupplierType> GetSupplierTypes()
        {
             
            IEnumerable<R_SupplierType> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_SupplierType")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_SupplierType.Query(sql);

            return results;
        }

        public IList<R_SupplierType> GetSupplierTypes(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_SupplierType> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_SupplierType")
                .Where("IsDeleted = 0")
                .Where(
                    "Name like '%" + searchTerm + "%'"
                     + " or " + "Description like '%" + searchTerm + "%'"
                )
            ;

            results = R_SupplierType.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_SupplierType> GetSupplierTypeListAdvancedSearch(
            string name 
            , string description 
            , bool? active 
        )
        {
            IEnumerable<R_SupplierType> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_SupplierType")
                .Where("IsDeleted = 0" 
                    + (name != null ? " and Name like '%" + name + "%'" : "")
                    + (description != null ? " and Description like '%" + description + "%'" : "")
                    + (active != null ? " and Active = " + (active == true ? "1" : "0") : "")
                 )
            ;

            results = R_SupplierType.Query(sql);

            return results;
        }

        public void UpdateSupplierType(R_SupplierType t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "SupplierTypeId");

            t.Update();
        }

    }
}

        