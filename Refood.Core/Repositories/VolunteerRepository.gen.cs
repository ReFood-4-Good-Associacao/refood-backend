
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
    public partial class VolunteerRepository : IVolunteerRepository
    {
        public int AddVolunteer(R_Volunteer t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteVolunteer(R_Volunteer t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteVolunteer(int volunteerId)
        {
            var t = GetVolunteer(volunteerId);
            DeleteVolunteer(t);
        }

        public R_Volunteer GetVolunteer(int volunteerId)
        {
            //Requires.NotNegative("volunteerId", volunteerId);
            
            R_Volunteer t = R_Volunteer.SingleOrDefault(volunteerId);

            return t;
        }

        public IEnumerable<R_Volunteer> GetVolunteers()
        {
             
            IEnumerable<R_Volunteer> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Volunteer")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_Volunteer.Query(sql);

            return results;
        }

        public IList<R_Volunteer> GetVolunteers(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_Volunteer> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Volunteer")
                .Where("IsDeleted = 0")
                .Where(
                    "Name like '%" + searchTerm + "%'"
                     + " or " + "Occupation like '%" + searchTerm + "%'"
                     + " or " + "Employer like '%" + searchTerm + "%'"
                     + " or " + "Phone like '%" + searchTerm + "%'"
                     + " or " + "Email like '%" + searchTerm + "%'"
                     + " or " + "IdentityCardNumber like '%" + searchTerm + "%'"
                     + " or " + "FriendOrFamilyContact like '%" + searchTerm + "%'"
                     + " or " + "VehicleMake like '%" + searchTerm + "%'"
                     + " or " + "VehicleModel like '%" + searchTerm + "%'"
                )
            ;

            results = R_Volunteer.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_Volunteer> GetVolunteerListAdvancedSearch(
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
        )
        {
            IEnumerable<R_Volunteer> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Volunteer")
                .Where("IsDeleted = 0" 
                    + (name != null ? " and Name like '%" + name + "%'" : "")
                    + (gender != null ? " and Gender like '%" + gender + "%'" : "")
                    + (birthDateFrom != null ? " and BirthDate >= '" + birthDateFrom.Value.ToShortDateString() + "'" : "")
                    + (birthDateTo != null ? " and BirthDate <= '" + birthDateTo.Value.ToShortDateString() + "'" : "")
                    + (occupation != null ? " and Occupation like '%" + occupation + "%'" : "")
                    + (employer != null ? " and Employer like '%" + employer + "%'" : "")
                    + (phone != null ? " and Phone like '%" + phone + "%'" : "")
                    + (email != null ? " and Email like '%" + email + "%'" : "")
                    + (identityCardNumber != null ? " and IdentityCardNumber like '%" + identityCardNumber + "%'" : "")
                    + (countryId != null ? " and CountryId like '%" + countryId + "%'" : "")
                    + (friendOrFamilyContact != null ? " and FriendOrFamilyContact like '%" + friendOrFamilyContact + "%'" : "")
                    + (photo != null ? " and Photo like '%" + photo + "%'" : "")
                    + (addressId != null ? " and AddressId like '%" + addressId + "%'" : "")
                    + (hasCar != null ? " and HasCar = " + (hasCar == true ? "1" : "0") : "")
                    + (hasDriverLicense != null ? " and HasDriverLicense = " + (hasDriverLicense == true ? "1" : "0") : "")
                    + (hasBike != null ? " and HasBike = " + (hasBike == true ? "1" : "0") : "")
                    + (vehicleMake != null ? " and VehicleMake like '%" + vehicleMake + "%'" : "")
                    + (vehicleModel != null ? " and VehicleModel like '%" + vehicleModel + "%'" : "")
                    + (active != null ? " and Active = " + (active == true ? "1" : "0") : "")
                 )
            ;

            results = R_Volunteer.Query(sql);

            return results;
        }

        public void UpdateVolunteer(R_Volunteer t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "VolunteerId");

            t.Update();
        }

    }
}

        