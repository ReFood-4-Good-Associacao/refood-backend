
// ################################################################
//                      Code generated with T4
// ################################################################

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Refood.Business.DTOs;

namespace Refood.Web.Services.ViewModels
{

    [JsonObject(MemberSerialization.OptIn)]
    public partial class VolunteerViewModel
    {
        public VolunteerViewModel() { }

        public VolunteerViewModel(VolunteerDTO t)
        {
            VolunteerId = t.VolunteerId;
            Name = t.Name;
            Gender = t.Gender;
            BirthDate = t.BirthDate;
            Occupation = t.Occupation;
            Employer = t.Employer;
            Phone = t.Phone;
            Email = t.Email;
            IdentityCardNumber = t.IdentityCardNumber;
            CountryId = t.CountryId;
            FriendOrFamilyContact = t.FriendOrFamilyContact;
            Photo = t.Photo;
            AddressId = t.AddressId;
            HasCar = t.HasCar;
            HasDriverLicense = t.HasDriverLicense;
            HasBike = t.HasBike;
            VehicleMake = t.VehicleMake;
            VehicleModel = t.VehicleModel;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public VolunteerViewModel(VolunteerDTO t, string editUrl)
        {
            VolunteerId = t.VolunteerId;
            Name = t.Name;
            Gender = t.Gender;
            BirthDate = t.BirthDate;
            Occupation = t.Occupation;
            Employer = t.Employer;
            Phone = t.Phone;
            Email = t.Email;
            IdentityCardNumber = t.IdentityCardNumber;
            CountryId = t.CountryId;
            FriendOrFamilyContact = t.FriendOrFamilyContact;
            Photo = t.Photo;
            AddressId = t.AddressId;
            HasCar = t.HasCar;
            HasDriverLicense = t.HasDriverLicense;
            HasBike = t.HasBike;
            VehicleMake = t.VehicleMake;
            VehicleModel = t.VehicleModel;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
            EditUrl = editUrl;
        }

        public VolunteerDTO UpdateDTO(VolunteerDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.VolunteerId = this.VolunteerId;
                dto.Name = this.Name;
                dto.Gender = this.Gender;
                dto.BirthDate = this.BirthDate;
                dto.Occupation = this.Occupation;
                dto.Employer = this.Employer;
                dto.Phone = this.Phone;
                dto.Email = this.Email;
                dto.IdentityCardNumber = this.IdentityCardNumber;
                dto.CountryId = this.CountryId;
                dto.FriendOrFamilyContact = this.FriendOrFamilyContact;
                dto.Photo = this.Photo;
                dto.AddressId = this.AddressId;
                dto.HasCar = this.HasCar;
                dto.HasDriverLicense = this.HasDriverLicense;
                dto.HasBike = this.HasBike;
                dto.VehicleMake = this.VehicleMake;
                dto.VehicleModel = this.VehicleModel;
                dto.Active = this.Active;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("volunteerId")]
        public int VolunteerId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("gender")]
        public int? Gender { get; set; }

        [JsonProperty("birthDate")]
        public System.DateTime? BirthDate { get; set; }

        [JsonProperty("occupation")]
        public string Occupation { get; set; }

        [JsonProperty("employer")]
        public string Employer { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("identityCardNumber")]
        public string IdentityCardNumber { get; set; }

        [JsonProperty("countryId")]
        public int? CountryId { get; set; }

        [JsonProperty("friendOrFamilyContact")]
        public string FriendOrFamilyContact { get; set; }

        [JsonProperty("photo")]
        public int? Photo { get; set; }

        [JsonProperty("addressId")]
        public int? AddressId { get; set; }

        [JsonProperty("hasCar")]
        public bool HasCar { get; set; }

        [JsonProperty("hasDriverLicense")]
        public bool HasDriverLicense { get; set; }

        [JsonProperty("hasBike")]
        public bool HasBike { get; set; }

