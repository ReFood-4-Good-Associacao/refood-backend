
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class ProjectDTO
    {
        public int ProjectId { get; set; }
        public int? NucleoId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DeadlineCall { get; set; }
        public double? Budget { get; set; }
        public string Funding { get; set; }
        public System.DateTime? StartDate { get; set; }
        public System.DateTime? EndDate { get; set; }
        public string AreaOfInterest { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public ProjectDTO()
        {
        
        }

        public ProjectDTO(R_Project project)
        {
            ProjectId = project.ProjectId;
            NucleoId = project.NucleoId;
            Name = project.Name;
            Description = project.Description;
            DeadlineCall = project.DeadlineCall;
            Budget = project.Budget;
            Funding = project.Funding;
            StartDate = project.StartDate;
            EndDate = project.EndDate;
            AreaOfInterest = project.AreaOfInterest;
            Active = project.Active;
            IsDeleted = project.IsDeleted;
            CreateBy = project.CreateBy;
            CreateOn = project.CreateOn;
            UpdateBy = project.UpdateBy;
            UpdateOn = project.UpdateOn;
        }

        public static R_Project ConvertDTOtoEntity(ProjectDTO dto)
        {
            R_Project project = new R_Project();

            project.ProjectId = dto.ProjectId;
            project.NucleoId = dto.NucleoId;
            project.Name = dto.Name;
            project.Description = dto.Description;
            project.DeadlineCall = dto.DeadlineCall;
            project.Budget = dto.Budget;
            project.Funding = dto.Funding;
            project.StartDate = dto.StartDate;
            project.EndDate = dto.EndDate;
            project.AreaOfInterest = dto.AreaOfInterest;
            project.Active = dto.Active;
            project.IsDeleted = dto.IsDeleted;
            project.CreateBy = dto.CreateBy;
            project.CreateOn = dto.CreateOn;
            project.UpdateBy = dto.UpdateBy;
            project.UpdateOn = dto.UpdateOn;

            return project;
        }

        // logging helper
        public static string FormatProjectDTO(ProjectDTO projectDTO)
        {
            if(projectDTO == null)
            {
                // null
                return "projectDTO: null";
            }
            else
            {
                // output values
                return "projectDTO: \n"
                    + "{ \n"
 
                    + "    ProjectId: " +  "'" + projectDTO.ProjectId + "'"  + ", \n" 
                    + "    NucleoId: " + (projectDTO.NucleoId != null ? "'" + projectDTO.NucleoId + "'" : "null") + ", \n" 
                    + "    Name: " + (projectDTO.Name != null ? "'" + projectDTO.Name + "'" : "null") + ", \n" 
                    + "    Description: " + (projectDTO.Description != null ? "'" + projectDTO.Description + "'" : "null") + ", \n" 
                    + "    DeadlineCall: " + (projectDTO.DeadlineCall != null ? "'" + projectDTO.DeadlineCall + "'" : "null") + ", \n" 
                    + "    Budget: " + (projectDTO.Budget != null ? "'" + projectDTO.Budget + "'" : "null") + ", \n" 
                    + "    Funding: " + (projectDTO.Funding != null ? "'" + projectDTO.Funding + "'" : "null") + ", \n" 
                    + "    StartDate: " + (projectDTO.StartDate != null ? "'" + projectDTO.StartDate + "'" : "null") + ", \n" 
                    + "    EndDate: " + (projectDTO.EndDate != null ? "'" + projectDTO.EndDate + "'" : "null") + ", \n" 
                    + "    AreaOfInterest: " + (projectDTO.AreaOfInterest != null ? "'" + projectDTO.AreaOfInterest + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + projectDTO.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + projectDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (projectDTO.CreateBy != null ? "'" + projectDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (projectDTO.CreateOn != null ? "'" + projectDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (projectDTO.UpdateBy != null ? "'" + projectDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (projectDTO.UpdateOn != null ? "'" + projectDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    