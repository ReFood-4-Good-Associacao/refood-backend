
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface IBeneficiaryService
    {
        int AddBeneficiary(BeneficiaryDTO dto);

        void DeleteBeneficiary(int beneficiaryId);

        void DeleteBeneficiary(BeneficiaryDTO dto);

        BeneficiaryDTO GetBeneficiary(int beneficiaryId);

        IEnumerable<BeneficiaryDTO> GetBeneficiarys();

        IList<BeneficiaryDTO> GetBeneficiarys(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<BeneficiaryDTO> GetBeneficiaryListAdvancedSearch(
            string name 
            ,int? number 
            ,int? addressId 
            ,int? numberOfAdults 
            ,int? numberOfChildren 
            ,int? numberOfTupperware 
            ,int? numberOfSoups 
            ,string description 
            ,bool? active 
        );

        void UpdateBeneficiary(BeneficiaryDTO dto);

    }
}
    