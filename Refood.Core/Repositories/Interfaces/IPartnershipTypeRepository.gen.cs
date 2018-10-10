
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface IPartnershipTypeRepository
    {
        int AddPartnershipType(R_PartnershipType t);

        void DeletePartnershipType(R_PartnershipType t);

        void DeletePartnershipType(int partnershipTypeId);

        R_PartnershipType GetPartnershipType(int partnershipTypeId);

        IEnumerable<R_PartnershipType> GetPartnershipTypes();

        IList<R_PartnershipType> GetPartnershipTypes(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_PartnershipType> GetPartnershipTypeListAdvancedSearch(
            string name 
            , string description 
            , string activityType 
            , bool? active 
        );

        void UpdatePartnershipType(R_PartnershipType t);

    }
}

    