
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface INucleoRepository
    {
        int AddNucleo(R_Nucleo t);

        void DeleteNucleo(R_Nucleo t);

        void DeleteNucleo(int nucleoId);

        R_Nucleo GetNucleo(int nucleoId);

        IEnumerable<R_Nucleo> GetNucleos();

        IList<R_Nucleo> GetNucleos(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_Nucleo> GetNucleoListAdvancedSearch(
            string name 
            , string personResponsible 
            , int? photo 
            , int? addressId 
            , System.DateTime? openingDateFrom 
            , System.DateTime? openingDateTo 
            , string primaryPhoneNumber 
            , string primaryEmail 
            , bool? active 
        );

        void UpdateNucleo(R_Nucleo t);

    }
}

    