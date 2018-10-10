
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class ProjectPartnerDTO
    {
        public int ProjectPartnerId { get; set; }
        public int ProjectId { get; set; }
        public int PartnerId { get; set; }
        public double? GrantValue { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public ProjectPartnerDTO()
        {
        
        }

        public ProjectPartnerDTO(R_ProjectPartner projectPartner)
        {
            ProjectPartnerId = projectPartner.ProjectPartnerId;
            ProjectId = projectPartner.ProjectId;
            PartnerId = projectPartner.PartnerId;
            GrantValue = projectPartner.GrantValue;
            IsDeleted = projectPartner.IsDeleted;
            CreateBy = projectPartner.CreateBy;
            CreateOn = projectPartner.CreateOn;
            UpdateBy = projectPartner.UpdateBy;
            UpdateOn = projectPartner.UpdateOn;
        }

        public static R_ProjectPartner ConvertDTOtoEntity(ProjectPartnerDTO dto)
        {
            R_ProjectPartner projectPartner = new R_ProjectPartner();

            projectPartner.ProjectPartnerId = dto.ProjectPartnerId;
            projectPartner.ProjectId = dto.ProjectId;
            projectPartner.PartnerId = dto.PartnerId;
            projectPartner.GrantValue = dto.GrantValue;
            projectPartner.IsDeleted = dto.IsDeleted;
            projectPartner.CreateBy = dto.CreateBy;
            projectPartner.CreateOn = dto.CreateOn;
            projectPartner.UpdateBy = dto.UpdateBy;
            projectPartner.UpdateOn = dto.UpdateOn;

            return projectPartner;
        }

        // logging helper
        public static string FormatProjectPartnerDTO(ProjectPartnerDTO projectPartnerDTO)
        {
            if(projectPartnerDTO == null)
            {
                // null
                return "projectPartnerDTO: null";
            }
            else
            {
                // output values
                return "projectPartnerDTO: \n"
                    + "{ \n"
 
                    + "    ProjectPartnerId: " +  "'" + projectPartnerDTO.ProjectPartnerId + "'"  + ", \n" 
                    + "    ProjectId: " +  "'" + projectPartnerDTO.ProjectId + "'"  + ", \n" 
                    + "    PartnerId: " +  "'" + projectPartnerDTO.PartnerId + "'"  + ", \n" 
                    + "    GrantValue: " + (projectPartnerDTO.GrantValue != null ? "'" + projectPartnerDTO.GrantValue + "'" : "null") + ", \n" 
                    + "    IsDeleted: " +  "'" + projectPartnerDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (projectPartnerDTO.CreateBy != null ? "'" + projectPartnerDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (projectPartnerDTO.CreateOn != null ? "'" + projectPartnerDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (projectPartnerDTO.UpdateBy != null ? "'" + projectPartnerDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (projectPartnerDTO.UpdateOn != null ? "'" + projectPartnerDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    