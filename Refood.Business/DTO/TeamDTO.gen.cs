
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class TeamDTO
    {
        public int TeamId { get; set; }
        public int? NucleoId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public TeamDTO()
        {
        
        }

        public TeamDTO(R_Team team)
        {
            TeamId = team.TeamId;
            NucleoId = team.NucleoId;
            Name = team.Name;
            Description = team.Description;
            Active = team.Active;
            IsDeleted = team.IsDeleted;
            CreateBy = team.CreateBy;
            CreateOn = team.CreateOn;
            UpdateBy = team.UpdateBy;
            UpdateOn = team.UpdateOn;
        }

        public static R_Team ConvertDTOtoEntity(TeamDTO dto)
        {
            R_Team team = new R_Team();

            team.TeamId = dto.TeamId;
            team.NucleoId = dto.NucleoId;
            team.Name = dto.Name;
            team.Description = dto.Description;
            team.Active = dto.Active;
            team.IsDeleted = dto.IsDeleted;
            team.CreateBy = dto.CreateBy;
            team.CreateOn = dto.CreateOn;
            team.UpdateBy = dto.UpdateBy;
            team.UpdateOn = dto.UpdateOn;

            return team;
        }

        // logging helper
        public static string FormatTeamDTO(TeamDTO teamDTO)
        {
            if(teamDTO == null)
            {
                // null
                return "teamDTO: null";
            }
            else
            {
                // output values
                return "teamDTO: \n"
                    + "{ \n"
 
                    + "    TeamId: " +  "'" + teamDTO.TeamId + "'"  + ", \n" 
                    + "    NucleoId: " + (teamDTO.NucleoId != null ? "'" + teamDTO.NucleoId + "'" : "null") + ", \n" 
                    + "    Name: " + (teamDTO.Name != null ? "'" + teamDTO.Name + "'" : "null") + ", \n" 
                    + "    Description: " + (teamDTO.Description != null ? "'" + teamDTO.Description + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + teamDTO.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + teamDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (teamDTO.CreateBy != null ? "'" + teamDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (teamDTO.CreateOn != null ? "'" + teamDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (teamDTO.UpdateBy != null ? "'" + teamDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (teamDTO.UpdateOn != null ? "'" + teamDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    