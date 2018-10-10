
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface IBeneficiaryRepository
    {
        int AddBeneficiary(R_Beneficiary t);

        void DeleteBeneficiary(R_Beneficiary t);

        void DeleteBeneficiary(int beneficiaryId);

        R_Beneficiary GetBeneficiary(int beneficiaryId);

        IEnumerable<R_Beneficiary> GetBeneficiarys();

        IList<R_Beneficiary> GetBeneficiarys(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_Beneficiary> GetBeneficiaryListAdvancedSearch(
            string name 
            , int? number 
            , int? addressId 
            , int? numberOfAdults 
            , int? numberOfChildren 
            , int? numberOfTupperware 
            , int? numberOfSoups 
            , string description 
            , bool? active 
        );

        void UpdateBeneficiary(R_Beneficiary t);

    }
}

    