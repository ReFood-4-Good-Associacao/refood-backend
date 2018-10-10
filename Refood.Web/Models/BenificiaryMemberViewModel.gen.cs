
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
    public partial class BenificiaryMemberViewModel
    {
        public BenificiaryMemberViewModel() { }

        public BenificiaryMemberViewModel(BenificiaryMemberDTO t)
        {
            BenificiaryMemberId = t.BenificiaryMemberId;
            BenificiaryId = t.BenificiaryId;
            Name = t.Name;
            IsChild = t.IsChild;
            Description = t.Description;
            BirthDate = t.BirthDate;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public BenificiaryMemberViewModel(BenificiaryMemberDTO t, string editUrl)
        {
            BenificiaryMemberId = t.BenificiaryMemberId;
            BenificiaryId = t.BenificiaryId;
            Name = t.Name;
            IsChild = t.IsChild;
            Description = t.Description;
            BirthDate = t.BirthDate;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
            EditUrl = editUrl;
        }

        public BenificiaryMemberDTO UpdateDTO(BenificiaryMemberDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.BenificiaryMemberId = this.BenificiaryMemberId;
                dto.BenificiaryId = this.BenificiaryId;
                dto.Name = this.Name;
                dto.IsChild = this.IsChild;
                dto.Description = this.Description;
                dto.BirthDate = this.BirthDate;
                dto.Active = this.Active;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("benificiaryMemberId")]
        public int BenificiaryMemberId { get; set; }

        [JsonProperty("benificiaryId")]
        public int? BenificiaryId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isChild")]
        public bool IsChild { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("birthDate")]
        public System.DateTime? BirthDate { get; set; }

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
        public static string FormatBenificiaryMemberViewModel(BenificiaryMemberViewModel benificiaryMemberViewModel)
        {
            if (benificiaryMemberViewModel == null)
            {
                // null
                return "benificiaryMemberViewModel: null";
            }
            else
            {
                // output values
                return "benificiaryMemberViewModel: \n"
                    + "{ \n"
 
                    + "    BenificiaryMemberId: " +  "'" + benificiaryMemberViewModel.BenificiaryMemberId + "'"  + ", \n" 
                    + "    BenificiaryId: " + (benificiaryMemberViewModel.BenificiaryId != null ? "'" + benificiaryMemberViewModel.BenificiaryId + "'" : "null") + ", \n" 
                    + "    Name: " + (benificiaryMemberViewModel.Name != null ? "'" + benificiaryMemberViewModel.Name + "'" : "null") + ", \n" 
                    + "    IsChild: " + "'" + benificiaryMemberViewModel.IsChild + "'" + ", \n" 
                    + "    Description: " + (benificiaryMemberViewModel.Description != null ? "'" + benificiaryMemberViewModel.Description + "'" : "null") + ", \n" 
                    + "    BirthDate: " + (benificiaryMemberViewModel.BirthDate != null ? "'" + benificiaryMemberViewModel.BirthDate + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + benificiaryMemberViewModel.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + benificiaryMemberViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (benificiaryMemberViewModel.CreateBy != null ? "'" + benificiaryMemberViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (benificiaryMemberViewModel.CreateOn != null ? "'" + benificiaryMemberViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (benificiaryMemberViewModel.UpdateBy != null ? "'" + benificiaryMemberViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (benificiaryMemberViewModel.UpdateOn != null ? "'" + benificiaryMemberViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    