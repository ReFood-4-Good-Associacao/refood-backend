
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class BeneficiaryDTO
    {
        public int BeneficiaryId { get; set; }
        public string Name { get; set; }
        public int? Number { get; set; }
        public int? AddressId { get; set; }
        public int? NumberOfAdults { get; set; }
        public int? NumberOfChildren { get; set; }
        public int? NumberOfTupperware { get; set; }
        public int? NumberOfSoups { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public BeneficiaryDTO()
        {
        
        }

        public BeneficiaryDTO(R_Beneficiary beneficiary)
        {
            BeneficiaryId = beneficiary.BeneficiaryId;
            Name = beneficiary.Name;
            Number = beneficiary.Number;
            AddressId = beneficiary.AddressId;
            NumberOfAdults = beneficiary.NumberOfAdults;
            NumberOfChildren = beneficiary.NumberOfChildren;
            NumberOfTupperware = beneficiary.NumberOfTupperware;
            NumberOfSoups = beneficiary.NumberOfSoups;
            Description = beneficiary.Description;
            Active = beneficiary.Active;
            IsDeleted = beneficiary.IsDeleted;
            CreateBy = beneficiary.CreateBy;
            CreateOn = beneficiary.CreateOn;
            UpdateBy = beneficiary.UpdateBy;
            UpdateOn = beneficiary.UpdateOn;
        }

        public static R_Beneficiary ConvertDTOtoEntity(BeneficiaryDTO dto)
        {
            R_Beneficiary beneficiary = new R_Beneficiary();

            beneficiary.BeneficiaryId = dto.BeneficiaryId;
            beneficiary.Name = dto.Name;
            beneficiary.Number = dto.Number;
            beneficiary.AddressId = dto.AddressId;
            beneficiary.NumberOfAdults = dto.NumberOfAdults;
            beneficiary.NumberOfChildren = dto.NumberOfChildren;
            beneficiary.NumberOfTupperware = dto.NumberOfTupperware;
            beneficiary.NumberOfSoups = dto.NumberOfSoups;
            beneficiary.Description = dto.Description;
            beneficiary.Active = dto.Active;
            beneficiary.IsDeleted = dto.IsDeleted;
            beneficiary.CreateBy = dto.CreateBy;
            beneficiary.CreateOn = dto.CreateOn;
            beneficiary.UpdateBy = dto.UpdateBy;
            beneficiary.UpdateOn = dto.UpdateOn;

            return beneficiary;
        }

        // logging helper
        public static string FormatBeneficiaryDTO(BeneficiaryDTO beneficiaryDTO)
        {
            if(beneficiaryDTO == null)
            {
                // null
                return "beneficiaryDTO: null";
            }
            else
            {
                // output values
                return "beneficiaryDTO: \n"
                    + "{ \n"
 
                    + "    BeneficiaryId: " +  "'" + beneficiaryDTO.BeneficiaryId + "'"  + ", \n" 
                    + "    Name: " + (beneficiaryDTO.Name != null ? "'" + beneficiaryDTO.Name + "'" : "null") + ", \n" 
                    + "    Number: " + (beneficiaryDTO.Number != null ? "'" + beneficiaryDTO.Number + "'" : "null") + ", \n" 
                    + "    AddressId: " + (beneficiaryDTO.AddressId != null ? "'" + beneficiaryDTO.AddressId + "'" : "null") + ", \n" 
                    + "    NumberOfAdults: " + (beneficiaryDTO.NumberOfAdults != null ? "'" + beneficiaryDTO.NumberOfAdults + "'" : "null") + ", \n" 
                    + "    NumberOfChildren: " + (beneficiaryDTO.NumberOfChildren != null ? "'" + beneficiaryDTO.NumberOfChildren + "'" : "null") + ", \n" 
                    + "    NumberOfTupperware: " + (beneficiaryDTO.NumberOfTupperware != null ? "'" + beneficiaryDTO.NumberOfTupperware + "'" : "null") + ", \n" 
                    + "    NumberOfSoups: " + (beneficiaryDTO.NumberOfSoups != null ? "'" + beneficiaryDTO.NumberOfSoups + "'" : "null") + ", \n" 
                    + "    Description: " + (beneficiaryDTO.Description != null ? "'" + beneficiaryDTO.Description + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + beneficiaryDTO.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + beneficiaryDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (beneficiaryDTO.CreateBy != null ? "'" + beneficiaryDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (beneficiaryDTO.CreateOn != null ? "'" + beneficiaryDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (beneficiaryDTO.UpdateBy != null ? "'" + beneficiaryDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (beneficiaryDTO.UpdateOn != null ? "'" + beneficiaryDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    