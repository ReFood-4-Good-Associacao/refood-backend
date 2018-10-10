
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class ContributionTypeDTO
    {
        public int ContributionTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public ContributionTypeDTO()
        {
        
        }

        public ContributionTypeDTO(R_ContributionType contributionType)
        {
            ContributionTypeId = contributionType.ContributionTypeId;
            Name = contributionType.Name;
            Description = contributionType.Description;
            Active = contributionType.Active;
            IsDeleted = contributionType.IsDeleted;
            CreateBy = contributionType.CreateBy;
            CreateOn = contributionType.CreateOn;
            UpdateBy = contributionType.UpdateBy;
            UpdateOn = contributionType.UpdateOn;
        }

        public static R_ContributionType ConvertDTOtoEntity(ContributionTypeDTO dto)
        {
            R_ContributionType contributionType = new R_ContributionType();

            contributionType.ContributionTypeId = dto.ContributionTypeId;
            contributionType.Name = dto.Name;
            contributionType.Description = dto.Description;
            contributionType.Active = dto.Active;
            contributionType.IsDeleted = dto.IsDeleted;
            contributionType.CreateBy = dto.CreateBy;
            contributionType.CreateOn = dto.CreateOn;
            contributionType.UpdateBy = dto.UpdateBy;
            contributionType.UpdateOn = dto.UpdateOn;

            return contributionType;
        }

        // logging helper
        public static string FormatContributionTypeDTO(ContributionTypeDTO contributionTypeDTO)
        {
            if(contributionTypeDTO == null)
            {
                // null
                return "contributionTypeDTO: null";
            }
            else
            {
                // output values
                return "contributionTypeDTO: \n"
                    + "{ \n"
 
                    + "    ContributionTypeId: " +  "'" + contributionTypeDTO.ContributionTypeId + "'"  + ", \n" 
                    + "    Name: " + (contributionTypeDTO.Name != null ? "'" + contributionTypeDTO.Name + "'" : "null") + ", \n" 
                    + "    Description: " + (contributionTypeDTO.Description != null ? "'" + contributionTypeDTO.Description + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + contributionTypeDTO.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + contributionTypeDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (contributionTypeDTO.CreateBy != null ? "'" + contributionTypeDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (contributionTypeDTO.CreateOn != null ? "'" + contributionTypeDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (contributionTypeDTO.UpdateBy != null ? "'" + contributionTypeDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (contributionTypeDTO.UpdateOn != null ? "'" + contributionTypeDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    