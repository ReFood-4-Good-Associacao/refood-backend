
// ################################################################
//                      Code generated with T4
// ################################################################

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Refood.Business.DTOs;

namespace Refood.WebServices.VolunteerWS.DataContracts
{

    [DataContract]
    public partial class VolunteerDataContract
    {
        public VolunteerDataContract() { }

        public VolunteerDataContract(VolunteerDTO t)
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

        public VolunteerDataContract(VolunteerDTO t, string editUrl)
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

        [DataMember]
        public int VolunteerId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int? Gender { get; set; }

        [DataMember]
        public System.DateTime? BirthDate { get; set; }

        [DataMember]
        public string Occupation { get; set; }

        [DataMember]
        public string Employer { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string IdentityCardNumber { get; set; }

        [DataMember]
        public int? CountryId { get; set; }

        [DataMember]
        public string FriendOrFamilyContact { get; set; }

        [DataMember]
        public int? Photo { get; set; }

        [DataMember]
        public int? AddressId { get; set; }

        [DataMember]
        public bool HasCar { get; set; }

        [DataMember]
        public bool HasDriverLicense { get; set; }

        [DataMember]
        public bool HasBike { get; set; }

        [DataMember]
        public string VehicleMake { get; set; }

        [DataMember]
        public string VehicleModel { get; set; }

        [DataMember]
        public bool Active { get; set; }

        [DataMember]
        public bool IsDeleted { get; set; }

        [DataMember]
        public int? CreateBy { get; set; }

        [DataMember]
        public System.DateTime? CreateOn { get; set; }

        [DataMember]
        public int? UpdateBy { get; set; }

        [DataMember]
        public System.DateTime? UpdateOn { get; set; }




        // logging helper
        public static string FormatVolunteerDataContract(VolunteerDataContract volunteerDataContract)
        {
            if (volunteerDataContract == null)
            {
                // null
                return "volunteerDataContract: null";
            }
            else
            {
                // output values
                return "volunteerDataContract: \n"
                    + "{ \n"
 
                    + "    VolunteerId: " +  "'" + volunteerDataContract.VolunteerId + "'"  + ", \n" 
                    + "    Name: " + (volunteerDataContract.Name != null ? "'" + volunteerDataContract.Name + "'" : "null") + ", \n" 
                    + "    Gender: " + (volunteerDataContract.Gender != null ? "'" + volunteerDataContract.Gender + "'" : "null") + ", \n" 
                    + "    BirthDate: " + (volunteerDataContract.BirthDate != null ? "'" + volunteerDataContract.BirthDate + "'" : "null") + ", \n" 
                    + "    Occupation: " + (volunteerDataContract.Occupation != null ? "'" + volunteerDataContract.Occupation + "'" : "null") + ", \n" 
                    + "    Employer: " + (volunteerDataContract.Employer != null ? "'" + volunteerDataContract.Employer + "'" : "null") + ", \n" 
                    + "    Phone: " + (volunteerDataContract.Phone != null ? "'" + volunteerDataContract.Phone + "'" : "null") + ", \n" 
                    + "    Email: " + (volunteerDataContract.Email != null ? "'" + volunteerDataContract.Email + "'" : "null") + ", \n" 
                    + "    IdentityCardNumber: " + (volunteerDataContract.IdentityCardNumber != null ? "'" + volunteerDataContract.IdentityCardNumber + "'" : "null") + ", \n" 
                    + "    CountryId: " + (volunteerDataContract.CountryId != null ? "'" + volunteerDataContract.CountryId + "'" : "null") + ", \n" 
                    + "    FriendOrFamilyContact: " + (volunteerDataContract.FriendOrFamilyContact != null ? "'" + volunteerDataContract.FriendOrFamilyContact + "'" : "null") + ", \n" 
                    + "    Photo: " + (volunteerDataContract.Photo != null ? "'" + volunteerDataContract.Photo + "'" : "null") + ", \n" 
                    + "    AddressId: " + (volunteerDataContract.AddressId != null ? "'" + volunteerDataContract.AddressId + "'" : "null") + ", \n" 
                    + "    HasCar: " +  "'" + volunteerDataContract.HasCar + "'"  + ", \n" 
                    + "    HasDriverLicense: " +  "'" + volunteerDataContract.HasDriverLicense + "'"  + ", \n" 
                    + "    HasBike: " +  "'" + volunteerDataContract.HasBike + "'"  + ", \n" 
                    + "    VehicleMake: " + (volunteerDataContract.VehicleMake != null ? "'" + volunteerDataContract.VehicleMake + "'" : "null") + ", \n" 
                    + "    VehicleModel: " + (volunteerDataContract.VehicleModel != null ? "'" + volunteerDataContract.VehicleModel + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + volunteerDataContract.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + volunteerDataContract.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (volunteerDataContract.CreateBy != null ? "'" + volunteerDataContract.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (volunteerDataContract.CreateOn != null ? "'" + volunteerDataContract.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (volunteerDataContract.UpdateBy != null ? "'" + volunteerDataContract.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (volunteerDataContract.UpdateOn != null ? "'" + volunteerDataContract.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    