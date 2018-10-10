
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
    public partial class PartnershipTypeRepository : IPartnershipTypeRepository
    {
        public int AddPartnershipType(R_PartnershipType t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeletePartnershipType(R_PartnershipType t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeletePartnershipType(int partnershipTypeId)
        {
            var t = GetPartnershipType(partnershipTypeId);
            DeletePartnershipType(t);
        }

        public R_PartnershipType GetPartnershipType(int partnershipTypeId)
        {
            //Requires.NotNegative("partnershipTypeId", partnershipTypeId);
            
            R_PartnershipType t = R_PartnershipType.SingleOrDefault(partnershipTypeId);

            return t;
        }

        public IEnumerable<R_PartnershipType> GetPartnershipTypes()
        {
             
            IEnumerable<R_PartnershipType> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_PartnershipType")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_PartnershipType.Query(sql);

            return results;
        }

        public IList<R_PartnershipType> GetPartnershipTypes(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_PartnershipType> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_PartnershipType")
                .Where("IsDeleted = 0")
                .Where(
                    "Name like '%" + searchTerm + "%'"
                     + " or " + "Description like '%" + searchTerm + "%'"
                     + " or " + "ActivityType like '%" + searchTerm + "%'"
                )
            ;

            results = R_PartnershipType.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_PartnershipType> GetPartnershipTypeListAdvancedSearch(
            string name 
            , string description 
            , string activityType 
            , bool? active 
        )
        {
            IEnumerable<R_PartnershipType> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_PartnershipType")
                .Where("IsDeleted = 0" 
                    + (name != null ? " and Name like '%" + name + "%'" : "")
                    + (description != null ? " and Description like '%" + description + "%'" : "")
                    + (activityType != null ? " and ActivityType like '%" + activityType + "%'" : "")
                    + (active != null ? " and Active = " + (active == true ? "1" : "0") : "")
                 )
            ;

            results = R_PartnershipType.Query(sql);

            return results;
        }

        public void UpdatePartnershipType(R_PartnershipType t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "PartnershipTypeId");

            t.Update();
        }

    }
}

        