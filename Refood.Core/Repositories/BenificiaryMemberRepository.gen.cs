
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
    public partial class BenificiaryMemberRepository : IBenificiaryMemberRepository
    {
        public int AddBenificiaryMember(R_BenificiaryMember t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteBenificiaryMember(R_BenificiaryMember t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteBenificiaryMember(int benificiaryMemberId)
        {
            var t = GetBenificiaryMember(benificiaryMemberId);
            DeleteBenificiaryMember(t);
        }

        public R_BenificiaryMember GetBenificiaryMember(int benificiaryMemberId)
        {
            //Requires.NotNegative("benificiaryMemberId", benificiaryMemberId);
            
            R_BenificiaryMember t = R_BenificiaryMember.SingleOrDefault(benificiaryMemberId);

            return t;
        }

        public IEnumerable<R_BenificiaryMember> GetBenificiaryMembers()
        {
             
            IEnumerable<R_BenificiaryMember> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_BenificiaryMembers")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_BenificiaryMember.Query(sql);

            return results;
        }

        public IList<R_BenificiaryMember> GetBenificiaryMembers(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_BenificiaryMember> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_BenificiaryMembers")
                .Where("IsDeleted = 0")
                .Where(
                    "Name like '%" + searchTerm + "%'"
                     + " or " + "Description like '%" + searchTerm + "%'"
                )
            ;

            results = R_BenificiaryMember.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public void UpdateBenificiaryMember(R_BenificiaryMember t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "BenificiaryMemberId");

            t.Update();
        }

    }
}

        