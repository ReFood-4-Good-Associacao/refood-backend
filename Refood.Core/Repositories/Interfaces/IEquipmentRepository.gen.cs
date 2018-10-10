
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface IEquipmentRepository
    {
        int AddEquipment(R_Equipment t);

        void DeleteEquipment(R_Equipment t);

        void DeleteEquipment(int equipmentId);

        R_Equipment GetEquipment(int equipmentId);

        IEnumerable<R_Equipment> GetEquipments();

        IList<R_Equipment> GetEquipments(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_Equipment> GetEquipmentListAdvancedSearch(
            string name 
            , string description 
            , string category 
            , int? photo 
            , double? quantityInStock 
            , double? minimumQuantityNeeded 
            , double? pricePerUnit 
            , string storageLocation 
            , bool? active 
        );

        void UpdateEquipment(R_Equipment t);

    }
}

    