        [JsonProperty("vehicleMake")]
        public string VehicleMake { get; set; }

        [JsonProperty("vehicleModel")]
        public string VehicleModel { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("createBy")]
        public int? CreateBy { get; set; }

        [JsonProperty("createOn")]
        public System.DateTime? CreateOn { get; set; }

        [JsonProperty("updateBy")]
        public int? UpdateBy { get; set; }

        [JsonProperty("updateOn")]
        public System.DateTime? UpdateOn { get; set; }

        [JsonProperty("editUrl")]
        public string EditUrl { get; }



        // logging helper
        public static string FormatVolunteerViewModel(VolunteerViewModel volunteerViewModel)
        {
            if (volunteerViewModel == null)
            {
                // null
                return "volunteerViewModel: null";
            }
            else
            {
                // output values
                return "volunteerViewModel: \n"
                    + "{ \n"
 
                    + "    VolunteerId: " +  "'" + volunteerViewModel.VolunteerId + "'"  + ", \n" 
                    + "    Name: " + (volunteerViewModel.Name != null ? "'" + volunteerViewModel.Name + "'" : "null") + ", \n" 
                    + "    Gender: " + (volunteerViewModel.Gender != null ? "'" + volunteerViewModel.Gender + "'" : "null") + ", \n" 
                    + "    BirthDate: " + (volunteerViewModel.BirthDate != null ? "'" + volunteerViewModel.BirthDate + "'" : "null") + ", \n" 
                    + "    Occupation: " + (volunteerViewModel.Occupation != null ? "'" + volunteerViewModel.Occupation + "'" : "null") + ", \n" 
                    + "    Employer: " + (volunteerViewModel.Employer != null ? "'" + volunteerViewModel.Employer + "'" : "null") + ", \n" 
                    + "    Phone: " + (volunteerViewModel.Phone != null ? "'" + volunteerViewModel.Phone + "'" : "null") + ", \n" 
                    + "    Email: " + (volunteerViewModel.Email != null ? "'" + volunteerViewModel.Email + "'" : "null") + ", \n" 
                    + "    IdentityCardNumber: " + (volunteerViewModel.IdentityCardNumber != null ? "'" + volunteerViewModel.IdentityCardNumber + "'" : "null") + ", \n" 
                    + "    CountryId: " + (volunteerViewModel.CountryId != null ? "'" + volunteerViewModel.CountryId + "'" : "null") + ", \n" 
                    + "    FriendOrFamilyContact: " + (volunteerViewModel.FriendOrFamilyContact != null ? "'" + volunteerViewModel.FriendOrFamilyContact + "'" : "null") + ", \n" 
                    + "    Photo: " + (volunteerViewModel.Photo != null ? "'" + volunteerViewModel.Photo + "'" : "null") + ", \n" 
                    + "    AddressId: " + (volunteerViewModel.AddressId != null ? "'" + volunteerViewModel.AddressId + "'" : "null") + ", \n" 
                    + "    HasCar: " +  "'" + volunteerViewModel.HasCar + "'"  + ", \n" 
                    + "    HasDriverLicense: " +  "'" + volunteerViewModel.HasDriverLicense + "'"  + ", \n" 
                    + "    HasBike: " +  "'" + volunteerViewModel.HasBike + "'"  + ", \n" 
                    + "    VehicleMake: " + (volunteerViewModel.VehicleMake != null ? "'" + volunteerViewModel.VehicleMake + "'" : "null") + ", \n" 
                    + "    VehicleModel: " + (volunteerViewModel.VehicleModel != null ? "'" + volunteerViewModel.VehicleModel + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + volunteerViewModel.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + volunteerViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (volunteerViewModel.CreateBy != null ? "'" + volunteerViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (volunteerViewModel.CreateOn != null ? "'" + volunteerViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (volunteerViewModel.UpdateBy != null ? "'" + volunteerViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (volunteerViewModel.UpdateOn != null ? "'" + volunteerViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    