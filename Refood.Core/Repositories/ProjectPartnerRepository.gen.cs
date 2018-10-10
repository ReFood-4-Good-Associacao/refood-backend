
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
    public partial class ProjectPartnerRepository : IProjectPartnerRepository
    {
        public int AddProjectPartner(R_ProjectPartner t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteProjectPartner(R_ProjectPartner t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteProjectPartner(int projectPartnerId)
        {
            var t = GetProjectPartner(projectPartnerId);
            DeleteProjectPartner(t);
        }

        public R_ProjectPartner GetProjectPartner(int projectPartnerId)
        {
            //Requires.NotNegative("projectPartnerId", projectPartnerId);
            
            R_ProjectPartner t = R_ProjectPartner.SingleOrDefault(projectPartnerId);

            return t;
        }

        public IEnumerable<R_ProjectPartner> GetProjectPartners()
        {
             
            IEnumerable<R_ProjectPartner> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_ProjectPartner")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_ProjectPartner.Query(sql);

            return results;
        }

        public IList<R_ProjectPartner> GetProjectPartners(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_ProjectPartner> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_ProjectPartner")
                .Where("IsDeleted = 0")
            ;

            results = R_ProjectPartner.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_ProjectPartner> GetProjectPartnerListAdvancedSearch(
            int? projectId 
            , int? partnerId 
            , double? grantValue 
        )
        {
            IEnumerable<R_ProjectPartner> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_ProjectPartner")
                .Where("IsDeleted = 0" 
                    + (projectId != null ? " and ProjectId = " + projectId : "")
                    + (partnerId != null ? " and PartnerId = " + partnerId : "")
                    + (grantValue != null ? " and GrantValue like '%" + grantValue + "%'" : "")
                 )
            ;

            results = R_ProjectPartner.Query(sql);

            return results;
        }

        public void UpdateProjectPartner(R_ProjectPartner t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "ProjectPartnerId");

            t.Update();
        }

    }
}

        