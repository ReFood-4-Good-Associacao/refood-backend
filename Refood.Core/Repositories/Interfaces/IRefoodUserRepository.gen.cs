
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface IRefoodUserRepository
    {
        int AddRefoodUser(R_RefoodUser t);

        void DeleteRefoodUser(R_RefoodUser t);

        void DeleteRefoodUser(int refoodUserId);

        R_RefoodUser GetRefoodUser(int refoodUserId);

        IEnumerable<R_RefoodUser> GetRefoodUsers();

        IList<R_RefoodUser> GetRefoodUsers(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_RefoodUser> GetRefoodUserListAdvancedSearch(
            string username 
            , string fullname 
            , string email 
            , bool? active 
        );

        void UpdateRefoodUser(R_RefoodUser t);

    }
}

    