
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface ISupplierTypeService
    {
        int AddSupplierType(SupplierTypeDTO dto);

        void DeleteSupplierType(int supplierTypeId);

        void DeleteSupplierType(SupplierTypeDTO dto);

        SupplierTypeDTO GetSupplierType(int supplierTypeId);

        IEnumerable<SupplierTypeDTO> GetSupplierTypes();

        IList<SupplierTypeDTO> GetSupplierTypes(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<SupplierTypeDTO> GetSupplierTypeListAdvancedSearch(
            string name 
            ,string description 
            ,bool? active 
        );

        void UpdateSupplierType(SupplierTypeDTO dto);

    }
}
    