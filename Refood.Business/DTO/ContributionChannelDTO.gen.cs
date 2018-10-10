
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class ContributionChannelDTO
    {
        public int ContributionChannelId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public ContributionChannelDTO()
        {
        
        }

        public ContributionChannelDTO(R_ContributionChannel contributionChannel)
        {
            ContributionChannelId = contributionChannel.ContributionChannelId;
            Name = contributionChannel.Name;
            Description = contributionChannel.Description;
            Active = contributionChannel.Active;
            IsDeleted = contributionChannel.IsDeleted;
            CreateBy = contributionChannel.CreateBy;
            CreateOn = contributionChannel.CreateOn;
            UpdateBy = contributionChannel.UpdateBy;
            UpdateOn = contributionChannel.UpdateOn;
        }

        public static R_ContributionChannel ConvertDTOtoEntity(ContributionChannelDTO dto)
        {
            R_ContributionChannel contributionChannel = new R_ContributionChannel();

            contributionChannel.ContributionChannelId = dto.ContributionChannelId;
            contributionChannel.Name = dto.Name;
            contributionChannel.Description = dto.Description;
            contributionChannel.Active = dto.Active;
            contributionChannel.IsDeleted = dto.IsDeleted;
            contributionChannel.CreateBy = dto.CreateBy;
            contributionChannel.CreateOn = dto.CreateOn;
            contributionChannel.UpdateBy = dto.UpdateBy;
            contributionChannel.UpdateOn = dto.UpdateOn;

            return contributionChannel;
        }

        // logging helper
        public static string FormatContributionChannelDTO(ContributionChannelDTO contributionChannelDTO)
        {
            if(contributionChannelDTO == null)
            {
                // null
                return "contributionChannelDTO: null";
            }
            else
            {
                // output values
                return "contributionChannelDTO: \n"
                    + "{ \n"
 
                    + "    ContributionChannelId: " +  "'" + contributionChannelDTO.ContributionChannelId + "'"  + ", \n" 
                    + "    Name: " + (contributionChannelDTO.Name != null ? "'" + contributionChannelDTO.Name + "'" : "null") + ", \n" 
                    + "    Description: " + (contributionChannelDTO.Description != null ? "'" + contributionChannelDTO.Description + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + contributionChannelDTO.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + contributionChannelDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (contributionChannelDTO.CreateBy != null ? "'" + contributionChannelDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (contributionChannelDTO.CreateOn != null ? "'" + contributionChannelDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (contributionChannelDTO.UpdateBy != null ? "'" + contributionChannelDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (contributionChannelDTO.UpdateOn != null ? "'" + contributionChannelDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    