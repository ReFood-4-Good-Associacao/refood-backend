
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface IVehicleTypeService
    {
        int AddVehicleType(VehicleTypeDTO dto);

        void DeleteVehicleType(int vehicleTypeId);

        void DeleteVehicleType(VehicleTypeDTO dto);

        VehicleTypeDTO GetVehicleType(int vehicleTypeId);

        IEnumerable<VehicleTypeDTO> GetVehicleTypes();

        IList<VehicleTypeDTO> GetVehicleTypes(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<VehicleTypeDTO> GetVehicleTypeListAdvancedSearch(
            string name 
            ,string description 
            ,bool? active 
        );

        void UpdateVehicleType(VehicleTypeDTO dto);

    }
}
    