
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class CheckpointDTO
    {
        public int CheckpointId { get; set; }
        public string Name { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public int? AddressId { get; set; }
        public int EstimatedTimeArrival { get; set; }
        public System.DateTime? MinimumTime { get; set; }
        public System.DateTime? MaximumTime { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public CheckpointDTO()
        {
        
        }

        public CheckpointDTO(R_Checkpoint checkpoint)
        {
            CheckpointId = checkpoint.CheckpointId;
            Name = checkpoint.Name;
            Latitude = checkpoint.Latitude;
            Longitude = checkpoint.Longitude;
            AddressId = checkpoint.AddressId;
            EstimatedTimeArrival = checkpoint.EstimatedTimeArrival;
            MinimumTime = checkpoint.MinimumTime;
            MaximumTime = checkpoint.MaximumTime;
            Active = checkpoint.Active;
            IsDeleted = checkpoint.IsDeleted;
            CreateBy = checkpoint.CreateBy;
            CreateOn = checkpoint.CreateOn;
            UpdateBy = checkpoint.UpdateBy;
            UpdateOn = checkpoint.UpdateOn;
        }

        public static R_Checkpoint ConvertDTOtoEntity(CheckpointDTO dto)
        {
            R_Checkpoint checkpoint = new R_Checkpoint();

            checkpoint.CheckpointId = dto.CheckpointId;
            checkpoint.Name = dto.Name;
            checkpoint.Latitude = dto.Latitude;
            checkpoint.Longitude = dto.Longitude;
            checkpoint.AddressId = dto.AddressId;
            checkpoint.EstimatedTimeArrival = dto.EstimatedTimeArrival;
            checkpoint.MinimumTime = dto.MinimumTime;
            checkpoint.MaximumTime = dto.MaximumTime;
            checkpoint.Active = dto.Active;
            checkpoint.IsDeleted = dto.IsDeleted;
            checkpoint.CreateBy = dto.CreateBy;
            checkpoint.CreateOn = dto.CreateOn;
            checkpoint.UpdateBy = dto.UpdateBy;
            checkpoint.UpdateOn = dto.UpdateOn;

            return checkpoint;
        }

        // logging helper
        public static string FormatCheckpointDTO(CheckpointDTO checkpointDTO)
        {
            if(checkpointDTO == null)
            {
                // null
                return "checkpointDTO: null";
            }
            else
            {
                // output values
                return "checkpointDTO: \n"
                    + "{ \n"
 
                    + "    CheckpointId: " +  "'" + checkpointDTO.CheckpointId + "'"  + ", \n" 
                    + "    Name: " + (checkpointDTO.Name != null ? "'" + checkpointDTO.Name + "'" : "null") + ", \n" 
                    + "    Latitude: " + (checkpointDTO.Latitude != null ? "'" + checkpointDTO.Latitude + "'" : "null") + ", \n" 
                    + "    Longitude: " + (checkpointDTO.Longitude != null ? "'" + checkpointDTO.Longitude + "'" : "null") + ", \n" 
                    + "    AddressId: " + (checkpointDTO.AddressId != null ? "'" + checkpointDTO.AddressId + "'" : "null") + ", \n" 
                    + "    EstimatedTimeArrival: " +  "'" + checkpointDTO.EstimatedTimeArrival + "'"  + ", \n" 
                    + "    MinimumTime: " + (checkpointDTO.MinimumTime != null ? "'" + checkpointDTO.MinimumTime + "'" : "null") + ", \n" 
                    + "    MaximumTime: " + (checkpointDTO.MaximumTime != null ? "'" + checkpointDTO.MaximumTime + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + checkpointDTO.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + checkpointDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (checkpointDTO.CreateBy != null ? "'" + checkpointDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (checkpointDTO.CreateOn != null ? "'" + checkpointDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (checkpointDTO.UpdateBy != null ? "'" + checkpointDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (checkpointDTO.UpdateOn != null ? "'" + checkpointDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    