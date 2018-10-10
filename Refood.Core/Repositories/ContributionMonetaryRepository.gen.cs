
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
    public partial class ContributionMonetaryRepository : IContributionMonetaryRepository
    {
        public int AddContributionMonetary(R_ContributionMonetary t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteContributionMonetary(R_ContributionMonetary t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteContributionMonetary(int contributionMonetaryId)
        {
            var t = GetContributionMonetary(contributionMonetaryId);
            DeleteContributionMonetary(t);
        }

        public R_ContributionMonetary GetContributionMonetary(int contributionMonetaryId)
        {
            //Requires.NotNegative("contributionMonetaryId", contributionMonetaryId);
            
            R_ContributionMonetary t = R_ContributionMonetary.SingleOrDefault(contributionMonetaryId);

            return t;
        }

        public IEnumerable<R_ContributionMonetary> GetContributionMonetarys()
        {
             
            IEnumerable<R_ContributionMonetary> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_ContributionMonetary")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_ContributionMonetary.Query(sql);

            return results;
        }

        public IList<R_ContributionMonetary> GetContributionMonetarys(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_ContributionMonetary> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_ContributionMonetary")
                .Where("IsDeleted = 0")
                .Where(
                    "ContactPerson like '%" + searchTerm + "%'"
                     + " or " + "IbanOrigin like '%" + searchTerm + "%'"
                     + " or " + "BicSwiftOrigin like '%" + searchTerm + "%'"
                     + " or " + "IbanDestination like '%" + searchTerm + "%'"
                     + " or " + "BicSwiftDestination like '%" + searchTerm + "%'"
                     + " or " + "FiscalNumber like '%" + searchTerm + "%'"
                )
            ;

            results = R_ContributionMonetary.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_ContributionMonetary> GetContributionMonetaryListAdvancedSearch(
            int? nucleoId 
            , int? responsiblePersonId 
            , int? documentId 
            , int? partnerId 
            , System.DateTime? contributionDateFrom 
            , System.DateTime? contributionDateTo 
            , double? amount 
            , string contactPerson 
            , string ibanOrigin 
            , string bicSwiftOrigin 
            , string ibanDestination 
            , string bicSwiftDestination 
            , string fiscalNumber 
            , int? contributionChannelId 
        )
        {
            IEnumerable<R_ContributionMonetary> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_ContributionMonetary")
                .Where("IsDeleted = 0" 
                    + (nucleoId != null ? " and NucleoId like '%" + nucleoId + "%'" : "")
                    + (responsiblePersonId != null ? " and ResponsiblePersonId like '%" + responsiblePersonId + "%'" : "")
                    + (documentId != null ? " and DocumentId like '%" + documentId + "%'" : "")
                    + (partnerId != null ? " and PartnerId like '%" + partnerId + "%'" : "")
                    + (contributionDateFrom != null ? " and ContributionDate >= '" + contributionDateFrom.Value.ToShortDateString() + "'" : "")
                    + (contributionDateTo != null ? " and ContributionDate <= '" + contributionDateTo.Value.ToShortDateString() + "'" : "")
                    + (amount != null ? " and Amount like '%" + amount + "%'" : "")
                    + (contactPerson != null ? " and ContactPerson like '%" + contactPerson + "%'" : "")
                    + (ibanOrigin != null ? " and IbanOrigin like '%" + ibanOrigin + "%'" : "")
                    + (bicSwiftOrigin != null ? " and BicSwiftOrigin like '%" + bicSwiftOrigin + "%'" : "")
                    + (ibanDestination != null ? " and IbanDestination like '%" + ibanDestination + "%'" : "")
                    + (bicSwiftDestination != null ? " and BicSwiftDestination like '%" + bicSwiftDestination + "%'" : "")
                    + (fiscalNumber != null ? " and FiscalNumber like '%" + fiscalNumber + "%'" : "")
                    + (contributionChannelId != null ? " and ContributionChannelId like '%" + contributionChannelId + "%'" : "")
                 )
            ;

            results = R_ContributionMonetary.Query(sql);

            return results;
        }

        public void UpdateContributionMonetary(R_ContributionMonetary t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "ContributionMonetaryId");

            t.Update();
        }

    }
}

        