
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface IVolunteerRepository
    {
        int AddVolunteer(R_Volunteer t);

        void DeleteVolunteer(R_Volunteer t);

        void DeleteVolunteer(int volunteerId);

        R_Volunteer GetVolunteer(int volunteerId);

        IEnumerable<R_Volunteer> GetVolunteers();

        IList<R_Volunteer> GetVolunteers(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_Volunteer> GetVolunteerListAdvancedSearch(
            string name 
            , int? gender 
            , System.DateTime? birthDateFrom 
            , System.DateTime? birthDateTo 
            , string occupation 
            , string employer 
            , string phone 
            , string email 
            , string identityCardNumber 
            , int? countryId 
            , string friendOrFamilyContact 
            , int? photo 
            , int? addressId 
            , bool? hasCar 
            , bool? hasDriverLicense 
            , bool? hasBike 
            , string vehicleMake 
            , string vehicleModel 
            , bool? active 
        );

        void UpdateVolunteer(R_Volunteer t);

    }
}

    