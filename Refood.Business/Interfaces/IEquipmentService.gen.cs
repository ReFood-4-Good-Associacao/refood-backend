
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface IEquipmentService
    {
        int AddEquipment(EquipmentDTO dto);

        void DeleteEquipment(int equipmentId);

        void DeleteEquipment(EquipmentDTO dto);

        EquipmentDTO GetEquipment(int equipmentId);

        IEnumerable<EquipmentDTO> GetEquipments();

        IList<EquipmentDTO> GetEquipments(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<EquipmentDTO> GetEquipmentListAdvancedSearch(
            string name 
            ,string description 
            ,string category 
            ,int? photo 
            ,double? quantityInStock 
            ,double? minimumQuantityNeeded 
            ,double? pricePerUnit 
            ,string storageLocation 
            ,bool? active 
        );

        void UpdateEquipment(EquipmentDTO dto);

    }
}
    