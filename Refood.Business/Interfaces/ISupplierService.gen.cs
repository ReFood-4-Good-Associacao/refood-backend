
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface ISupplierService
    {
        int AddSupplier(SupplierDTO dto);

        void DeleteSupplier(int supplierId);

        void DeleteSupplier(SupplierDTO dto);

        SupplierDTO GetSupplier(int supplierId);

        IEnumerable<SupplierDTO> GetSuppliers();

        IList<SupplierDTO> GetSuppliers(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<SupplierDTO> GetSupplierListAdvancedSearch(
            string name 
            ,int? supplierTypeId 
            ,string phone 
            ,string email 
            ,double? latitude 
            ,double? longitude 
            ,string description 
            ,string website 
            ,int? addressId 
        );

        void UpdateSupplier(SupplierDTO dto);

    }
}
    