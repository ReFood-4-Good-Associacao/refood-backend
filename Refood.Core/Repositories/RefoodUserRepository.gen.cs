
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;
using Refood.Core.Repositories.Interfaces;

namespace Refood.Core.Repositories
{
    public partial class RefoodUserRepository : IRefoodUserRepository
    {
        public int AddRefoodUser(R_RefoodUser t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteRefoodUser(R_RefoodUser t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteRefoodUser(int refoodUserId)
        {
            var t = GetRefoodUser(refoodUserId);
            DeleteRefoodUser(t);
        }

        public R_RefoodUser GetRefoodUser(int refoodUserId)
        {
            //Requires.NotNegative("refoodUserId", refoodUserId);
            
            R_RefoodUser t = R_RefoodUser.SingleOrDefault(refoodUserId);

            return t;
        }

        public IEnumerable<R_RefoodUser> GetRefoodUsers()
        {
             
            IEnumerable<R_RefoodUser> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_RefoodUser")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_RefoodUser.Query(sql);

            return results;
        }

        public IList<R_RefoodUser> GetRefoodUsers(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_RefoodUser> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_RefoodUser")
                .Where("IsDeleted = 0")
                .Where(
                    "Username like '%" + searchTerm + "%'"
                     + " or " + "Fullname like '%" + searchTerm + "%'"
                     + " or " + "Email like '%" + searchTerm + "%'"
                )
            ;

            results = R_RefoodUser.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_RefoodUser> GetRefoodUserListAdvancedSearch(
            string username 
            , string fullname 
            , string email 
            , bool? active 
        )
        {
            IEnumerable<R_RefoodUser> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_RefoodUser")
                .Where("IsDeleted = 0" 
                    + (username != null ? " and Username like '%" + username + "%'" : "")
                    + (fullname != null ? " and Fullname like '%" + fullname + "%'" : "")
                    + (email != null ? " and Email like '%" + email + "%'" : "")
                    + (active != null ? " and Active = " + (active == true ? "1" : "0") : "")
                 )
            ;

            results = R_RefoodUser.Query(sql);

            return results;
        }

        public void UpdateRefoodUser(R_RefoodUser t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "RefoodUserId");

            t.Update();
        }

    }
}

        