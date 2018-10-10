
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface IBenificiaryMemberService
    {
        int AddBenificiaryMember(BenificiaryMemberDTO dto);

        void DeleteBenificiaryMember(int itemId);

        void DeleteBenificiaryMember(BenificiaryMemberDTO dto);

        BenificiaryMemberDTO GetBenificiaryMember(int itemId);

        IEnumerable<BenificiaryMemberDTO> GetBenificiaryMembers();

        IList<BenificiaryMemberDTO> GetBenificiaryMembers(string searchTerm, int pageIndex, int pageSize);

        void UpdateBenificiaryMember(BenificiaryMemberDTO dto);

    }
}
    