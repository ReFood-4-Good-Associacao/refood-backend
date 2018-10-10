
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface IRefoodUserService
    {
        int AddRefoodUser(RefoodUserDTO dto);

        void DeleteRefoodUser(int refoodUserId);

        void DeleteRefoodUser(RefoodUserDTO dto);

        RefoodUserDTO GetRefoodUser(int refoodUserId);

        IEnumerable<RefoodUserDTO> GetRefoodUsers();

        IList<RefoodUserDTO> GetRefoodUsers(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<RefoodUserDTO> GetRefoodUserListAdvancedSearch(
            string username 
            ,string fullname 
            ,string email 
            ,bool? active 
        );

        void UpdateRefoodUser(RefoodUserDTO dto);

    }
}
    