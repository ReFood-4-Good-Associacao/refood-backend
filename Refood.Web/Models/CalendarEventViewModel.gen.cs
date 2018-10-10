
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
    public partial class CalendarEventViewModel
    {
        public CalendarEventViewModel() { }

        public CalendarEventViewModel(CalendarEventDTO t)
        {
            CalendarEventId = t.CalendarEventId;
            NucleoId = t.NucleoId;
            Name = t.Name;
            Description = t.Description;
            StartDate = t.StartDate;
            EndDate = t.EndDate;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public CalendarEventViewModel(CalendarEventDTO t, string editUrl)
        {
            CalendarEventId = t.CalendarEventId;
            NucleoId = t.NucleoId;
            Name = t.Name;
            Description = t.Description;
            StartDate = t.StartDate;
            EndDate = t.EndDate;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
            EditUrl = editUrl;
        }

        public CalendarEventDTO UpdateDTO(CalendarEventDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.CalendarEventId = this.CalendarEventId;
                dto.NucleoId = this.NucleoId;
                dto.Name = this.Name;
                dto.Description = this.Description;
                dto.StartDate = this.StartDate;
                dto.EndDate = this.EndDate;
                dto.Active = this.Active;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("calendarEventId")]
        public int CalendarEventId { get; set; }

        [JsonProperty("nucleoId")]
        public int? NucleoId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("startDate")]
        public System.DateTime StartDate { get; set; }

        [JsonProperty("endDate")]
        public System.DateTime EndDate { get; set; }

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
        public static string FormatCalendarEventViewModel(CalendarEventViewModel calendarEventViewModel)
        {
            if (calendarEventViewModel == null)
            {
                // null
                return "calendarEventViewModel: null";
            }
            else
            {
                // output values
                return "calendarEventViewModel: \n"
                    + "{ \n"
 
                    + "    CalendarEventId: " +  "'" + calendarEventViewModel.CalendarEventId + "'"  + ", \n" 
                    + "    NucleoId: " + (calendarEventViewModel.NucleoId != null ? "'" + calendarEventViewModel.NucleoId + "'" : "null") + ", \n" 
                    + "    Name: " + (calendarEventViewModel.Name != null ? "'" + calendarEventViewModel.Name + "'" : "null") + ", \n" 
                    + "    Description: " + (calendarEventViewModel.Description != null ? "'" + calendarEventViewModel.Description + "'" : "null") + ", \n" 
                    + "    StartDate: " +  "'" + calendarEventViewModel.StartDate + "'"  + ", \n" 
                    + "    EndDate: " +  "'" + calendarEventViewModel.EndDate + "'"  + ", \n" 
                    + "    Active: " +  "'" + calendarEventViewModel.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + calendarEventViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (calendarEventViewModel.CreateBy != null ? "'" + calendarEventViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (calendarEventViewModel.CreateOn != null ? "'" + calendarEventViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (calendarEventViewModel.UpdateBy != null ? "'" + calendarEventViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (calendarEventViewModel.UpdateOn != null ? "'" + calendarEventViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    