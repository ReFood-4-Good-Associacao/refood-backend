
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
    public partial class EnergySourceRepository : IEnergySourceRepository
    {
        public int AddEnergySource(R_EnergySource t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteEnergySource(R_EnergySource t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteEnergySource(int energySourceId)
        {
            var t = GetEnergySource(energySourceId);
            DeleteEnergySource(t);
        }

        public R_EnergySource GetEnergySource(int energySourceId)
        {
            //Requires.NotNegative("energySourceId", energySourceId);
            
            R_EnergySource t = R_EnergySource.SingleOrDefault(energySourceId);

            return t;
        }

        public IEnumerable<R_EnergySource> GetEnergySources()
        {
             
            IEnumerable<R_EnergySource> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_EnergySource")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_EnergySource.Query(sql);

            return results;
        }

        public IList<R_EnergySource> GetEnergySources(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_EnergySource> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_EnergySource")
                .Where("IsDeleted = 0")
                .Where(
                    "Name like '%" + searchTerm + "%'"
                     + " or " + "Description like '%" + searchTerm + "%'"
                )
            ;

            results = R_EnergySource.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_EnergySource> GetEnergySourceListAdvancedSearch(
            string name 
            , string description 
            , bool? active 
        )
        {
            IEnumerable<R_EnergySource> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_EnergySource")
                .Where("IsDeleted = 0" 
                    + (name != null ? " and Name like '%" + name + "%'" : "")
                    + (description != null ? " and Description like '%" + description + "%'" : "")
                    + (active != null ? " and Active = " + (active == true ? "1" : "0") : "")
                 )
            ;

            results = R_EnergySource.Query(sql);

            return results;
        }

        public void UpdateEnergySource(R_EnergySource t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "EnergySourceId");

            t.Update();
        }

    }
}

        