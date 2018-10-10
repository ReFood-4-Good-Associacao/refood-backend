
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface IProjectPartnerRepository
    {
        int AddProjectPartner(R_ProjectPartner t);

        void DeleteProjectPartner(R_ProjectPartner t);

        void DeleteProjectPartner(int projectPartnerId);

        R_ProjectPartner GetProjectPartner(int projectPartnerId);

        IEnumerable<R_ProjectPartner> GetProjectPartners();

        IList<R_ProjectPartner> GetProjectPartners(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_ProjectPartner> GetProjectPartnerListAdvancedSearch(
            int? projectId 
            , int? partnerId 
            , double? grantValue 
        );

        void UpdateProjectPartner(R_ProjectPartner t);

    }
}

    