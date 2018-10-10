
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
    public partial class SupplierTypeViewModel
    {
        public SupplierTypeViewModel() { }

        public SupplierTypeViewModel(SupplierTypeDTO t)
        {
            SupplierTypeId = t.SupplierTypeId;
            Name = t.Name;
            Description = t.Description;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public SupplierTypeViewModel(SupplierTypeDTO t, string editUrl)
        {
            SupplierTypeId = t.SupplierTypeId;
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

        public SupplierTypeDTO UpdateDTO(SupplierTypeDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.SupplierTypeId = this.SupplierTypeId;
                dto.Name = this.Name;
                dto.Description = this.Description;
                dto.Active = this.Active;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("supplierTypeId")]
        public int SupplierTypeId { get; set; }

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
        public static string FormatSupplierTypeViewModel(SupplierTypeViewModel supplierTypeViewModel)
        {
            if (supplierTypeViewModel == null)
            {
                // null
                return "supplierTypeViewModel: null";
            }
            else
            {
                // output values
                return "supplierTypeViewModel: \n"
                    + "{ \n"
 
                    + "    SupplierTypeId: " +  "'" + supplierTypeViewModel.SupplierTypeId + "'"  + ", \n" 
                    + "    Name: " + (supplierTypeViewModel.Name != null ? "'" + supplierTypeViewModel.Name + "'" : "null") + ", \n" 
                    + "    Description: " + (supplierTypeViewModel.Description != null ? "'" + supplierTypeViewModel.Description + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + supplierTypeViewModel.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + supplierTypeViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (supplierTypeViewModel.CreateBy != null ? "'" + supplierTypeViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (supplierTypeViewModel.CreateOn != null ? "'" + supplierTypeViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (supplierTypeViewModel.UpdateBy != null ? "'" + supplierTypeViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (supplierTypeViewModel.UpdateOn != null ? "'" + supplierTypeViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    