
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class SupplierDTO
    {
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public int SupplierTypeId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string Description { get; set; }
        public string Website { get; set; }
        public int? AddressId { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public SupplierDTO()
        {
        
        }

        public SupplierDTO(R_Supplier supplier)
        {
            SupplierId = supplier.SupplierId;
            Name = supplier.Name;
            SupplierTypeId = supplier.SupplierTypeId;
            Phone = supplier.Phone;
            Email = supplier.Email;
            Latitude = supplier.Latitude;
            Longitude = supplier.Longitude;
            Description = supplier.Description;
            Website = supplier.Website;
            AddressId = supplier.AddressId;
            IsDeleted = supplier.IsDeleted;
            CreateBy = supplier.CreateBy;
            CreateOn = supplier.CreateOn;
            UpdateBy = supplier.UpdateBy;
            UpdateOn = supplier.UpdateOn;
        }

        public static R_Supplier ConvertDTOtoEntity(SupplierDTO dto)
        {
            R_Supplier supplier = new R_Supplier();

            supplier.SupplierId = dto.SupplierId;
            supplier.Name = dto.Name;
            supplier.SupplierTypeId = dto.SupplierTypeId;
            supplier.Phone = dto.Phone;
            supplier.Email = dto.Email;
            supplier.Latitude = dto.Latitude;
            supplier.Longitude = dto.Longitude;
            supplier.Description = dto.Description;
            supplier.Website = dto.Website;
            supplier.AddressId = dto.AddressId;
            supplier.IsDeleted = dto.IsDeleted;
            supplier.CreateBy = dto.CreateBy;
            supplier.CreateOn = dto.CreateOn;
            supplier.UpdateBy = dto.UpdateBy;
            supplier.UpdateOn = dto.UpdateOn;

            return supplier;
        }

        // logging helper
        public static string FormatSupplierDTO(SupplierDTO supplierDTO)
        {
            if(supplierDTO == null)
            {
                // null
                return "supplierDTO: null";
            }
            else
            {
                // output values
                return "supplierDTO: \n"
                    + "{ \n"
 
                    + "    SupplierId: " +  "'" + supplierDTO.SupplierId + "'"  + ", \n" 
                    + "    Name: " + (supplierDTO.Name != null ? "'" + supplierDTO.Name + "'" : "null") + ", \n" 
                    + "    SupplierTypeId: " +  "'" + supplierDTO.SupplierTypeId + "'"  + ", \n" 
                    + "    Phone: " + (supplierDTO.Phone != null ? "'" + supplierDTO.Phone + "'" : "null") + ", \n" 
                    + "    Email: " + (supplierDTO.Email != null ? "'" + supplierDTO.Email + "'" : "null") + ", \n" 
                    + "    Latitude: " + (supplierDTO.Latitude != null ? "'" + supplierDTO.Latitude + "'" : "null") + ", \n" 
                    + "    Longitude: " + (supplierDTO.Longitude != null ? "'" + supplierDTO.Longitude + "'" : "null") + ", \n" 
                    + "    Description: " + (supplierDTO.Description != null ? "'" + supplierDTO.Description + "'" : "null") + ", \n" 
                    + "    Website: " + (supplierDTO.Website != null ? "'" + supplierDTO.Website + "'" : "null") + ", \n" 
                    + "    AddressId: " + (supplierDTO.AddressId != null ? "'" + supplierDTO.AddressId + "'" : "null") + ", \n" 
                    + "    IsDeleted: " +  "'" + supplierDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (supplierDTO.CreateBy != null ? "'" + supplierDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (supplierDTO.CreateOn != null ? "'" + supplierDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (supplierDTO.UpdateBy != null ? "'" + supplierDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (supplierDTO.UpdateOn != null ? "'" + supplierDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    