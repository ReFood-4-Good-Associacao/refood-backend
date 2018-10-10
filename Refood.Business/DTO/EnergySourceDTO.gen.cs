
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class EnergySourceDTO
    {
        public int EnergySourceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public EnergySourceDTO()
        {
        
        }

        public EnergySourceDTO(R_EnergySource energySource)
        {
            EnergySourceId = energySource.EnergySourceId;
            Name = energySource.Name;
            Description = energySource.Description;
            Active = energySource.Active;
            IsDeleted = energySource.IsDeleted;
            CreateBy = energySource.CreateBy;
            CreateOn = energySource.CreateOn;
            UpdateBy = energySource.UpdateBy;
            UpdateOn = energySource.UpdateOn;
        }

        public static R_EnergySource ConvertDTOtoEntity(EnergySourceDTO dto)
        {
            R_EnergySource energySource = new R_EnergySource();

            energySource.EnergySourceId = dto.EnergySourceId;
            energySource.Name = dto.Name;
            energySource.Description = dto.Description;
            energySource.Active = dto.Active;
            energySource.IsDeleted = dto.IsDeleted;
            energySource.CreateBy = dto.CreateBy;
            energySource.CreateOn = dto.CreateOn;
            energySource.UpdateBy = dto.UpdateBy;
            energySource.UpdateOn = dto.UpdateOn;

            return energySource;
        }

        // logging helper
        public static string FormatEnergySourceDTO(EnergySourceDTO energySourceDTO)
        {
            if(energySourceDTO == null)
            {
                // null
                return "energySourceDTO: null";
            }
            else
            {
                // output values
                return "energySourceDTO: \n"
                    + "{ \n"
 
                    + "    EnergySourceId: " +  "'" + energySourceDTO.EnergySourceId + "'"  + ", \n" 
                    + "    Name: " + (energySourceDTO.Name != null ? "'" + energySourceDTO.Name + "'" : "null") + ", \n" 
                    + "    Description: " + (energySourceDTO.Description != null ? "'" + energySourceDTO.Description + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + energySourceDTO.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + energySourceDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (energySourceDTO.CreateBy != null ? "'" + energySourceDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (energySourceDTO.CreateOn != null ? "'" + energySourceDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (energySourceDTO.UpdateBy != null ? "'" + energySourceDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (energySourceDTO.UpdateOn != null ? "'" + energySourceDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    