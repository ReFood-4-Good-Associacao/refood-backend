
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
    public partial class PartnerRepository : IPartnerRepository
    {
        public int AddPartner(R_Partner t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeletePartner(R_Partner t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeletePartner(int partnerId)
        {
            var t = GetPartner(partnerId);
            DeletePartner(t);
        }

        public R_Partner GetPartner(int partnerId)
        {
            //Requires.NotNegative("partnerId", partnerId);
            
            R_Partner t = R_Partner.SingleOrDefault(partnerId);

            return t;
        }

        public IEnumerable<R_Partner> GetPartners()
        {
             
            IEnumerable<R_Partner> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Partner")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_Partner.Query(sql);

            return results;
        }

        public IList<R_Partner> GetPartners(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_Partner> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Partner")
                .Where("IsDeleted = 0")
                .Where(
                    "Name like '%" + searchTerm + "%'"
                     + " or " + "ContactPerson like '%" + searchTerm + "%'"
                     + " or " + "Department like '%" + searchTerm + "%'"
                     + " or " + "Phone like '%" + searchTerm + "%'"
                     + " or " + "Email like '%" + searchTerm + "%'"
                     + " or " + "Iban like '%" + searchTerm + "%'"
                     + " or " + "BicSwift like '%" + searchTerm + "%'"
                     + " or " + "FiscalNumber like '%" + searchTerm + "%'"
                     + " or " + "PhotoUrl like '%" + searchTerm + "%'"
                     + " or " + "RefoodAreaInteraction like '%" + searchTerm + "%'"
                     + " or " + "Reliability like '%" + searchTerm + "%'"
                     + " or " + "InteractionFrequency like '%" + searchTerm + "%'"
                )
            ;

            results = R_Partner.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_Partner> GetPartnerListAdvancedSearch(
            int? nucleoId 
            , string name 
            , bool? enterpriseContributor 
            , bool? privateContributor 
            , int? contributionTypeId 
            , int? partnershipTypeId 
            , string contactPerson 
            , string department 
            , string phone 
            , string email 
            , string iban 
            , string bicSwift 
            , string fiscalNumber 
            , double? latitude 
            , double? longitude 
            , string photoUrl 
            , int? addressId 
            , System.DateTime? partnershipStartDateFrom 
            , System.DateTime? partnershipStartDateTo 
            , System.DateTime? durationCommitmentFrom 
            , System.DateTime? durationCommitmentTo 
            , string refoodAreaInteraction 
            , string reliability 
            , string interactionFrequency 
            , bool? active 
        )
        {
            IEnumerable<R_Partner> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Partner")
                .Where("IsDeleted = 0" 
                    + (nucleoId != null ? " and NucleoId like '%" + nucleoId + "%'" : "")
                    + (name != null ? " and Name like '%" + name + "%'" : "")
                    + (enterpriseContributor != null ? " and EnterpriseContributor = " + (enterpriseContributor == true ? "1" : "0") : "")
                    + (privateContributor != null ? " and PrivateContributor = " + (privateContributor == true ? "1" : "0") : "")
                    + (contributionTypeId != null ? " and ContributionTypeId = " + contributionTypeId : "")
                    + (partnershipTypeId != null ? " and PartnershipTypeId = " + partnershipTypeId : "")
                    + (contactPerson != null ? " and ContactPerson like '%" + contactPerson + "%'" : "")
                    + (department != null ? " and Department like '%" + department + "%'" : "")
                    + (phone != null ? " and Phone like '%" + phone + "%'" : "")
                    + (email != null ? " and Email like '%" + email + "%'" : "")
                    + (iban != null ? " and Iban like '%" + iban + "%'" : "")
                    + (bicSwift != null ? " and BicSwift like '%" + bicSwift + "%'" : "")
                    + (fiscalNumber != null ? " and FiscalNumber like '%" + fiscalNumber + "%'" : "")
                    + (latitude != null ? " and Latitude like '%" + latitude + "%'" : "")
                    + (longitude != null ? " and Longitude like '%" + longitude + "%'" : "")
                    + (photoUrl != null ? " and PhotoUrl like '%" + photoUrl + "%'" : "")
                    + (addressId != null ? " and AddressId like '%" + addressId + "%'" : "")
                    + (partnershipStartDateFrom != null ? " and PartnershipStartDate >= '" + partnershipStartDateFrom.Value.ToShortDateString() + "'" : "")
                    + (partnershipStartDateTo != null ? " and PartnershipStartDate <= '" + partnershipStartDateTo.Value.ToShortDateString() + "'" : "")
                    + (durationCommitmentFrom != null ? " and DurationCommitment >= '" + durationCommitmentFrom.Value.ToShortDateString() + "'" : "")
                    + (durationCommitmentTo != null ? " and DurationCommitment <= '" + durationCommitmentTo.Value.ToShortDateString() + "'" : "")
                    + (refoodAreaInteraction != null ? " and RefoodAreaInteraction like '%" + refoodAreaInteraction + "%'" : "")
                    + (reliability != null ? " and Reliability like '%" + reliability + "%'" : "")
                    + (interactionFrequency != null ? " and InteractionFrequency like '%" + interactionFrequency + "%'" : "")
                    + (active != null ? " and Active = " + (active == true ? "1" : "0") : "")
                 )
            ;

            results = R_Partner.Query(sql);

            return results;
        }

        public void UpdatePartner(R_Partner t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "PartnerId");

            t.Update();
        }

    }
}

        