
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface ISupplierRepository
    {
        int AddSupplier(R_Supplier t);

        void DeleteSupplier(R_Supplier t);

        void DeleteSupplier(int supplierId);

        R_Supplier GetSupplier(int supplierId);

        IEnumerable<R_Supplier> GetSuppliers();

        IList<R_Supplier> GetSuppliers(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_Supplier> GetSupplierListAdvancedSearch(
            string name 
            , int? supplierTypeId 
            , string phone 
            , string email 
            , double? latitude 
            , double? longitude 
            , string description 
            , string website 
            , int? addressId 
        );

        void UpdateSupplier(R_Supplier t);

    }
}

    