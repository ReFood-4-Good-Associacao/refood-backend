
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;
using Refood.Core.Repositories.Interfaces;

namespace Refood.Core.Repositories
{
    public partial class EquipmentRepository : IEquipmentRepository
    {
        public int AddEquipment(R_Equipment t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteEquipment(R_Equipment t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteEquipment(int equipmentId)
        {
            var t = GetEquipment(equipmentId);
            DeleteEquipment(t);
        }

        public R_Equipment GetEquipment(int equipmentId)
        {
            //Requires.NotNegative("equipmentId", equipmentId);
            
            R_Equipment t = R_Equipment.SingleOrDefault(equipmentId);

            return t;
        }

        public IEnumerable<R_Equipment> GetEquipments()
        {
             
            IEnumerable<R_Equipment> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Equipment")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_Equipment.Query(sql);

            return results;
        }

        public IList<R_Equipment> GetEquipments(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_Equipment> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Equipment")
                .Where("IsDeleted = 0")
                .Where(
                    "Name like '%" + searchTerm + "%'"
                     + " or " + "Description like '%" + searchTerm + "%'"
                     + " or " + "Category like '%" + searchTerm + "%'"
                     + " or " + "StorageLocation like '%" + searchTerm + "%'"
                )
            ;

            results = R_Equipment.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_Equipment> GetEquipmentListAdvancedSearch(
            string name 
            , string description 
            , string category 
            , int? photo 
            , double? quantityInStock 
            , double? minimumQuantityNeeded 
            , double? pricePerUnit 
            , string storageLocation 
            , bool? active 
        )
        {
            IEnumerable<R_Equipment> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Equipment")
                .Where("IsDeleted = 0" 
                    + (name != null ? " and Name like '%" + name + "%'" : "")
                    + (description != null ? " and Description like '%" + description + "%'" : "")
                    + (category != null ? " and Category like '%" + category + "%'" : "")
                    + (photo != null ? " and Photo like '%" + photo + "%'" : "")
                    + (quantityInStock != null ? " and QuantityInStock like '%" + quantityInStock + "%'" : "")
                    + (minimumQuantityNeeded != null ? " and MinimumQuantityNeeded like '%" + minimumQuantityNeeded + "%'" : "")
                    + (pricePerUnit != null ? " and PricePerUnit like '%" + pricePerUnit + "%'" : "")
                    + (storageLocation != null ? " and StorageLocation like '%" + storageLocation + "%'" : "")
                    + (active != null ? " and Active = " + (active == true ? "1" : "0") : "")
                 )
            ;

            results = R_Equipment.Query(sql);

            return results;
        }

        public void UpdateEquipment(R_Equipment t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "EquipmentId");

            t.Update();
        }

    }
}

        