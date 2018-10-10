
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
    public partial class VehicleTypeRepository : IVehicleTypeRepository
    {
        public int AddVehicleType(R_VehicleType t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteVehicleType(R_VehicleType t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteVehicleType(int vehicleTypeId)
        {
            var t = GetVehicleType(vehicleTypeId);
            DeleteVehicleType(t);
        }

        public R_VehicleType GetVehicleType(int vehicleTypeId)
        {
            //Requires.NotNegative("vehicleTypeId", vehicleTypeId);
            
            R_VehicleType t = R_VehicleType.SingleOrDefault(vehicleTypeId);

            return t;
        }

        public IEnumerable<R_VehicleType> GetVehicleTypes()
        {
             
            IEnumerable<R_VehicleType> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_VehicleType")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_VehicleType.Query(sql);

            return results;
        }

        public IList<R_VehicleType> GetVehicleTypes(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_VehicleType> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_VehicleType")
                .Where("IsDeleted = 0")
                .Where(
                    "Name like '%" + searchTerm + "%'"
                     + " or " + "Description like '%" + searchTerm + "%'"
                )
            ;

            results = R_VehicleType.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_VehicleType> GetVehicleTypeListAdvancedSearch(
            string name 
            , string description 
            , bool? active 
        )
        {
            IEnumerable<R_VehicleType> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_VehicleType")
                .Where("IsDeleted = 0" 
                    + (name != null ? " and Name like '%" + name + "%'" : "")
                    + (description != null ? " and Description like '%" + description + "%'" : "")
                    + (active != null ? " and Active = " + (active == true ? "1" : "0") : "")
                 )
            ;

            results = R_VehicleType.Query(sql);

            return results;
        }

        public void UpdateVehicleType(R_VehicleType t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "VehicleTypeId");

            t.Update();
        }

    }
}

        