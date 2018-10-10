
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class BenificiaryMemberDTO
    {
        public int BenificiaryMemberId { get; set; }
        public int? BenificiaryId { get; set; }
        public string Name { get; set; }
        public bool IsChild { get; set; }
        public string Description { get; set; }
        public System.DateTime? BirthDate { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public BenificiaryMemberDTO()
        {
        
        }

        public BenificiaryMemberDTO(R_BenificiaryMember benificiaryMember)
        {
            BenificiaryMemberId = benificiaryMember.BenificiaryMemberId;
            BenificiaryId = benificiaryMember.BenificiaryId;
            Name = benificiaryMember.Name;
            IsChild = benificiaryMember.IsChild;
            Description = benificiaryMember.Description;
            BirthDate = benificiaryMember.BirthDate;
            Active = benificiaryMember.Active;
            IsDeleted = benificiaryMember.IsDeleted;
            CreateBy = benificiaryMember.CreateBy;
            CreateOn = benificiaryMember.CreateOn;
            UpdateBy = benificiaryMember.UpdateBy;
            UpdateOn = benificiaryMember.UpdateOn;
        }

        public static R_BenificiaryMember ConvertDTOtoEntity(BenificiaryMemberDTO dto)
        {
            R_BenificiaryMember benificiaryMember = new R_BenificiaryMember();

            benificiaryMember.BenificiaryMemberId = dto.BenificiaryMemberId;
            benificiaryMember.BenificiaryId = dto.BenificiaryId;
            benificiaryMember.Name = dto.Name;
            benificiaryMember.IsChild = dto.IsChild;
            benificiaryMember.Description = dto.Description;
            benificiaryMember.BirthDate = dto.BirthDate;
            benificiaryMember.Active = dto.Active;
            benificiaryMember.IsDeleted = dto.IsDeleted;
            benificiaryMember.CreateBy = dto.CreateBy;
            benificiaryMember.CreateOn = dto.CreateOn;
            benificiaryMember.UpdateBy = dto.UpdateBy;
            benificiaryMember.UpdateOn = dto.UpdateOn;

            return benificiaryMember;
        }

        // logging helper
        public static string FormatBenificiaryMemberDTO(BenificiaryMemberDTO benificiaryMemberDTO)
        {
            if(benificiaryMemberDTO == null)
            {
                // null
                return "benificiaryMemberDTO: null";
            }
            else
            {
                // output values
                return "benificiaryMemberDTO: \n"
                    + "{ \n"
 
                    + "    BenificiaryMemberId: " +  "'" + benificiaryMemberDTO.BenificiaryMemberId + "'"  + ", \n" 
                    + "    BenificiaryId: " + (benificiaryMemberDTO.BenificiaryId != null ? "'" + benificiaryMemberDTO.BenificiaryId + "'" : "null") + ", \n" 
                    + "    Name: " + (benificiaryMemberDTO.Name != null ? "'" + benificiaryMemberDTO.Name + "'" : "null") + ", \n" 
                    + "    IsChild: " + "'" + benificiaryMemberDTO.IsChild + "'" + ", \n" 
                    + "    Description: " + (benificiaryMemberDTO.Description != null ? "'" + benificiaryMemberDTO.Description + "'" : "null") + ", \n" 
                    + "    BirthDate: " + (benificiaryMemberDTO.BirthDate != null ? "'" + benificiaryMemberDTO.BirthDate + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + benificiaryMemberDTO.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + benificiaryMemberDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (benificiaryMemberDTO.CreateBy != null ? "'" + benificiaryMemberDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (benificiaryMemberDTO.CreateOn != null ? "'" + benificiaryMemberDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (benificiaryMemberDTO.UpdateBy != null ? "'" + benificiaryMemberDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (benificiaryMemberDTO.UpdateOn != null ? "'" + benificiaryMemberDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    