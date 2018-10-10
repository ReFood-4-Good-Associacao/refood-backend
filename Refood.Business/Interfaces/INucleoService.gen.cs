
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface INucleoService
    {
        int AddNucleo(NucleoDTO dto);

        void DeleteNucleo(int nucleoId);

        void DeleteNucleo(NucleoDTO dto);

        NucleoDTO GetNucleo(int nucleoId);

        IEnumerable<NucleoDTO> GetNucleos();

        IList<NucleoDTO> GetNucleos(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<NucleoDTO> GetNucleoListAdvancedSearch(
            string name 
            ,string personResponsible 
            ,int? photo 
            ,int? addressId 
            ,System.DateTime? openingDateFrom 
            ,System.DateTime? openingDateTo 
            ,string primaryPhoneNumber 
            ,string primaryEmail 
            ,bool? active 
        );

        void UpdateNucleo(NucleoDTO dto);

    }
}
    