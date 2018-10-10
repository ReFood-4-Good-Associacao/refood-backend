
// ################################################################
//                      Code generated with T4
// ################################################################

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Refood.Business.DTOs;

namespace Refood.Web.Services.ViewModels
{

    [JsonObject(MemberSerialization.OptIn)]
    public partial class EnergySourceViewModel
    {
        public EnergySourceViewModel() { }

        public EnergySourceViewModel(EnergySourceDTO t)
        {
            EnergySourceId = t.EnergySourceId;
            Name = t.Name;
            Description = t.Description;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public EnergySourceViewModel(EnergySourceDTO t, string editUrl)
        {
            EnergySourceId = t.EnergySourceId;
            Name = t.Name;
            Description = t.Description;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
            EditUrl = editUrl;
        }

        public EnergySourceDTO UpdateDTO(EnergySourceDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.EnergySourceId = this.EnergySourceId;
                dto.Name = this.Name;
                dto.Description = this.Description;
                dto.Active = this.Active;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("energySourceId")]
        public int EnergySourceId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("createBy")]
        public int? CreateBy { get; set; }

        [JsonProperty("createOn")]
        public System.DateTime? CreateOn { get; set; }

        [JsonProperty("updateBy")]
        public int? UpdateBy { get; set; }

        [JsonProperty("updateOn")]
        public System.DateTime? UpdateOn { get; set; }

        [JsonProperty("editUrl")]
        public string EditUrl { get; }



        // logging helper
        public static string FormatEnergySourceViewModel(EnergySourceViewModel energySourceViewModel)
        {
            if (energySourceViewModel == null)
            {
                // null
                return "energySourceViewModel: null";
            }
            else
            {
                // output values
                return "energySourceViewModel: \n"
                    + "{ \n"
 
                    + "    EnergySourceId: " +  "'" + energySourceViewModel.EnergySourceId + "'"  + ", \n" 
                    + "    Name: " + (energySourceViewModel.Name != null ? "'" + energySourceViewModel.Name + "'" : "null") + ", \n" 
                    + "    Description: " + (energySourceViewModel.Description != null ? "'" + energySourceViewModel.Description + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + energySourceViewModel.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + energySourceViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (energySourceViewModel.CreateBy != null ? "'" + energySourceViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (energySourceViewModel.CreateOn != null ? "'" + energySourceViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (energySourceViewModel.UpdateBy != null ? "'" + energySourceViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (energySourceViewModel.UpdateOn != null ? "'" + energySourceViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    