
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
    public partial class WeekDayViewModel
    {
        public WeekDayViewModel() { }

        public WeekDayViewModel(WeekDayDTO t)
        {
            WeekDayId = t.WeekDayId;
            NucleoId = t.NucleoId;
            Name = t.Name;
            Description = t.Description;
            ResponsiblePersonId = t.ResponsiblePersonId;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public WeekDayViewModel(WeekDayDTO t, string editUrl)
        {
            WeekDayId = t.WeekDayId;
            NucleoId = t.NucleoId;
            Name = t.Name;
            Description = t.Description;
            ResponsiblePersonId = t.ResponsiblePersonId;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
            EditUrl = editUrl;
        }

        public WeekDayDTO UpdateDTO(WeekDayDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.WeekDayId = this.WeekDayId;
                dto.NucleoId = this.NucleoId;
                dto.Name = this.Name;
                dto.Description = this.Description;
                dto.ResponsiblePersonId = this.ResponsiblePersonId;
                dto.Active = this.Active;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("weekDayId")]
        public int WeekDayId { get; set; }

        [JsonProperty("nucleoId")]
        public int? NucleoId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("responsiblePersonId")]
        public int? ResponsiblePersonId { get; set; }

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
        public static string FormatWeekDayViewModel(WeekDayViewModel weekDayViewModel)
        {
            if (weekDayViewModel == null)
            {
                // null
                return "weekDayViewModel: null";
            }
            else
            {
                // output values
                return "weekDayViewModel: \n"
                    + "{ \n"
 
                    + "    WeekDayId: " +  "'" + weekDayViewModel.WeekDayId + "'"  + ", \n" 
                    + "    NucleoId: " + (weekDayViewModel.NucleoId != null ? "'" + weekDayViewModel.NucleoId + "'" : "null") + ", \n" 
                    + "    Name: " + (weekDayViewModel.Name != null ? "'" + weekDayViewModel.Name + "'" : "null") + ", \n" 
                    + "    Description: " + (weekDayViewModel.Description != null ? "'" + weekDayViewModel.Description + "'" : "null") + ", \n" 
                    + "    ResponsiblePersonId: " + (weekDayViewModel.ResponsiblePersonId != null ? "'" + weekDayViewModel.ResponsiblePersonId + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + weekDayViewModel.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + weekDayViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (weekDayViewModel.CreateBy != null ? "'" + weekDayViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (weekDayViewModel.CreateOn != null ? "'" + weekDayViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (weekDayViewModel.UpdateBy != null ? "'" + weekDayViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (weekDayViewModel.UpdateOn != null ? "'" + weekDayViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    