
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface IVehicleTypeRepository
    {
        int AddVehicleType(R_VehicleType t);

        void DeleteVehicleType(R_VehicleType t);

        void DeleteVehicleType(int vehicleTypeId);

        R_VehicleType GetVehicleType(int vehicleTypeId);

        IEnumerable<R_VehicleType> GetVehicleTypes();

        IList<R_VehicleType> GetVehicleTypes(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_VehicleType> GetVehicleTypeListAdvancedSearch(
            string name 
            , string description 
            , bool? active 
        );

        void UpdateVehicleType(R_VehicleType t);

    }
}

    