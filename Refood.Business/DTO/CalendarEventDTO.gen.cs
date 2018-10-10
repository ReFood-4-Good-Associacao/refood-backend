
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class CalendarEventDTO
    {
        public int CalendarEventId { get; set; }
        public int? NucleoId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public CalendarEventDTO()
        {
        
        }

        public CalendarEventDTO(R_CalendarEvent calendarEvent)
        {
            CalendarEventId = calendarEvent.CalendarEventId;
            NucleoId = calendarEvent.NucleoId;
            Name = calendarEvent.Name;
            Description = calendarEvent.Description;
            StartDate = calendarEvent.StartDate;
            EndDate = calendarEvent.EndDate;
            Active = calendarEvent.Active;
            IsDeleted = calendarEvent.IsDeleted;
            CreateBy = calendarEvent.CreateBy;
            CreateOn = calendarEvent.CreateOn;
            UpdateBy = calendarEvent.UpdateBy;
            UpdateOn = calendarEvent.UpdateOn;
        }

        public static R_CalendarEvent ConvertDTOtoEntity(CalendarEventDTO dto)
        {
            R_CalendarEvent calendarEvent = new R_CalendarEvent();

            calendarEvent.CalendarEventId = dto.CalendarEventId;
            calendarEvent.NucleoId = dto.NucleoId;
            calendarEvent.Name = dto.Name;
            calendarEvent.Description = dto.Description;
            calendarEvent.StartDate = dto.StartDate;
            calendarEvent.EndDate = dto.EndDate;
            calendarEvent.Active = dto.Active;
            calendarEvent.IsDeleted = dto.IsDeleted;
            calendarEvent.CreateBy = dto.CreateBy;
            calendarEvent.CreateOn = dto.CreateOn;
            calendarEvent.UpdateBy = dto.UpdateBy;
            calendarEvent.UpdateOn = dto.UpdateOn;

            return calendarEvent;
        }

        // logging helper
        public static string FormatCalendarEventDTO(CalendarEventDTO calendarEventDTO)
        {
            if(calendarEventDTO == null)
            {
                // null
                return "calendarEventDTO: null";
            }
            else
            {
                // output values
                return "calendarEventDTO: \n"
                    + "{ \n"
 
                    + "    CalendarEventId: " +  "'" + calendarEventDTO.CalendarEventId + "'"  + ", \n" 
                    + "    NucleoId: " + (calendarEventDTO.NucleoId != null ? "'" + calendarEventDTO.NucleoId + "'" : "null") + ", \n" 
                    + "    Name: " + (calendarEventDTO.Name != null ? "'" + calendarEventDTO.Name + "'" : "null") + ", \n" 
                    + "    Description: " + (calendarEventDTO.Description != null ? "'" + calendarEventDTO.Description + "'" : "null") + ", \n" 
                    + "    StartDate: " +  "'" + calendarEventDTO.StartDate + "'"  + ", \n" 
                    + "    EndDate: " +  "'" + calendarEventDTO.EndDate + "'"  + ", \n" 
                    + "    Active: " +  "'" + calendarEventDTO.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + calendarEventDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (calendarEventDTO.CreateBy != null ? "'" + calendarEventDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (calendarEventDTO.CreateOn != null ? "'" + calendarEventDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (calendarEventDTO.UpdateBy != null ? "'" + calendarEventDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (calendarEventDTO.UpdateOn != null ? "'" + calendarEventDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    