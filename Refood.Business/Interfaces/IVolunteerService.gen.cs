
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface IVolunteerService
    {
        int AddVolunteer(VolunteerDTO dto);

        void DeleteVolunteer(int volunteerId);

        void DeleteVolunteer(VolunteerDTO dto);

        VolunteerDTO GetVolunteer(int volunteerId);

        IEnumerable<VolunteerDTO> GetVolunteers();

        IList<VolunteerDTO> GetVolunteers(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<VolunteerDTO> GetVolunteerListAdvancedSearch(
            string name 
            ,int? gender 
            ,System.DateTime? birthDateFrom 
            ,System.DateTime? birthDateTo 
            ,string occupation 
            ,string employer 
            ,string phone 
            ,string email 
            ,string identityCardNumber 
            ,int? countryId 
            ,string friendOrFamilyContact 
            ,int? photo 
            ,int? addressId 
            ,bool? hasCar 
            ,bool? hasDriverLicense 
            ,bool? hasBike 
            ,string vehicleMake 
            ,string vehicleModel 
            ,bool? active 
        );

        void UpdateVolunteer(VolunteerDTO dto);

    }
}
    