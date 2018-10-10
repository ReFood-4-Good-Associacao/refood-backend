
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class ExperimentalPhaseLogDTO
    {
        public int ExperimentalPhaseLogId { get; set; }
        public int? NucleoId { get; set; }
        public System.DateTime LogDate { get; set; }
        public string Task { get; set; }
        public string ActivityDescription { get; set; }
        public string ManagerName { get; set; }
        public string VolunteerName { get; set; }
        public bool VolunteerConfirmation { get; set; }
        public int? DocumentId { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public ExperimentalPhaseLogDTO()
        {
        
        }

        public ExperimentalPhaseLogDTO(R_ExperimentalPhaseLog experimentalPhaseLog)
        {
            ExperimentalPhaseLogId = experimentalPhaseLog.ExperimentalPhaseLogId;
            NucleoId = experimentalPhaseLog.NucleoId;
            LogDate = experimentalPhaseLog.LogDate;
            Task = experimentalPhaseLog.Task;
            ActivityDescription = experimentalPhaseLog.ActivityDescription;
            ManagerName = experimentalPhaseLog.ManagerName;
            VolunteerName = experimentalPhaseLog.VolunteerName;
            VolunteerConfirmation = experimentalPhaseLog.VolunteerConfirmation;
            DocumentId = experimentalPhaseLog.DocumentId;
            IsDeleted = experimentalPhaseLog.IsDeleted;
            CreateBy = experimentalPhaseLog.CreateBy;
            CreateOn = experimentalPhaseLog.CreateOn;
            UpdateBy = experimentalPhaseLog.UpdateBy;
            UpdateOn = experimentalPhaseLog.UpdateOn;
        }

        public static R_ExperimentalPhaseLog ConvertDTOtoEntity(ExperimentalPhaseLogDTO dto)
        {
            R_ExperimentalPhaseLog experimentalPhaseLog = new R_ExperimentalPhaseLog();

            experimentalPhaseLog.ExperimentalPhaseLogId = dto.ExperimentalPhaseLogId;
            experimentalPhaseLog.NucleoId = dto.NucleoId;
            experimentalPhaseLog.LogDate = dto.LogDate;
            experimentalPhaseLog.Task = dto.Task;
            experimentalPhaseLog.ActivityDescription = dto.ActivityDescription;
            experimentalPhaseLog.ManagerName = dto.ManagerName;
            experimentalPhaseLog.VolunteerName = dto.VolunteerName;
            experimentalPhaseLog.VolunteerConfirmation = dto.VolunteerConfirmation;
            experimentalPhaseLog.DocumentId = dto.DocumentId;
            experimentalPhaseLog.IsDeleted = dto.IsDeleted;
            experimentalPhaseLog.CreateBy = dto.CreateBy;
            experimentalPhaseLog.CreateOn = dto.CreateOn;
            experimentalPhaseLog.UpdateBy = dto.UpdateBy;
            experimentalPhaseLog.UpdateOn = dto.UpdateOn;

            return experimentalPhaseLog;
        }

        // logging helper
        public static string FormatExperimentalPhaseLogDTO(ExperimentalPhaseLogDTO experimentalPhaseLogDTO)
        {
            if(experimentalPhaseLogDTO == null)
            {
                // null
                return "experimentalPhaseLogDTO: null";
            }
            else
            {
                // output values
                return "experimentalPhaseLogDTO: \n"
                    + "{ \n"
 
                    + "    ExperimentalPhaseLogId: " +  "'" + experimentalPhaseLogDTO.ExperimentalPhaseLogId + "'"  + ", \n" 
                    + "    NucleoId: " + (experimentalPhaseLogDTO.NucleoId != null ? "'" + experimentalPhaseLogDTO.NucleoId + "'" : "null") + ", \n" 
                    + "    LogDate: " +  "'" + experimentalPhaseLogDTO.LogDate + "'"  + ", \n" 
                    + "    Task: " + (experimentalPhaseLogDTO.Task != null ? "'" + experimentalPhaseLogDTO.Task + "'" : "null") + ", \n" 
                    + "    ActivityDescription: " + (experimentalPhaseLogDTO.ActivityDescription != null ? "'" + experimentalPhaseLogDTO.ActivityDescription + "'" : "null") + ", \n" 
                    + "    ManagerName: " + (experimentalPhaseLogDTO.ManagerName != null ? "'" + experimentalPhaseLogDTO.ManagerName + "'" : "null") + ", \n" 
                    + "    VolunteerName: " + (experimentalPhaseLogDTO.VolunteerName != null ? "'" + experimentalPhaseLogDTO.VolunteerName + "'" : "null") + ", \n" 
                    + "    VolunteerConfirmation: " +  "'" + experimentalPhaseLogDTO.VolunteerConfirmation + "'"  + ", \n" 
                    + "    DocumentId: " + (experimentalPhaseLogDTO.DocumentId != null ? "'" + experimentalPhaseLogDTO.DocumentId + "'" : "null") + ", \n" 
                    + "    IsDeleted: " +  "'" + experimentalPhaseLogDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (experimentalPhaseLogDTO.CreateBy != null ? "'" + experimentalPhaseLogDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (experimentalPhaseLogDTO.CreateOn != null ? "'" + experimentalPhaseLogDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (experimentalPhaseLogDTO.UpdateBy != null ? "'" + experimentalPhaseLogDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (experimentalPhaseLogDTO.UpdateOn != null ? "'" + experimentalPhaseLogDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    