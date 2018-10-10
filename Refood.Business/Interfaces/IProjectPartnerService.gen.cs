
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface IProjectPartnerService
    {
        int AddProjectPartner(ProjectPartnerDTO dto);

        void DeleteProjectPartner(int projectPartnerId);

        void DeleteProjectPartner(ProjectPartnerDTO dto);

        ProjectPartnerDTO GetProjectPartner(int projectPartnerId);

        IEnumerable<ProjectPartnerDTO> GetProjectPartners();

        IList<ProjectPartnerDTO> GetProjectPartners(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<ProjectPartnerDTO> GetProjectPartnerListAdvancedSearch(
            int? projectId 
            ,int? partnerId 
            ,double? grantValue 
        );

        void UpdateProjectPartner(ProjectPartnerDTO dto);

    }
}
    