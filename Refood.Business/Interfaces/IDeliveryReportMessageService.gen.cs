
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface IDeliveryReportMessageService
    {
        int AddDeliveryReportMessage(DeliveryReportMessageDTO dto);

        void DeleteDeliveryReportMessage(int deliveryReportMessageId);

        void DeleteDeliveryReportMessage(DeliveryReportMessageDTO dto);

        DeliveryReportMessageDTO GetDeliveryReportMessage(int deliveryReportMessageId);

        IEnumerable<DeliveryReportMessageDTO> GetDeliveryReportMessages();

        IList<DeliveryReportMessageDTO> GetDeliveryReportMessages(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<DeliveryReportMessageDTO> GetDeliveryReportMessageListAdvancedSearch(
            int? deliveryReportMessageTypeId 
            ,string message 
        );

        void UpdateDeliveryReportMessage(DeliveryReportMessageDTO dto);

    }
}
    