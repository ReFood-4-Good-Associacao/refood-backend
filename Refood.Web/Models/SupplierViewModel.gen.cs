
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
    public partial class SupplierViewModel
    {
        public SupplierViewModel() { }

        public SupplierViewModel(SupplierDTO t)
        {
            SupplierId = t.SupplierId;
            Name = t.Name;
            SupplierTypeId = t.SupplierTypeId;
            Phone = t.Phone;
            Email = t.Email;
            Latitude = t.Latitude;
            Longitude = t.Longitude;
            Description = t.Description;
            Website = t.Website;
            AddressId = t.AddressId;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public SupplierViewModel(SupplierDTO t, string editUrl)
        {
            SupplierId = t.SupplierId;
            Name = t.Name;
            SupplierTypeId = t.SupplierTypeId;
            Phone = t.Phone;
            Email = t.Email;
            Latitude = t.Latitude;
            Longitude = t.Longitude;
            Description = t.Description;
            Website = t.Website;
            AddressId = t.AddressId;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
            EditUrl = editUrl;
        }

        public SupplierDTO UpdateDTO(SupplierDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.SupplierId = this.SupplierId;
                dto.Name = this.Name;
                dto.SupplierTypeId = this.SupplierTypeId;
                dto.Phone = this.Phone;
                dto.Email = this.Email;
                dto.Latitude = this.Latitude;
                dto.Longitude = this.Longitude;
                dto.Description = this.Description;
                dto.Website = this.Website;
                dto.AddressId = this.AddressId;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("supplierId")]
        public int SupplierId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("supplierTypeId")]
        public int SupplierTypeId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("latitude")]
        public double? Latitude { get; set; }

        [JsonProperty("longitude")]
        public double? Longitude { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("addressId")]
        public int? AddressId { get; set; }

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
        public static string FormatSupplierViewModel(SupplierViewModel supplierViewModel)
        {
            if (supplierViewModel == null)
            {
                // null
                return "supplierViewModel: null";
            }
            else
            {
                // output values
                return "supplierViewModel: \n"
                    + "{ \n"
 
                    + "    SupplierId: " +  "'" + supplierViewModel.SupplierId + "'"  + ", \n" 
                    + "    Name: " + (supplierViewModel.Name != null ? "'" + supplierViewModel.Name + "'" : "null") + ", \n" 
                    + "    SupplierTypeId: " +  "'" + supplierViewModel.SupplierTypeId + "'"  + ", \n" 
                    + "    Phone: " + (supplierViewModel.Phone != null ? "'" + supplierViewModel.Phone + "'" : "null") + ", \n" 
                    + "    Email: " + (supplierViewModel.Email != null ? "'" + supplierViewModel.Email + "'" : "null") + ", \n" 
                    + "    Latitude: " + (supplierViewModel.Latitude != null ? "'" + supplierViewModel.Latitude + "'" : "null") + ", \n" 
                    + "    Longitude: " + (supplierViewModel.Longitude != null ? "'" + supplierViewModel.Longitude + "'" : "null") + ", \n" 
                    + "    Description: " + (supplierViewModel.Description != null ? "'" + supplierViewModel.Description + "'" : "null") + ", \n" 
                    + "    Website: " + (supplierViewModel.Website != null ? "'" + supplierViewModel.Website + "'" : "null") + ", \n" 
                    + "    AddressId: " + (supplierViewModel.AddressId != null ? "'" + supplierViewModel.AddressId + "'" : "null") + ", \n" 
                    + "    IsDeleted: " +  "'" + supplierViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (supplierViewModel.CreateBy != null ? "'" + supplierViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (supplierViewModel.CreateOn != null ? "'" + supplierViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (supplierViewModel.UpdateBy != null ? "'" + supplierViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (supplierViewModel.UpdateOn != null ? "'" + supplierViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    