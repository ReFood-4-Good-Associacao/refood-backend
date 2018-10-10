
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface IBenificiaryMemberRepository
    {
        int AddBenificiaryMember(R_BenificiaryMember t);

        void DeleteBenificiaryMember(R_BenificiaryMember t);

        void DeleteBenificiaryMember(int benificiaryMemberId);

        R_BenificiaryMember GetBenificiaryMember(int benificiaryMemberId);

        IEnumerable<R_BenificiaryMember> GetBenificiaryMembers();

        IList<R_BenificiaryMember> GetBenificiaryMembers(string searchTerm, int pageIndex, int pageSize);

        void UpdateBenificiaryMember(R_BenificiaryMember t);

    }
}

    