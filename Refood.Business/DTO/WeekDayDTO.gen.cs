
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class WeekDayDTO
    {
        public int WeekDayId { get; set; }
        public int? NucleoId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ResponsiblePersonId { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public WeekDayDTO()
        {
        
        }

        public WeekDayDTO(R_WeekDay weekDay)
        {
            WeekDayId = weekDay.WeekDayId;
            NucleoId = weekDay.NucleoId;
            Name = weekDay.Name;
            Description = weekDay.Description;
            ResponsiblePersonId = weekDay.ResponsiblePersonId;
            Active = weekDay.Active;
            IsDeleted = weekDay.IsDeleted;
            CreateBy = weekDay.CreateBy;
            CreateOn = weekDay.CreateOn;
            UpdateBy = weekDay.UpdateBy;
            UpdateOn = weekDay.UpdateOn;
        }

        public static R_WeekDay ConvertDTOtoEntity(WeekDayDTO dto)
        {
            R_WeekDay weekDay = new R_WeekDay();

            weekDay.WeekDayId = dto.WeekDayId;
            weekDay.NucleoId = dto.NucleoId;
            weekDay.Name = dto.Name;
            weekDay.Description = dto.Description;
            weekDay.ResponsiblePersonId = dto.ResponsiblePersonId;
            weekDay.Active = dto.Active;
            weekDay.IsDeleted = dto.IsDeleted;
            weekDay.CreateBy = dto.CreateBy;
            weekDay.CreateOn = dto.CreateOn;
            weekDay.UpdateBy = dto.UpdateBy;
            weekDay.UpdateOn = dto.UpdateOn;

            return weekDay;
        }

        // logging helper
        public static string FormatWeekDayDTO(WeekDayDTO weekDayDTO)
        {
            if(weekDayDTO == null)
            {
                // null
                return "weekDayDTO: null";
            }
            else
            {
                // output values
                return "weekDayDTO: \n"
                    + "{ \n"
 
                    + "    WeekDayId: " +  "'" + weekDayDTO.WeekDayId + "'"  + ", \n" 
                    + "    NucleoId: " + (weekDayDTO.NucleoId != null ? "'" + weekDayDTO.NucleoId + "'" : "null") + ", \n" 
                    + "    Name: " + (weekDayDTO.Name != null ? "'" + weekDayDTO.Name + "'" : "null") + ", \n" 
                    + "    Description: " + (weekDayDTO.Description != null ? "'" + weekDayDTO.Description + "'" : "null") + ", \n" 
                    + "    ResponsiblePersonId: " + (weekDayDTO.ResponsiblePersonId != null ? "'" + weekDayDTO.ResponsiblePersonId + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + weekDayDTO.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + weekDayDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (weekDayDTO.CreateBy != null ? "'" + weekDayDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (weekDayDTO.CreateOn != null ? "'" + weekDayDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (weekDayDTO.UpdateBy != null ? "'" + weekDayDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (weekDayDTO.UpdateOn != null ? "'" + weekDayDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    