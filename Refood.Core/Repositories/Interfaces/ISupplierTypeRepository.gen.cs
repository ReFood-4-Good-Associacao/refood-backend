
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface ISupplierTypeRepository
    {
        int AddSupplierType(R_SupplierType t);

        void DeleteSupplierType(R_SupplierType t);

        void DeleteSupplierType(int supplierTypeId);

        R_SupplierType GetSupplierType(int supplierTypeId);

        IEnumerable<R_SupplierType> GetSupplierTypes();

        IList<R_SupplierType> GetSupplierTypes(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_SupplierType> GetSupplierTypeListAdvancedSearch(
            string name 
            , string description 
            , bool? active 
        );

        void UpdateSupplierType(R_SupplierType t);

    }
}

    