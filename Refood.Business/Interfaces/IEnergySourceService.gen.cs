
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface IEnergySourceService
    {
        int AddEnergySource(EnergySourceDTO dto);

        void DeleteEnergySource(int energySourceId);

        void DeleteEnergySource(EnergySourceDTO dto);

        EnergySourceDTO GetEnergySource(int energySourceId);

        IEnumerable<EnergySourceDTO> GetEnergySources();

        IList<EnergySourceDTO> GetEnergySources(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<EnergySourceDTO> GetEnergySourceListAdvancedSearch(
            string name 
            ,string description 
            ,bool? active 
        );

        void UpdateEnergySource(EnergySourceDTO dto);

    }
}
    