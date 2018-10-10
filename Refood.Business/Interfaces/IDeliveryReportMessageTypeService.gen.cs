
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface IDeliveryReportMessageTypeService
    {
        int AddDeliveryReportMessageType(DeliveryReportMessageTypeDTO dto);

        void DeleteDeliveryReportMessageType(int deliveryReportMessageTypeId);

        void DeleteDeliveryReportMessageType(DeliveryReportMessageTypeDTO dto);

        DeliveryReportMessageTypeDTO GetDeliveryReportMessageType(int deliveryReportMessageTypeId);

        IEnumerable<DeliveryReportMessageTypeDTO> GetDeliveryReportMessageTypes();

        IList<DeliveryReportMessageTypeDTO> GetDeliveryReportMessageTypes(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<DeliveryReportMessageTypeDTO> GetDeliveryReportMessageTypeListAdvancedSearch(
            string name 
            ,string description 
            ,bool? active 
        );

        void UpdateDeliveryReportMessageType(DeliveryReportMessageTypeDTO dto);

    }
}
    