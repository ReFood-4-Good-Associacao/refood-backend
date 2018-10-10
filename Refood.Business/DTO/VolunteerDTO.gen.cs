
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class VolunteerDTO
    {
        public int VolunteerId { get; set; }
        public string Name { get; set; }
        public int? Gender { get; set; }
        public System.DateTime? BirthDate { get; set; }
        public string Occupation { get; set; }
        public string Employer { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string IdentityCardNumber { get; set; }
        public int? CountryId { get; set; }
        public string FriendOrFamilyContact { get; set; }
        public int? Photo { get; set; }
        public int? AddressId { get; set; }
        public bool HasCar { get; set; }
        public bool HasDriverLicense { get; set; }
        public bool HasBike { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public VolunteerDTO()
        {
        
        }

        public VolunteerDTO(R_Volunteer volunteer)
        {
            VolunteerId = volunteer.VolunteerId;
            Name = volunteer.Name;
            Gender = volunteer.Gender;
            BirthDate = volunteer.BirthDate;
            Occupation = volunteer.Occupation;
            Employer = volunteer.Employer;
            Phone = volunteer.Phone;
            Email = volunteer.Email;
            IdentityCardNumber = volunteer.IdentityCardNumber;
            CountryId = volunteer.CountryId;
            FriendOrFamilyContact = volunteer.FriendOrFamilyContact;
            Photo = volunteer.Photo;
            AddressId = volunteer.AddressId;
            HasCar = volunteer.HasCar;
            HasDriverLicense = volunteer.HasDriverLicense;
            HasBike = volunteer.HasBike;
            VehicleMake = volunteer.VehicleMake;
            VehicleModel = volunteer.VehicleModel;
            Active = volunteer.Active;
            IsDeleted = volunteer.IsDeleted;
            CreateBy = volunteer.CreateBy;
            CreateOn = volunteer.CreateOn;
            UpdateBy = volunteer.UpdateBy;
            UpdateOn = volunteer.UpdateOn;
        }

        public static R_Volunteer ConvertDTOtoEntity(VolunteerDTO dto)
        {
            R_Volunteer volunteer = new R_Volunteer();

            volunteer.VolunteerId = dto.VolunteerId;
            volunteer.Name = dto.Name;
            volunteer.Gender = dto.Gender;
            volunteer.BirthDate = dto.BirthDate;
            volunteer.Occupation = dto.Occupation;
            volunteer.Employer = dto.Employer;
            volunteer.Phone = dto.Phone;
            volunteer.Email = dto.Email;
            volunteer.IdentityCardNumber = dto.IdentityCardNumber;
            volunteer.CountryId = dto.CountryId;
            volunteer.FriendOrFamilyContact = dto.FriendOrFamilyContact;
            volunteer.Photo = dto.Photo;
            volunteer.AddressId = dto.AddressId;
            volunteer.HasCar = dto.HasCar;
            volunteer.HasDriverLicense = dto.HasDriverLicense;
            volunteer.HasBike = dto.HasBike;
            volunteer.VehicleMake = dto.VehicleMake;
            volunteer.VehicleModel = dto.VehicleModel;
            volunteer.Active = dto.Active;
            volunteer.IsDeleted = dto.IsDeleted;
            volunteer.CreateBy = dto.CreateBy;
            volunteer.CreateOn = dto.CreateOn;
            volunteer.UpdateBy = dto.UpdateBy;
            volunteer.UpdateOn = dto.UpdateOn;

            return volunteer;
        }

        // logging helper
        public static string FormatVolunteerDTO(VolunteerDTO volunteerDTO)
        {
            if(volunteerDTO == null)
            {
                // null
                return "volunteerDTO: null";
            }
            else
            {
                // output values
                return "volunteerDTO: \n"
                    + "{ \n"
 
                    + "    VolunteerId: " +  "'" + volunteerDTO.VolunteerId + "'"  + ", \n" 
                    + "    Name: " + (volunteerDTO.Name != null ? "'" + volunteerDTO.Name + "'" : "null") + ", \n" 
                    + "    Gender: " + (volunteerDTO.Gender != null ? "'" + volunteerDTO.Gender + "'" : "null") + ", \n" 
                    + "    BirthDate: " + (volunteerDTO.BirthDate != null ? "'" + volunteerDTO.BirthDate + "'" : "null") + ", \n" 
                    + "    Occupation: " + (volunteerDTO.Occupation != null ? "'" + volunteerDTO.Occupation + "'" : "null") + ", \n" 
                    + "    Employer: " + (volunteerDTO.Employer != null ? "'" + volunteerDTO.Employer + "'" : "null") + ", \n" 
                    + "    Phone: " + (volunteerDTO.Phone != null ? "'" + volunteerDTO.Phone + "'" : "null") + ", \n" 
                    + "    Email: " + (volunteerDTO.Email != null ? "'" + volunteerDTO.Email + "'" : "null") + ", \n" 
                    + "    IdentityCardNumber: " + (volunteerDTO.IdentityCardNumber != null ? "'" + volunteerDTO.IdentityCardNumber + "'" : "null") + ", \n" 
                    + "    CountryId: " + (volunteerDTO.CountryId != null ? "'" + volunteerDTO.CountryId + "'" : "null") + ", \n" 
                    + "    FriendOrFamilyContact: " + (volunteerDTO.FriendOrFamilyContact != null ? "'" + volunteerDTO.FriendOrFamilyContact + "'" : "null") + ", \n" 
                    + "    Photo: " + (volunteerDTO.Photo != null ? "'" + volunteerDTO.Photo + "'" : "null") + ", \n" 
                    + "    AddressId: " + (volunteerDTO.AddressId != null ? "'" + volunteerDTO.AddressId + "'" : "null") + ", \n" 
                    + "    HasCar: " +  "'" + volunteerDTO.HasCar + "'"  + ", \n" 
                    + "    HasDriverLicense: " +  "'" + volunteerDTO.HasDriverLicense + "'"  + ", \n" 
                    + "    HasBike: " +  "'" + volunteerDTO.HasBike + "'"  + ", \n" 
                    + "    VehicleMake: " + (volunteerDTO.VehicleMake != null ? "'" + volunteerDTO.VehicleMake + "'" : "null") + ", \n" 
                    + "    VehicleModel: " + (volunteerDTO.VehicleModel != null ? "'" + volunteerDTO.VehicleModel + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + volunteerDTO.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + volunteerDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (volunteerDTO.CreateBy != null ? "'" + volunteerDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (volunteerDTO.CreateOn != null ? "'" + volunteerDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (volunteerDTO.UpdateBy != null ? "'" + volunteerDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (volunteerDTO.UpdateOn != null ? "'" + volunteerDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    