
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface IPartnerRepository
    {
        int AddPartner(R_Partner t);

        void DeletePartner(R_Partner t);

        void DeletePartner(int partnerId);

        R_Partner GetPartner(int partnerId);

        IEnumerable<R_Partner> GetPartners();

        IList<R_Partner> GetPartners(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_Partner> GetPartnerListAdvancedSearch(
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
        );

        void UpdatePartner(R_Partner t);

    }
}

    