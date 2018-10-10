
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface IEnergySourceRepository
    {
        int AddEnergySource(R_EnergySource t);

        void DeleteEnergySource(R_EnergySource t);

        void DeleteEnergySource(int energySourceId);

        R_EnergySource GetEnergySource(int energySourceId);

        IEnumerable<R_EnergySource> GetEnergySources();

        IList<R_EnergySource> GetEnergySources(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_EnergySource> GetEnergySourceListAdvancedSearch(
            string name 
            , string description 
            , bool? active 
        );

        void UpdateEnergySource(R_EnergySource t);

    }
}

    