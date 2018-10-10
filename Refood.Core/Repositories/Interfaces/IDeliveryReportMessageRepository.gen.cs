
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface IDeliveryReportMessageRepository
    {
        int AddDeliveryReportMessage(R_DeliveryReportMessage t);

        void DeleteDeliveryReportMessage(R_DeliveryReportMessage t);

        void DeleteDeliveryReportMessage(int deliveryReportMessageId);

        R_DeliveryReportMessage GetDeliveryReportMessage(int deliveryReportMessageId);

        IEnumerable<R_DeliveryReportMessage> GetDeliveryReportMessages();

        IList<R_DeliveryReportMessage> GetDeliveryReportMessages(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_DeliveryReportMessage> GetDeliveryReportMessageListAdvancedSearch(
            int? deliveryReportMessageTypeId 
            , string message 
        );

        void UpdateDeliveryReportMessage(R_DeliveryReportMessage t);

    }
}

    