
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class TutorialDTO
    {
        public int TutorialId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public bool IsOnlineTutorial { get; set; }
        public string Language { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public TutorialDTO()
        {
        
        }

        public TutorialDTO(R_Tutorial tutorial)
        {
            TutorialId = tutorial.TutorialId;
            Name = tutorial.Name;
            Description = tutorial.Description;
            Location = tutorial.Location;
            IsOnlineTutorial = tutorial.IsOnlineTutorial;
            Language = tutorial.Language;
            Active = tutorial.Active;
            IsDeleted = tutorial.IsDeleted;
            CreateBy = tutorial.CreateBy;
            CreateOn = tutorial.CreateOn;
            UpdateBy = tutorial.UpdateBy;
            UpdateOn = tutorial.UpdateOn;
        }

        public static R_Tutorial ConvertDTOtoEntity(TutorialDTO dto)
        {
            R_Tutorial tutorial = new R_Tutorial();

            tutorial.TutorialId = dto.TutorialId;
            tutorial.Name = dto.Name;
            tutorial.Description = dto.Description;
            tutorial.Location = dto.Location;
            tutorial.IsOnlineTutorial = dto.IsOnlineTutorial;
            tutorial.Language = dto.Language;
            tutorial.Active = dto.Active;
            tutorial.IsDeleted = dto.IsDeleted;
            tutorial.CreateBy = dto.CreateBy;
            tutorial.CreateOn = dto.CreateOn;
            tutorial.UpdateBy = dto.UpdateBy;
            tutorial.UpdateOn = dto.UpdateOn;

            return tutorial;
        }

        // logging helper
        public static string FormatTutorialDTO(TutorialDTO tutorialDTO)
        {
            if(tutorialDTO == null)
            {
                // null
                return "tutorialDTO: null";
            }
            else
            {
                // output values
                return "tutorialDTO: \n"
                    + "{ \n"
 
                    + "    TutorialId: " +  "'" + tutorialDTO.TutorialId + "'"  + ", \n" 
                    + "    Name: " + (tutorialDTO.Name != null ? "'" + tutorialDTO.Name + "'" : "null") + ", \n" 
                    + "    Description: " + (tutorialDTO.Description != null ? "'" + tutorialDTO.Description + "'" : "null") + ", \n" 
                    + "    Location: " + (tutorialDTO.Location != null ? "'" + tutorialDTO.Location + "'" : "null") + ", \n" 
                    + "    IsOnlineTutorial: " +  "'" + tutorialDTO.IsOnlineTutorial + "'"  + ", \n" 
                    + "    Language: " + (tutorialDTO.Language != null ? "'" + tutorialDTO.Language + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + tutorialDTO.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + tutorialDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (tutorialDTO.CreateBy != null ? "'" + tutorialDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (tutorialDTO.CreateOn != null ? "'" + tutorialDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (tutorialDTO.UpdateBy != null ? "'" + tutorialDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (tutorialDTO.UpdateOn != null ? "'" + tutorialDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    