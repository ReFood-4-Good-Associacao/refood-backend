
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface IPartnershipTypeService
    {
        int AddPartnershipType(PartnershipTypeDTO dto);

        void DeletePartnershipType(int partnershipTypeId);

        void DeletePartnershipType(PartnershipTypeDTO dto);

        PartnershipTypeDTO GetPartnershipType(int partnershipTypeId);

        IEnumerable<PartnershipTypeDTO> GetPartnershipTypes();

        IList<PartnershipTypeDTO> GetPartnershipTypes(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<PartnershipTypeDTO> GetPartnershipTypeListAdvancedSearch(
            string name 
            ,string description 
            ,string activityType 
            ,bool? active 
        );

        void UpdatePartnershipType(PartnershipTypeDTO dto);

    }
}
    