
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class ContributionMonetaryReviewerDTO
    {
        public int ContributionMonetaryReviewerId { get; set; }
        public int? VolunteerId { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public ContributionMonetaryReviewerDTO()
        {
        
        }

        public ContributionMonetaryReviewerDTO(R_ContributionMonetaryReviewer contributionMonetaryReviewer)
        {
            ContributionMonetaryReviewerId = contributionMonetaryReviewer.ContributionMonetaryReviewerId;
            VolunteerId = contributionMonetaryReviewer.VolunteerId;
            IsDeleted = contributionMonetaryReviewer.IsDeleted;
            CreateBy = contributionMonetaryReviewer.CreateBy;
            CreateOn = contributionMonetaryReviewer.CreateOn;
            UpdateBy = contributionMonetaryReviewer.UpdateBy;
            UpdateOn = contributionMonetaryReviewer.UpdateOn;
        }

        public static R_ContributionMonetaryReviewer ConvertDTOtoEntity(ContributionMonetaryReviewerDTO dto)
        {
            R_ContributionMonetaryReviewer contributionMonetaryReviewer = new R_ContributionMonetaryReviewer();

            contributionMonetaryReviewer.ContributionMonetaryReviewerId = dto.ContributionMonetaryReviewerId;
            contributionMonetaryReviewer.VolunteerId = dto.VolunteerId;
            contributionMonetaryReviewer.IsDeleted = dto.IsDeleted;
            contributionMonetaryReviewer.CreateBy = dto.CreateBy;
            contributionMonetaryReviewer.CreateOn = dto.CreateOn;
            contributionMonetaryReviewer.UpdateBy = dto.UpdateBy;
            contributionMonetaryReviewer.UpdateOn = dto.UpdateOn;

            return contributionMonetaryReviewer;
        }

        // logging helper
        public static string FormatContributionMonetaryReviewerDTO(ContributionMonetaryReviewerDTO contributionMonetaryReviewerDTO)
        {
            if(contributionMonetaryReviewerDTO == null)
            {
                // null
                return "contributionMonetaryReviewerDTO: null";
            }
            else
            {
                // output values
                return "contributionMonetaryReviewerDTO: \n"
                    + "{ \n"
 
                    + "    ContributionMonetaryReviewerId: " +  "'" + contributionMonetaryReviewerDTO.ContributionMonetaryReviewerId + "'"  + ", \n" 
                    + "    VolunteerId: " + (contributionMonetaryReviewerDTO.VolunteerId != null ? "'" + contributionMonetaryReviewerDTO.VolunteerId + "'" : "null") + ", \n" 
                    + "    IsDeleted: " +  "'" + contributionMonetaryReviewerDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (contributionMonetaryReviewerDTO.CreateBy != null ? "'" + contributionMonetaryReviewerDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (contributionMonetaryReviewerDTO.CreateOn != null ? "'" + contributionMonetaryReviewerDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (contributionMonetaryReviewerDTO.UpdateBy != null ? "'" + contributionMonetaryReviewerDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (contributionMonetaryReviewerDTO.UpdateOn != null ? "'" + contributionMonetaryReviewerDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    